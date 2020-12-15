using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using sonorous.Datalayer.Entites.User;

namespace sonorous.Datalayer.Entites.User
{
    public class UserRole
    {
        public UserRole()
        {

        }

        [Key]
        public int US_ID { get; set; }

        public int UserID { get; set; }

        public int RoleID { get; set; }

        #region Relations
        public virtual User User { get; set; }

        public virtual Role Role { get; set; }


        #endregion

    }
}
