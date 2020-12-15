using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sonorous.Datalayer.Entites.Product
{
    public class ProductStatus
    {
        public ProductStatus()
        {

        }

        [Key]
        public int StatusID { get; set; }


        [Required]
        [MaxLength(150)]
        public string StatusTilte { get; set; }

        #region Relations

        public List<Product> Products { get; set; }


        #endregion


    }
}
