using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using sonorous.Core.Convertors;
using sonorous.Core.DTOs;
using sonorous.Core.Generators;
using sonorous.Core.Security;
using sonorous.Core.Services.Interfaces;
using sonorous.Datalayer.Entites.User;

namespace sonorous.Controllers
{
    public class HomeController : Controller
    {

        private IUserServices _userServices;

        private IProductServices _productServices;

        public HomeController(IUserServices userServices,IProductServices productServices)
        {
            _userServices = userServices;
            _productServices = productServices;
        }


        public IActionResult Index()
        {
            return View(_productServices.GetProduct().Item1);
        }


        #region OnlinePayment

        [Route("OnlinePayment/{id}")]
        public IActionResult onlinepayment(int id)
        {
            if (HttpContext.Request.Query["Status"]!=""&&HttpContext.Request.Query["Status"].ToString().ToLower()=="ok"
                && HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"];

                var wallett = _userServices.GetWallettbywallettid(id);

                var payment = new ZarinpalSandbox.Payment(wallett.Amount);

                var res = payment.Verification(authority).Result;
                if (res.Status == 100)
                {
                    ViewBag.code = res.RefId;
                    ViewBag.issuccess = true;
                    wallett.ispay = true;
                    _userServices.Updatewallet(wallett);
                }
            }
            return View();

        }

        #endregion


        public IActionResult GetSubGroups(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem(){Text="انتخاب کنید",Value=""}
            };

            list.AddRange(_productServices.Getsubgroupsformanageproduct(id));
            return Json(new SelectList(list, "Value", "Text"));
        }

        [HttpPost]
        [Route("file-upload")]
        public IActionResult UploadImage(IFormFile upload, string CKEditorFuncNum, string CKEditor, string langCode)
        {
            if (upload.Length <= 0) return null;

            var fileName = Guid.NewGuid() + Path.GetExtension(upload.FileName).ToLower();



            var path = Path.Combine(
                Directory.GetCurrentDirectory(), "wwwroot/MyImages",
                fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                upload.CopyTo(stream);

            }



            var url = $"{"/MyImages/"}{fileName}";


            return Json(new { uploaded = true, url });
        }
    }
}
