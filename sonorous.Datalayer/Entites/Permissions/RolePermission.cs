using sonorous.Datalayer.Entites.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sonorous.Datalayer.Entites.Permissions
{
    public class RolePermission
    {
        public RolePermission()
        {

        }

        [Key]
        public int RP_ID { get; set; }

        public int RoleID { get; set; }

        public int PermissionID { get; set; }



        #region Relations

        public Role Role { get; set; }

        public Permission Permission { get; set; }




        #endregion



    }
}
