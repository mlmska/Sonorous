using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sonorous.Core.Security;
using sonorous.Core.Services.Interfaces;
using sonorous.Datalayer.Entites.User;

namespace sonorous.Pages.Admin.Roles
{
    [PermissionChecker(8)]
    public class EditRoleModel : PageModel
    {
        private IPermissionService _permissionService;

        public EditRoleModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }



        [BindProperty]
        public Role Role { get; set; }
        public void OnGet(int id)
        {
            Role = _permissionService.getrolbyid(id);
            ViewData["Permission"] = _permissionService.getallpermission();
            ViewData["SelectedPermissions"] = _permissionService.permissionsrole(id);
        }
        public IActionResult OnPost(List<int> SelectedPermissions)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            _permissionService.Updaterole(Role);

            _permissionService.Updatepermissionrole(Role.RoleID, SelectedPermissions);

            return RedirectToPage("Index");
        }
    }
}