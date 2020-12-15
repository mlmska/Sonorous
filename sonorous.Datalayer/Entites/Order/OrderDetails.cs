using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sonorous.Datalayer.Entites.Order
{
    public class OrderDetails
    {

        [Key]
        public int DetailID { get; set; }


        [Required]
        public int OrderID { get; set; }

        [Required]
        public int ProductID { get; set; }


        [Required]
        public int Count { get; set; }


        [Required]
        public int Price { get; set; }


        #region Relations

        public Order Order { get; set; }

        
        public Product.Product Product { get; set; }
        


        #endregion


    }
}
