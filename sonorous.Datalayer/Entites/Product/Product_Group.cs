using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sonorous.Datalayer.Entites.Product
{
    public class Product_Group
    {

        public Product_Group()
        {

        }

        [Key]
        public int GroupID { get; set; }

        [Display(Name ="عنوان گروه")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage ="{0} نمیواند بشتر از {1} باشد")]
        public string GroupTitle { get; set; }


        [Display(Name ="حذف شده؟")]
        public bool isDelete { get; set; }


        [Display(Name = "گروه اصلی")]
        public int? ParentID { get; set; }

        #region Relations

       


        [ForeignKey("ParentID")]
        public List<Product_Group> product_Groups { get; set; }


        
        public List<Product> Products { get; set; }
        
        
        [InverseProperty("Group")]
        public List<Product> SubGroup { get; set; }


        #endregion

    }
}
