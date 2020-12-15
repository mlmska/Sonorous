using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sonorous.Datalayer.Entites.Product
{
    public class ProductLevel
    {

        public ProductLevel()
        {

        }
        [Key]
        public int LevelID { get; set; }

        [MaxLength(150)]
        [Required]
        public string LevelTitle { get; set; }



        #region Relations

        public List<Product> Products { get; set; }


        #endregion

    }
}
