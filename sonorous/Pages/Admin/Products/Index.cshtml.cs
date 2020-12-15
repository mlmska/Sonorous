using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sonorous.Core.DTOs;
using sonorous.Core.Services.Interfaces;

namespace sonorous.Pages.Admin.Products
{
    public class IndexModel : PageModel
    {
        private IProductServices _productServices;

        public IndexModel(IProductServices productServices)
        {
            _productServices = productServices;
        }

        public List<ShowProductForAdminViewModel> ListProduct { get; set; }
        public void OnGet()
        {
            ListProduct = _productServices.getproductforadmin();
        }
    }
}