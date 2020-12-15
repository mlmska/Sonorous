using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using sonorous.Core.Convertors;
using sonorous.Core.Convertors.SendEmail;
using sonorous.Core.DTOs;
using sonorous.Core.Generators;
using sonorous.Core.Security;
using sonorous.Core.Senders;
using sonorous.Core.Services.Interfaces;
using sonorous.Datalayer.Entites.User;

namespace sonorous.Controllers
{
    public class AccountController : Controller
    {
      
        private IUserServices _userServices;
        private IViewRenderService _viewrender;

        public AccountController(IUserServices userServices,IViewRenderService viewRender)
        {
            _userServices = userServices;
            _viewrender = viewRender;
        }
        #region Register
        [Route("Register")]
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterviewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            if (_userServices.isExistusername(register.Username))
            {
                ModelState.AddModelError("Username", "نام کاربری معتبر نمی باشد");
                return View(register);

            }
            if (_userServices.isExistemail(FixedText.fixedemail(register.Email)))
            {
                ModelState.AddModelError("Email", "ایمیل معتر نمی باشد");
                return View(register);
            }

            User user = new User()
            {
                Activecode = NameGenerator.Generateuniqcode(),
                Email = FixedText.fixedemail(register.Email),
                isActive = false,
                Password = PasswordHelper.EncodePasswordMd5(register.Password),
                Username = register.Username,
                RegisterDate = DateTime.Now,
                UserAvatar = "Defult.jpg"
            };
            _userServices.adduser(user);
            #region sende Activation email

            string body = _viewrender.RenderToStringAsync("_ActivateEmail", user);
            SendEmail.Send(user.Email, "فعال سازی", body);


            #endregion

            return View("SuccedRegister", user);
        }
        #endregion

        #region Login

        [Route("Login")]
        public IActionResult Login(bool EditProfile=false)
        {
            ViewBag.EditProfile = EditProfile;
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginViewModel login,string ReturnUrl="/")
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            var user = _userServices.loginuser(login);

            if (user != null)
            {
                if (user.isActive)
                {
                    var claims = new List<Claim>() {

                      new Claim(ClaimTypes.NameIdentifier,user.UserID.ToString()),
                      new Claim(ClaimTypes.Name,user.Username),
                      new Claim(ClaimTypes.Email,user.Email)
                    
                    };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    var properties = new AuthenticationProperties
                    {
                        IsPersistent=login.Remmeberme
                    };
                    HttpContext.SignInAsync(principal, properties);

                    ViewBag.issuccess = true;
                    if (ReturnUrl != "/")
                    {
                        return Redirect(ReturnUrl); 
                    }
                    return View();
                }
                else
                {
                    ModelState.AddModelError("Email", "حساب کاربری فعال نمی باشد");
                }

            }
            else
            {
                ModelState.AddModelError("Email", "ماربری با این مشخصات بافت نشد");
                return View(login); 
            }
            return View(login);
        }


        #endregion

        #region Active account
        public IActionResult ActiveAccount(string id)
        {
            ViewBag.isactive = _userServices.activeaccount(id);

            return View();
        }

        #endregion

        #region Signout
        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("/Login");
        }


        #endregion

        #region ForgotPassword
        [Route("ForgotPassword")]
        public IActionResult ForgotPassword()
        {
            return View();
        }


        [HttpPost]
        [Route("ForgotPassword")]
        public IActionResult ForgotPassword(ForgotPasswordViewModel forgot)
        {
            if (!ModelState.IsValid)
            {
                return View(forgot);
            }
            string fixedemail = FixedText.fixedemail(forgot.Email);
            User user = _userServices.getuserbyEmail(fixedemail);

            if (user == null)
            {
                ModelState.AddModelError("Email", "حسابی با این مشخصات یافت نسد");
                return View(forgot);
            }
            string bodyemail = _viewrender.RenderToStringAsync("_ForgotPassword",user);
            SendEmail.Send(user.Email, "بازیابی کلمه عبوری",bodyemail);
            ViewBag.issuccess = true;

            return View();
        }

        #endregion

        #region ResetPassword

        public IActionResult ResetPassword(string id)
        {
            return View(new ResetPasswordViewModel()
            { 
                ActiveCode=id               
            });
        }

        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel reset)
        {
            if (!ModelState.IsValid)
            {
                return View(reset);
            }
            User user = _userServices.getuserbyeactivecode(reset.ActiveCode);

            if (user == null)
            {
                return NotFound();
            }
            string hashnewpassword = PasswordHelper.EncodePasswordMd5(reset.Password);
            user.Password = hashnewpassword;
            _userServices.updateuser(user);


            return Redirect("/Login");
        }

        #endregion


    }
}

