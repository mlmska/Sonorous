using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sonorous.Core.Services.Interfaces;
using sonorous.Core.DTOs;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace sonorous.Areas.UserPanel.Controllers
{

    [Area("UserPanel")]
    [Authorize]
    public class HomeController : Controller
    {

        private IUserServices _userServices;

        public HomeController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public IActionResult Index()
        {
            return View(_userServices.GetUserinformation(User.Identity.Name));
        }
        #region EditPassword
        [Route("UserPanel/EditProfile")]
        public IActionResult EditProfile()
        {
            return View(_userServices.GetdataForEditProfileuser(User.Identity.Name));
        }
        [Route("UserPanel/EditProfile")]
        [HttpPost]
        public IActionResult EditProfile(EditProfileViewModel edit)
        {
            if (!ModelState.IsValid)
            {
                return View(edit);
               
            }
            _userServices.EditProfile(User.Identity.Name, edit);

            //logout user

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("/Login?EditProfile=true");

        }
        #endregion

        #region Changepassword
        [Route("UserPanel/ChangePassword")]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [Route("UserPanel/ChangePassword")]
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel change)
        {
            string currentusername = User.Identity.Name;
            if (!ModelState.IsValid)
            {
                return View(change);
            }

            if (!_userServices.CompareOldpassword(change.OldPassword, currentusername))
            {
                ModelState.AddModelError("OldPassword", "کلمه ی عبوری معتبر نمی باشد");
                return View(change);
            }

            _userServices.ChangeuserPassword(currentusername, change.Password);
            ViewBag.issuccess = true;


            return View();
        }

        #endregion

        
    }
}
