using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sonorous.Datalayer.Entites.Wallett
{
    public class Wallett
    {

        public Wallett()
        {

        }

        [Key]
        public int WallettID { get; set; }


        [Display(Name ="نوع تراکنش")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public int TypeID { get; set; }

        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int UserID { get; set; }

        [Display(Name = "مبلغ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int Amount { get; set; }

        [Display(Name = "شرح")]
        [MaxLength(200, ErrorMessage = "{0} نمیواند بشتر از {1} باشد")]
        public string Description { get; set; }


        [Display(Name = "تایید نهایی")]
        public bool ispay { get; set; }


        [Display(Name = "تاریخ و ساعت")]
        public DateTime CreateDate { get; set; }


        #region Relations

        public virtual User.User User { get; set; }

        [ForeignKey("TypeID")]
        public virtual WallettType WallettType { get; set; }


        #endregion

    }
}
