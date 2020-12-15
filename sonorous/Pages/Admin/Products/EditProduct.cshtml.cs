using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using sonorous.Core.Services.Interfaces;
using sonorous.Datalayer.Entites.Product;

namespace sonorous.Pages.Admin.Products
{
    public class EditProductModel : PageModel
    {
        private IProductServices _productServices;

        public EditProductModel(IProductServices productServices)
        {
            _productServices = productServices;
        }


        [BindProperty]
        public Product Product { get; set; }
        public void OnGet(int id)
        {
            Product = _productServices.getproductbyid(id);
            var groups = _productServices.Getgroupsformanageproduct();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text",Product.GroupID);
            var subgroup = _productServices.Getsubgroupsformanageproduct(int.Parse(groups.First().Value));
            ViewData["subGroups"] = new SelectList(subgroup, "Value", "Text", Product.SubGroup??0);
            var teacher = _productServices.Getteachers();
            ViewData["Teacher"] = new SelectList(teacher, "Value", "Text",Product.TeacherID);
            var status = _productServices.Getstatus();
            ViewData["Status"] = new SelectList(status, "Value", "Text",Product.StatusID);
            var levels = _productServices.Getlevels();
            ViewData["Levels"] = new SelectList(levels, "Value", "Text",Product.LevelID);
        }

        public IActionResult OnPost(IFormFile productimg)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _productServices.UpdateProduct(Product, productimg);

            return RedirectToPage("Index");
        }

    }
}