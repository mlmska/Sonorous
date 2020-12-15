using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using sonorous.Core.DTOs;
using sonorous.Datalayer.Entites.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace sonorous.Core.Services.Interfaces
{
    public interface IProductServices
    {
        #region Group

        List<Product_Group> Getallgroup();

        List<SelectListItem> Getgroupsformanageproduct();
        List<SelectListItem> Getsubgroupsformanageproduct(int groupid);

        List<SelectListItem> Getteachers();
        List<SelectListItem> Getstatus();
        List<SelectListItem> Getlevels();

        List<Product> getproductingroups(int groupid);
        string getsubgroup(int? groupid);

        #endregion

        #region Product

        List<ShowProductForAdminViewModel> getproductforadmin();

        int addProduct(Product product, IFormFile proimg);

        Product getproductbyid(int productid);

        void UpdateProduct(Product product, IFormFile proimg);

        Tuple<List<ShowProductListViewModel>,int> GetProduct(int pageid = 1, string filter = "", string gettype = "all",
            string orderbytype = "date", int startprice = 0, int endprice = 0, List<int> selectedGroups = null,int take=0);

        Product Getproductsforshow(int productid);


        #endregion

        #region Comment

        void AddComment(ProductComment comment);

        Tuple<List<ProductComment>,int> getproductcomment(int productid,int pageid=1);

        #endregion

    }
}
