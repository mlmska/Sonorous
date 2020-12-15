using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sonorous.Core.DTOs;
using sonorous.Core.Services.Interfaces;

namespace sonorous.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class OrdersController : Controller
    {
        private IOrderServices _orderServices;

        public OrdersController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        public IActionResult Index()
        {
            return View(_orderServices.getallorders(User.Identity.Name));
        }

        public IActionResult ShowOrder(int id,bool finaly=false,string type="")
        {
            var order = _orderServices.getorderforuserpanel(User.Identity.Name, id);

            if (order == null)
            {
                return NotFound();
            }
            ViewBag.discounttype = type;
            ViewBag.finaly = finaly;
            return View(order);

        }


        public IActionResult FinalyOrder(int id)
        {
            if (_orderServices.finalorder(User.Identity.Name,id))
            {
                return Redirect("/UserPanel/Orders/ShowOrder/" + id + "?finaly=true");
            }
            return BadRequest();

        }

        public IActionResult UseDiscount(int orderid,string code)
        {


            DiscountuseType type = _orderServices.useDiscount(orderid, code);
            return Redirect("/UserPanel/Orders/ShowOrder/" + orderid + "?type=" + type.ToString());

        }

    }
}
