using Microsoft.AspNetCore.Mvc;
using sonorous.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sonorous.ViewComponents
{
    public class ProductsGroupComponent:ViewComponent
    {
        private IProductServices _productServices;

        public ProductsGroupComponent(IProductServices productServices)
        {
            _productServices = productServices;
        }



        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("ProductGroup",_productServices.Getallgroup()));
        } 
    }
}
