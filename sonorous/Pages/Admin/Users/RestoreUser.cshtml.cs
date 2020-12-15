using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sonorous.Core.DTOs;
using sonorous.Core.Services.Interfaces;

namespace sonorous.Pages.Admin.Users
{
    public class RestoreUserModel : PageModel
    {
        private IUserServices _userServices;

        public RestoreUserModel(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public InformationViewModel InformationViewModel { get; set; }
        public void OnGet(int id)
        {
            ViewData["UserID"] = id;
            InformationViewModel = _userServices.getdeleteduserinformation(id);
        }

        public IActionResult OnPost(int userid)
        {
            _userServices.Restoruser(userid);
            return RedirectToPage("Index");
        }
    }
}