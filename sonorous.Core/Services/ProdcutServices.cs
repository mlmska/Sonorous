using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sonorous.Core.Convertors;
using sonorous.Core.DTOs;
using sonorous.Core.Generators;
using sonorous.Core.Security;
using sonorous.Core.Services.Interfaces;
using sonorous.Datalayer.Context;
using sonorous.Datalayer.Entites.Product;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace sonorous.Core.Services
{
    public class ProdcutServices:IProductServices
    {
        private SonorousContext _db;

        public ProdcutServices(SonorousContext db)
        {
            _db = db;
        }

        public void AddComment(ProductComment comment)
        {
            _db.ProductComments.Add(comment);
            _db.SaveChanges();
        }

        public int addProduct(Product product, IFormFile proimg)
        {
            product.Createdate = DateTime.Now;
            product.ProductImageName = "no-photo.jpg";

            if (proimg != null && proimg.IsImage())
            {
                product.ProductImageName= NameGenerator.Generateuniqcode() + Path.GetExtension(proimg.FileName);
                string imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Products/image",product.ProductImageName);
                
                
                using (var stream = new FileStream(imagepath, FileMode.Create))
                {
                    proimg.CopyTo(stream);
                }
                ImageConvertor imgresizer = new ImageConvertor();
                string thumbpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Products/thumb", product.ProductImageName);
                imgresizer.Image_resize(imagepath, thumbpath, 150);


            }

            _db.Add(product);
            _db.SaveChanges();
            return product.ProductID;
        }

        public List<Product_Group> Getallgroup()
        {
            return _db.product_Groups.ToList();
        }

        public List<SelectListItem> Getgroupsformanageproduct()
        {
            return _db.product_Groups.Where(p => p.ParentID == null).Select(p => new SelectListItem()
            {
                Text = p.GroupTitle,
                Value = p.GroupID.ToString()
            }).ToList();
        }

        public List<SelectListItem> Getlevels()
        {
            return _db.ProductLevels.Select(p => new SelectListItem()
            {
                Value = p.LevelID.ToString(),
                Text = p.LevelTitle
            }).ToList();
        }

        public Tuple<List<ShowProductListViewModel>, int> GetProduct(int pageid = 1, string filter = "", string gettype = "all",
            string orderbytype = "date", int startprice = 0, int endprice = 0, List<int> selectedGroups = null, int take = 0)
        {
            if (take == 0)
            {
                take = 8;
            }

            IQueryable<Product> results = _db.Products;
            if (!string.IsNullOrEmpty(filter))
            {
                results = results.Where(c => c.ProductName.Contains(filter)||c.Tags.Contains(filter));
            }
            switch (gettype)
            {
                case "all":
                    break;
                case "buy":
                    {
                        results = results.Where(p => p.ProductPrice != 0);
                        break;
                    }
                case "free":
                    {
                        results = results.Where(p => p.ProductPrice == 0);
                        break;
                    }
            }
            switch (orderbytype)
            {
                case "date":
                    {
                        results = results.OrderByDescending(c => c.Createdate);
                        break;
                    }
                case "updatedate":
                    {
                        results = results.OrderByDescending(c => c.Updatedate);
                        break;
                    }
            }

            if (startprice > 0)
            {
                results = results.Where(p => p.ProductPrice > startprice);
            }
            if (endprice > 0)
            {
                results = results.Where(p => p.ProductPrice < endprice);
            }
            if (selectedGroups != null&&selectedGroups.Any())
            {
                foreach(int groupid in selectedGroups)
                {
                    results = results.Where(p => p.GroupID == groupid || p.SubGroup == groupid);
                }

            }

            int skip = (pageid - 1) * take;

            int pagecount = results.Select(p => new ShowProductListViewModel()
            {
                ProductID = p.ProductID,
                ProductImageName = p.ProductImageName,
                Price = p.ProductPrice,
                ProductTitle = p.ProductName

            }).Count() / take;

            var query= results.Select(p => new ShowProductListViewModel()
            {
                ProductID = p.ProductID,
                ProductImageName = p.ProductImageName,
                Price = p.ProductPrice,
                ProductTitle = p.ProductName

            }).Skip(skip).Take(take).ToList();
            return Tuple.Create(query, pagecount);


        }

        public Product getproductbyid(int productid)
        {
            return _db.Products.Find(productid);
        }

        public Tuple<List<ProductComment>, int> getproductcomment(int productid, int pageid = 1)
        {
            int take = 5;
            int skip = (pageid - 1) * take;
            int pagecount = _db.ProductComments.Where(p => !p.isDelete && p.ProductID == productid).Count() / take;

            if ((pagecount % 2) != 0)
            {
                pagecount += 1;
            }


            return Tuple.Create(_db.ProductComments.Include(p=>p.User).Where(p => !p.isDelete && p.ProductID == productid)
                .Skip(skip).Take(take).OrderByDescending(p=>p.CreateDate).ToList(), pagecount);
        }

        public List<ShowProductForAdminViewModel> getproductforadmin()
        {
            return _db.Products.Select(p => new ShowProductForAdminViewModel()
            {
                ProductID=p.ProductID,
                ImageName=p.ProductImageName,
                Title=p.ProductName,
                Price=p.ProductPrice
            }).ToList();
        }

        public List<Product> getproductingroups(int groupid)
        {

            return _db.Products.Where(p => p.GroupID == groupid).ToList();

        }

        public Product Getproductsforshow(int productid)
        {
            return _db.Products.Include(p => p.ProductStatus).Include(p => p.ProductLevel).Include(p => p.User)
                .Include(p=>p.Product_Group)
                .FirstOrDefault(p => p.ProductID == productid);
             
                
        }

        public List<SelectListItem> Getstatus()
        {
            return _db.ProductStatuses.Select(p => new SelectListItem()
            {
                Value = p.StatusID.ToString(),
                Text = p.StatusTilte
            }).ToList();
        }

        public string getsubgroup(int? groupid)
        {
            var pro = _db.product_Groups.Where(p => p.GroupID == groupid).SingleOrDefault();

            return pro.GroupTitle;
        }

        public List<SelectListItem> Getsubgroupsformanageproduct(int groupid)
        {
            return _db.product_Groups.Where(p => p.ParentID == groupid).Select(p => new SelectListItem()
            {
                Text = p.GroupTitle,
                Value = p.GroupID.ToString()
            }).ToList();
        }

        public List<SelectListItem> Getteachers()
        {
            return _db.UserRoles.Where(r => r.RoleID == 4).Include(r => r.User)
                .Select(p => new SelectListItem()
                {
                    Value = p.UserID.ToString(),
                    Text = p.User.Username
                }).ToList();
        }

        public void UpdateProduct(Product product, IFormFile proimg)
        {
            product.Updatedate = DateTime.Now;
            if (proimg != null && proimg.IsImage())
            {
                if (product.ProductImageName != "no-photo.jpg")
                {
                    string deletpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/products/image", product.ProductImageName);
                    if (File.Exists(deletpath))
                    {
                        File.Delete(deletpath);
                    }
                    string deletthumbpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/products/thumb", product.ProductImageName);
                    if (File.Exists(deletthumbpath))
                    {
                        File.Delete(deletthumbpath);
                    }
                }


                product.ProductImageName = NameGenerator.Generateuniqcode() + Path.GetExtension(proimg.FileName);
                string imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Products/image", product.ProductImageName);


                using (var stream = new FileStream(imagepath, FileMode.Create))
                {
                    proimg.CopyTo(stream);
                }
                ImageConvertor imgresizer = new ImageConvertor();
                string thumbpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Products/thumb", product.ProductImageName);
                imgresizer.Image_resize(imagepath, thumbpath, 150);


            }
            _db.Products.Update(product);
            _db.SaveChanges();

        }
    }
}
