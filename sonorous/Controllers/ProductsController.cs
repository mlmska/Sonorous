using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sonorous.Core.Services.Interfaces;
using sonorous.Datalayer.Entites.Product;

namespace sonorous.Controllers
{
    public class ProductsController : Controller
    {
        private IProductServices _productServices;
        private IOrderServices _orderServices;
        private IUserServices _userServices;


        public ProductsController(IProductServices productServices,IOrderServices orderServices,IUserServices userServices)
        {
            _productServices = productServices;
            _orderServices = orderServices;
            _userServices = userServices;
        }


        public IActionResult Index(int pageid = 1, string filter = "", string gettype = "all",
            string orderbytype = "date", int startprice = 0, int endprice = 0, List<int> selectedGroups = null, int take = 0)
        {
            ViewBag.selectedgroups = selectedGroups;
            ViewBag.groups = _productServices.Getallgroup();
            ViewBag.pageid = pageid;
            return View(_productServices.GetProduct(pageid,filter,gettype,orderbytype,startprice,endprice,selectedGroups,3));
        }

        [Route("ShowProduct/{id}")]
        public IActionResult ShowProduct(int id)
        {
            var product = _productServices.Getproductsforshow(id);

            ViewBag.subgroup = _productServices.getsubgroup(product.SubGroup);

            ViewBag.productingroups = _productServices.getproductingroups(product.GroupID);
            

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }


        [Authorize]
        public IActionResult BuyProducts(int id)
        {
            int orderid = _orderServices.addorder(User.Identity.Name, id);
            return Redirect("/UserPanel/Orders/ShowOrder/" + orderid);
        }



        [HttpPost]
        public IActionResult CreateComment(ProductComment comment)
        {
          
            comment.isDelete = false;
            comment.CreateDate = DateTime.Now;
            comment.UserID = _userServices.getuseridbyusername(User.Identity.Name);
            _productServices.AddComment(comment);


            return View("ShowComment",_productServices.getproductcomment(comment.ProductID));
        }

        public IActionResult ShowComment(int id,int pageid=1)
        {
            return View(_productServices.getproductcomment(id, pageid));
        }


    }
}
