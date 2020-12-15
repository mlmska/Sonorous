using sonorous.Datalayer.Entites.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sonorous.Datalayer.Entites.User
{
    public class UserDiscountCode
    {
        [Key]
        public int US_ID { get; set; }

        public int UserID { get; set; }

        public int DiscountID { get; set; }



        #region Relations

        public User User { get; set; }

        public Discount Discount { get; set; }

        #endregion

    }
}
