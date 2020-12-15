using sonorous.Core.Services.Interfaces;
using sonorous.Datalayer.Context;
using sonorous.Datalayer.Entites.Permissions;
using sonorous.Datalayer.Entites.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sonorous.Core.Services
{
    public class PermissonService : IPermissionService
    {
        private SonorousContext _db;

        public PermissonService(SonorousContext db)
        {
            _db = db;
        }

        public void addpermissiontorole(int roleid, List<int> permissions)
        {
           foreach(var p in permissions)
            {
                _db.RolePermissions.Add(new RolePermission()
                {
                    PermissionID = p,
                    RoleID = roleid
                });
            }
            _db.SaveChanges();

        }

        public int AddRole(Role role)
        {
            _db.Roles.Add(role);
            _db.SaveChanges();
            return role.RoleID;
        }

        public void AddRolesToUser(List<int> roleid, int userid)
        {
            foreach(int roleID in roleid)
            {
                _db.UserRoles.Add(new UserRole()
                {
                    RoleID = roleID,
                    UserID = userid,
                });
            }
            _db.SaveChanges();


        }

        public bool CheckPermission(int permissionid, string username)
        {
            int userid = _db.Users.Single(p => p.Username == username).UserID;


            List<int> userroles = _db.UserRoles.Where(r => r.UserID == userid).Select(p => p.RoleID).ToList();

            if (!userroles.Any())
            {
                return false;
            }
            List<int> rolespermission = _db.RolePermissions
                .Where(p => p.PermissionID == permissionid)
                .Select(p=>p.RoleID)
                .ToList();

            return rolespermission.Any(p => userroles.Contains(p));
        }

        public void DeleteRole(Role role)
        {
            role.isDelete = true;
            Updaterole(role);
        }

        public void Editrolesuser(int userid, List<int> roleids)
        {
             _db.UserRoles.Where(r => r.UserID == userid).ToList().ForEach(r => _db.UserRoles.Remove(r));
             AddRolesToUser(roleids, userid);   
        }

        public List<Permission> getallpermission()
        {
            return _db.Permissions.ToList();
        }

        public Role getrolbyid(int roleid)
        {
            return _db.Roles.Find(roleid);
        }

        public List<Role> getroles()
        {
            return _db.Roles.ToList();
        }

        public List<int> permissionsrole(int roleid)
        {
            return _db.RolePermissions.Where(p => p.RoleID == roleid).Select(p => p.PermissionID).ToList();
        }

        public void Updatepermissionrole(int roleid, List<int> listpermissions)
        {
            _db.RolePermissions.Where(p => p.RoleID == roleid).ToList().ForEach(p => _db.RolePermissions.Remove(p));

            addpermissiontorole(roleid, listpermissions);
        }

        public void Updaterole(Role role)
        {
            _db.Roles.Update(role);
            _db.SaveChanges();
        }
    }
}
