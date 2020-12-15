using Microsoft.EntityFrameworkCore;
using sonorous.Core.Services.Interfaces;
using sonorous.Datalayer.Context;
using sonorous.Datalayer.Entites.Order;
using sonorous.Datalayer.Entites.Product;
using sonorous.Datalayer.Entites.Wallett;
using System;
using System.Collections.Generic;
using System.Linq;
using sonorous.Datalayer.Entites.User;
using sonorous.Core.DTOs;
using System.Text;

namespace sonorous.Core.Services
{
    public class OrderServices : IOrderServices
    {
        private SonorousContext _db;
        private IUserServices _userServices;

        public OrderServices(SonorousContext db,IUserServices userServices)
        {
            _db = db;
            _userServices = userServices;
        }

        public void Adddiscont(Discount discount)
        {
            _db.Discounts.Add(discount);
            _db.SaveChanges();
        }

        public int addorder(string username, int productid)
        {
            int userid = _userServices.getuseridbyusername(username);

            Order order = _db.Orders.FirstOrDefault(o => o.UserID == userid && !o.isFinaly);

            var product = _db.Products.Find(productid);

            if (order == null)
            {
                order = new Order()
                {
                    UserID=userid,
                    isFinaly=false,
                    Createdate=DateTime.Now,
                    OrderSum=product.ProductPrice,
                    OrderDetails=new List<OrderDetails>()
                    {
                        new OrderDetails()
                        {
                            ProductID=productid,
                            Count=1,
                            Price=product.ProductPrice,

                        }
                    }

                };
                _db.Orders.Add(order);
                _db.SaveChanges();

            }
            else
            {
                OrderDetails detail = _db.OrderDetails.FirstOrDefault(d => d.OrderID == order.OrderID&&d.ProductID==productid);
                if (detail != null)
                {
                    detail.Count += 1;
                    _db.OrderDetails.Update(detail);
                }
                else
                {
                    detail = new OrderDetails()
                    {
                        OrderID=order.OrderID,
                        Count=1,
                        ProductID=productid,
                        Price=product.ProductPrice,
                    };
                    _db.OrderDetails.Add(detail);
                }

                _db.SaveChanges();
                UpdatePriceOrder(order.OrderID);
            }

            
            
            return order.OrderID;

        }

        public bool finalorder(string username,int orderid)
        {
            int userid = _userServices.getuseridbyusername(username);
            var order = _db.Orders.Include(o => o.OrderDetails).ThenInclude(od => od.Product)
                 .FirstOrDefault(o => o.OrderID == orderid&&o.UserID==userid);

            if(order==null || order.isFinaly)
            {
                return false;
            }
            if (_userServices.balancewallett(username) >= order.OrderSum)
            {
                order.isFinaly = true;
                _userServices.addwallett(new Wallett()
                {
                    Amount = order.OrderSum,
                    CreateDate = DateTime.Now,
                    ispay = true,
                    Description = "فاکتور شما #" + order.OrderID,
                    UserID=userid,
                    TypeID=2,

                });
                _db.Orders.Update(order);

                foreach(var item in order.OrderDetails)
                {
                    _db.UserProducts.Add(new UserProducts()
                    {
                        ProductID = item.ProductID,
                        UserID = userid

                    });
                }
                _db.SaveChanges();
                return true;
            }
            return false;

        }

        public List<Discount> getalldiscounts()
        {
            return _db.Discounts.ToList();
        }

        public List<Order> getallorders(string username)
        {
            int userid = _userServices.getuseridbyusername(username);

            return _db.Orders.Where(o => o.UserID == userid).Include(o=>o.OrderDetails).ToList();
        }

        public Discount GetDiscountbyid(int id)
        {
            return _db.Discounts.Find(id);
        }

        public Order getorderbyID(int orderid)
        {
            return _db.Orders.Find(orderid);
        }

        public Order getorderforuserpanel(string username, int orderid)
        {
            int userid = _userServices.getuseridbyusername(username);

            return _db.Orders.Include(o => o.OrderDetails).ThenInclude(od=>od.Product).FirstOrDefault(o => o.UserID == userid && o.OrderID == orderid);
        }

        public bool isExistcode(string code)
        {
            return _db.Discounts.Any(p => p.Discountcode == code);  
        }

        public void updatediscount(Discount discount)
        {
            _db.Discounts.Update(discount);
            _db.SaveChanges();
        }

        public void Updateorder(Order order)
        {
            _db.Orders.Update(order);
            _db.SaveChanges();
        }

        public void UpdatePriceOrder(int orderid)
        {
            var order = _db.Orders.Find(orderid);
            order.OrderSum = _db.OrderDetails.Where(d => d.OrderID == orderid).Sum(d => d.Price);
            _db.Orders.Update(order);
            _db.SaveChanges();
        }

        public DiscountuseType useDiscount(int orderid, string code)
        {
            var discount = _db.Discounts.SingleOrDefault(p => p.Discountcode == code);

            if (discount == null)
            {
                return DiscountuseType.NotFound;
            }

            if (discount.StartDate != null && discount.StartDate < DateTime.Now)
            {
                return DiscountuseType.ExpireDate;
            }

            if (discount.EndDate != null && discount.EndDate >= DateTime.Now)
            {
                return DiscountuseType.ExpireDate;
            }

            if (discount.UsableCount != null && discount.UsableCount < 1)
            {
                return DiscountuseType.Finished;
            }
            var order = getorderbyID(orderid);

            if (_db.UserDiscountCodes.Any(p => p.UserID == order.UserID && p.DiscountID == discount.DiscountID))
            {
                return DiscountuseType.UserUsed;
            }


            int percent = (order.OrderSum * discount.DiscountPercent) / 100;

            order.OrderSum = order.OrderSum - percent;

            Updateorder(order);

            if (discount.UsableCount != null)
            {
                discount.UsableCount -= 1;
            }

            _db.Discounts.Update(discount);
            _db.UserDiscountCodes.Add(new UserDiscountCode()
            {
                UserID=order.UserID,
                DiscountID=discount.DiscountID,


            });
            _db.SaveChanges();

            return DiscountuseType.Success;
        }
    }
}
