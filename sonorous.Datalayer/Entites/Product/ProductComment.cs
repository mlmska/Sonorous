using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sonorous.Datalayer.Entites.Product
{
    public class ProductComment
    {

        public ProductComment()
        {

        }

        [Key]
        public int CommentID { get; set; }

        public int ProductID { get; set; }

        public int UserID { get; set; }


        [Required]
        [MaxLength(700)]
        public string Comment { get; set; }

        public DateTime CreateDate { get; set; }

        public bool isDelete { get; set; }

        public bool isAdminRead { get; set; }


        #region Relations

        public Product Product { get; set; }

        public User.User User { get; set; }




        #endregion


    }
}
