using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using sonorous.Datalayer.Entites.Product;
using sonorous.Datalayer.Entites.Wallett;
namespace sonorous.Datalayer.Entites.User
{
    public class User
    {
        public User()
        {

        }
        [Key]
        public int UserID { get; set; }
        [Display(Name ="مام کاربری")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage ="{0} نمیواند بشتر از {1} باشد")]
        public string Username { get; set; }

        [Display(Name ="ایمیل")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage ="{0} نمیواند بشتر از {1} باشد")]
        [EmailAddress(ErrorMessage ="ایمیل وارد شده معتبر نیست")]
        public string Email { get; set; }


        [Display(Name ="کلمه عبور")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage ="{0} نمیواند بشتر از {1} باشد")]
        public string Password { get; set; }

        [Display(Name ="کد فعالسازی")]
        [MaxLength(50, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        public string Activecode { get; set; }

        [Display(Name ="وضعیت")]
       
        public bool isActive { get; set; }

        [Display(Name ="عکس کاربر")]
        [MaxLength(200, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        public string UserAvatar { get; set; }

        [Display(Name ="تاریخ ثبت نام")]
       
        public DateTime RegisterDate { get; set; }


        public bool isDelete { get; set; }


        #region Relations



        public virtual List<UserRole> UserRoles { get; set; }

        public virtual List<Wallett.Wallett> Walletts { get; set; }

        public List<Product.Product> Products { get; set; }

        public virtual List<Order.Order> Orders { get; set; }

        public List<UserProducts> UserProducts { get; set; }

        public List<UserDiscountCode> UserDiscountCodes { get; set; }

        public List<ProductComment> ProductComments { get; set; }




        #endregion


    }
}
