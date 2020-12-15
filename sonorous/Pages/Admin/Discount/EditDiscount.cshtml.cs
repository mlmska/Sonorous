using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sonorous.Core.Services.Interfaces;

namespace sonorous.Pages.Admin.Discount
{
    public class EditDiscountModel : PageModel
    {

        private IOrderServices _orderServices;
        public EditDiscountModel(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }


        [BindProperty]
        public Datalayer.Entites.Order.Discount Discount { get; set; }
        public void OnGet(int id)
        {
            Discount = _orderServices.GetDiscountbyid(id);
        }

        public IActionResult OnPost(string stDate = "", string endDate = "")
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (stDate != "")
            {
                string[] std = stDate.Split('/');
                Discount.StartDate = new DateTime(int.Parse(std[0]),
                    int.Parse(std[1]),
                    int.Parse(std[2]),
                    new PersianCalendar()
                    );
            }

            if (endDate != "")
            {
                string[] end = endDate.Split('/');
                Discount.EndDate = new DateTime(int.Parse(end[0]),
                    int.Parse(end[1]),
                    int.Parse(end[2]),
                    new PersianCalendar()
                    );
            }

            _orderServices.updatediscount(Discount);

            return RedirectToPage("Index");

        }
    }
}