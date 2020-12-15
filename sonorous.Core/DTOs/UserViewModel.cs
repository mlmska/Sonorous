using Microsoft.AspNetCore.Http;
using sonorous.Datalayer.Entites.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sonorous.Core.DTOs
{
    public class UserforAdminViewModel
    {
        public List<User> Users { get; set; }

        public int CurrentPage { get; set; }

        public int PageCount { get; set; }


    }
    public class CreateUserViewModel
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

        public IFormFile UserAvatar { get; set; }

       
       

    }

    public class EditUserViewModel
    {
        public int UserID { get; set; }


       
        public string Username { get; set; }

        
        public string Email { get; set; }

        [Display(Name ="وضیعت")]
        public bool isactive { get; set; }

        public IFormFile UserAvatar { get; set; }

        public List<int> UserRoles { get; set; }

        public string AvatarName { get; set; }


    }

}
