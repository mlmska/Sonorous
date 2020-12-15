using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sonorous.Datalayer.Entites.Order
{
     public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        public int UserID { get; set; }
        [Required]
        public int OrderSum { get; set; }

        public bool isFinaly { get; set; }

        [Required]
        public DateTime Createdate { get; set; }

        #region Relations

        public virtual User.User User { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }





        #endregion


    }
}
