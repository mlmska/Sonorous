using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sonorous.Datalayer.Entites.Product
{
    public class UserProducts
    {
        [Key]
        public int US_ID { get; set; }

        public int UserID { get; set; }

        public int ProductID { get; set; }


        #region Relations

        public Product Product { get; set; }

        public User.User User { get; set; }




        #endregion


    }
}
