using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sonorous.Core.DTOs
{
    public class InformationViewModel
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public DateTime RegisterDate { get; set; }

        public int Wallet { get; set; }

    }
    public class SidebarUserPanelViewModel
    {
        public string Username { get; set; }

        public DateTime RegisterDate { get; set; }
        public string Imagename { get; set; }

    }
    public class EditProfileViewModel
    {
        [Display(Name = "مام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        public string Username { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نیست")]
        public string Email { get; set; }

        public IFormFile Useravatar { get; set; }
        public string AvatarName { get; set; }


    }

    public class ChangePasswordViewModel
    {

        [Display(Name = "کلمه عبوری فعلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        public string OldPassword { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        [Compare("Password", ErrorMessage = "کلمه عبوری مغایرت دارند")]
        public string RePassword { get; set; }
    }
}
