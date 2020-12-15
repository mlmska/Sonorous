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
    public class CreateProductModel : PageModel
    {
        private IProductServices _productServices;

        public CreateProductModel(IProductServices productServices)
        {
            _productServices = productServices;
        }


        [BindProperty]
        public Product Product { get; set; }
        public void OnGet()
        {
            var groups= _productServices.Getgroupsformanageproduct();
            ViewData["Groups"] = new SelectList(groups, "Value","Text");
            var subgroup = _productServices.Getsubgroupsformanageproduct(int.Parse(groups.First().Value));
            ViewData["subGroups"] = new SelectList(subgroup, "Value", "Text");
            var teacher = _productServices.Getteachers();
            ViewData["Teacher"] = new SelectList(teacher, "Value", "Text");
            var status = _productServices.Getstatus();
            ViewData["Status"] = new SelectList(status, "Value", "Text");
            var levels = _productServices.Getlevels();
            ViewData["Levels"] = new SelectList(levels, "Value", "Text");

        }

        public IActionResult OnPost(IFormFile productimg)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _productServices.addProduct(Product, productimg);

            return RedirectToPage("Index");
        }
    }
}