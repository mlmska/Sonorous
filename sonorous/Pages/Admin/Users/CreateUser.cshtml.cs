using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sonorous.Core.DTOs;
using sonorous.Core.Security;
using sonorous.Core.Services.Interfaces;

namespace sonorous.Pages.Admin.Users
{
    [PermissionChecker(3)]
    public class CreateUserModel : PageModel
    {
        private IUserServices _userServices;
        private IPermissionService _permissionService;

        public CreateUserModel(IUserServices userServices, IPermissionService permissionService)
        {
            _userServices = userServices;
            _permissionService = permissionService;
        }

        [BindProperty]
        public CreateUserViewModel CreateUserViewModel { get; set; }
        public void OnGet()
        {
            ViewData["Roles"] = _permissionService.getroles();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            int userid = _userServices.adduserfromadmin(CreateUserViewModel);

            //add roles
            _permissionService.AddRolesToUser(SelectedRoles, userid);



            return Redirect("/Admin/Users");
        }
    }
}