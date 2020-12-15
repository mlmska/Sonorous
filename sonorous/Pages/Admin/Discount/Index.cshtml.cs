using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sonorous.Core.Services.Interfaces;

namespace sonorous.Pages.Admin.Discount
{
    public class IndexModel : PageModel
    {
        private IOrderServices _orderServices;

        public IndexModel(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }


        public List<Datalayer.Entites.Order.Discount> Discounts { get; set; }
        public void OnGet()
        {
            Discounts = _orderServices.getalldiscounts();
        }
    }
}