using sonorous.Core.DTOs;
using sonorous.Datalayer.Entites.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace sonorous.Core.Services.Interfaces
{
    public interface IOrderServices
    {
        int addorder(string username, int productid);

        void UpdatePriceOrder(int orderid);

        Order getorderforuserpanel(string username, int orderid);

        Order getorderbyID(int orderid);

        bool finalorder(string username,int orderid);

        List<Order> getallorders(string username);

        void Updateorder(Order order);


        #region Discount

        DiscountuseType useDiscount(int orderid, string code);

        void Adddiscont(Discount discount);

        List<Discount> getalldiscounts();

        Discount GetDiscountbyid(int id);

        void updatediscount(Discount discount);

        bool isExistcode(string code);

        #endregion

    }
}
