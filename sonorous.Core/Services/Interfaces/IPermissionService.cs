using sonorous.Datalayer.Entites.Permissions;
using sonorous.Datalayer.Entites.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace sonorous.Core.Services.Interfaces
{
    public interface IPermissionService
    {
        #region Role

        List<Role> getroles();

        int AddRole(Role role);

        Role getrolbyid(int roleid);
        void Updaterole(Role role);

        void DeleteRole(Role role);

        void AddRolesToUser(List<int> roleid,int userid);

        void Editrolesuser(int userid, List<int> roleid);

        #endregion
        #region Permission

        List<Permission> getallpermission();

        void addpermissiontorole(int roleid, List<int> permissions);

        List<int> permissionsrole(int roleid);

        void Updatepermissionrole(int roleid, List<int> listpermissions);

        bool CheckPermission(int permissionid, string username);

        #endregion
    }
}
