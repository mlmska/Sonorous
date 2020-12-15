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
    [PermissionChecker(7)]
    public class CreateRoleModel : PageModel
    {
        private IPermissionService _permissionService;

        public CreateRoleModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }


        [BindProperty]
        public Role Role { get; set; }
        public void OnGet()
        {
            ViewData["Permission"] = _permissionService.getallpermission();
        }

        public IActionResult OnPost(List<int> SelectedPermissions)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Role.isDelete = false;
            int roleid=_permissionService.AddRole(Role);

            _permissionService.addpermissiontorole(roleid, SelectedPermissions);

            return RedirectToPage("Index");
        }
    }
}