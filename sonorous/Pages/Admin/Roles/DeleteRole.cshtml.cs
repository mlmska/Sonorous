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
    [PermissionChecker(9)]
    public class DeleteRoleModel : PageModel
    {
        private IPermissionService _permissionService;

        public DeleteRoleModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [BindProperty]
        public Role Role { get; set; }
        public void OnGet(int id)
        {
            Role = _permissionService.getrolbyid(id);
        }

        public IActionResult OnPost()
        {
            _permissionService.DeleteRole(Role);


            return RedirectToPage("Index");
        }


    }
}