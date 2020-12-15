using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sonorous.Datalayer.Entites.Permissions
{
    public class Permission
    {

        public Permission()
        {

        }

        [Key]
        public int PermissionID { get; set; }

        [Display(Name ="عنوان دسترسی")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage ="{0} نمیواند بشتر از {1} باشد")]
        public string PermissionTitle { get; set; }

        public int? ParentID { get; set; }


        #region Permission

        [ForeignKey("ParentID")]
        public List<Permission> Permissions { get; set; }


        public List<RolePermission> RolePermissions { get; set; }


        #endregion

    }
}
