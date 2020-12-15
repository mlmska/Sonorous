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
    [PermissionChecker(5)]
    public class DeleteUserModel : PageModel
    {
        private IUserServices _userServices;

        public DeleteUserModel(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public InformationViewModel InformationViewModel { get; set; }
        public void OnGet(int id)
        {
            ViewData["UserID"] = id;
            InformationViewModel = _userServices.GetUserinformation(id);
        }

        public IActionResult OnPost(int userid)
        {
            _userServices.Deleteusers(userid);
            return RedirectToPage("Index");
        }
    }
}