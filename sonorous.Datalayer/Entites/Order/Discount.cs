using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sonorous.Datalayer.Entites.Order
{
    public class Discount
    {
        [Key]
        public int DiscountID { get; set; }

        [Display(Name ="کد")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string Discountcode { get; set; }


        [Display(Name = "درصد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int DiscountPercent { get; set; }

        public int? UsableCount { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }



        #region Relations

        public List<User.UserDiscountCode> UserDiscountCodes { get; set; }



        #endregion



    }
}
