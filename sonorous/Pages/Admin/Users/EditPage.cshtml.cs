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
    [PermissionChecker(4)]
    public class EditPageModel : PageModel
    {
        private IUserServices _userServices;
        private IPermissionService _permissionService;
        public EditPageModel(IUserServices userServices,IPermissionService permissionService)
        {
            _userServices = userServices;
            _permissionService = permissionService;
        }


        [BindProperty]
        public EditUserViewModel EditUserViewModel { get; set; }
        public void OnGet(int id)
        {
          EditUserViewModel =_userServices.GetUserForShowinEditadmin(id);
           ViewData["Roles"] = _permissionService.getroles();
        }
        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _userServices.Edituserfromadmin(EditUserViewModel);

            //editroles
            _permissionService.Editrolesuser(EditUserViewModel.UserID, SelectedRoles);

            return RedirectToPage("Index");
        }
    }
}