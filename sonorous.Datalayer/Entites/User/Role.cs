using sonorous.Datalayer.Entites.Permissions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sonorous.Datalayer.Entites.User
{
    public class Role
    {

        public Role()
        {

        }

        [Key]
        public int RoleID { get; set; }

        [Display(Name ="عنوان نقش")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage ="{0} نمیواند بشتر از {1} باشد")]
        public string Roletitle { get; set; }


        public bool isDelete { get; set; }



        #region Relations

        public virtual List<UserRole> UserRoles { get; set; }

        public List<RolePermission> RolePermissions { get; set; }

        #endregion

    }
}
