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
    public class WallettController : Controller
    {

        private IUserServices _userservices;

        public WallettController(IUserServices userServices)
        {
            _userservices = userServices;
        }

        [Route("UserPanel/Wallett")]
        public IActionResult Index()
        {
            ViewBag.ListWallet = _userservices.GetWalletuser(User.Identity.Name);
            return View();
        }

        [Route("UserPanel/Wallett")]
        [HttpPost]
        public IActionResult Index(ChargeWallettViewModel charge)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ListWallet = _userservices.GetWalletuser(User.Identity.Name);
                return View(charge);
            }

           int walletid =_userservices.ChargeWallett(User.Identity.Name, charge.Amount, "شارژ حساب");

            #region OnlinePayment

            var payment = new ZarinpalSandbox.Payment(charge.Amount);

            var res = payment.PaymentRequest("شارژ کیف پول", "https://localhost:44396/OnlinePayment/" + walletid);


            if (res.Result.Status == 100)
            {
                return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + res.Result.Authority);

            }

            #endregion

            return null;
        }
    }
}
