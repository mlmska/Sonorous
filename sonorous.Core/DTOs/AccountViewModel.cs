using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sonorous.Core.DTOs
{
    public class RegisterviewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        public string Username { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نیست")]
        public string Email { get; set; }


        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        public string RePassword { get; set; }
    }

    public class LoginViewModel
    {
        [Display(Name = "نام کاربری یا ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string emailorusername { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        public string Password { get; set; }

        [Display(Name = "مرا به خاطر بسپار")]
        public bool Remmeberme { get; set; }


    }

    public class ForgotPasswordViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نیست")]
        public string Email { get; set; }
    }

    public class ResetPasswordViewModel
    {
        public string ActiveCode { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        [Compare("Password",ErrorMessage ="کلمه عبوری مغایرت دارند")]
        public string RePassword { get; set; }
    }

}
