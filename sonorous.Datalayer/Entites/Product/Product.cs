
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sonorous.Datalayer.Entites.Product
{
    public class Product
    {

        public Product()
        {

        }
        [Key]
        public int ProductID { get; set; }

        [Required]
       
        public int GroupID { get; set; }

        [Required]
       
        public int LevelID { get; set; }

        [Required]
        public int StatusID { get; set; }


        [Required]
        public int TeacherID { get; set; }

        [Display(Name ="نام محصول")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(450,ErrorMessage ="{0} نمیواند بشتر از {1} باشد")]
        public string ProductName { get; set; }

        [Display(Name = "شرح محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string ProductDescription { get; set; }


        [Display(Name = "قیمت محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int ProductPrice { get; set; }

        [MaxLength(600)]
        public string Tags { get; set; }

        [MaxLength(50)]
        public string ProductImageName { get; set; }

        [Required]
        public DateTime Createdate { get; set; }


        public DateTime? Updatedate { get; set; }


        #region Relations

        [ForeignKey("TeacherID")]
        public  User.User User { get; set; }

        [ForeignKey("GroupID")]
        public Product_Group Product_Group { get; set; }


        [ForeignKey("Group")]
        public int? SubGroup { get; set; }
        public Product_Group Group { get; set; }


        [ForeignKey("StatusID")]
        public ProductStatus ProductStatus { get; set; }

        [ForeignKey("LevelID")]
        public ProductLevel ProductLevel { get; set; }


        public List<Order.OrderDetails> OrderDetails { get; set; }


        public List<UserProducts> UserProducts { get; set; }

        public List<ProductComment> ProductComments { get; set; }



        #endregion
    }
}
