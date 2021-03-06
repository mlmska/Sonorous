﻿using System;
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
    [PermissionChecker(2)]
    public class ListDeleteUserModel : PageModel
    {
        private IUserServices _userServices;

        public ListDeleteUserModel(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public UserforAdminViewModel UserforAdminViewModel { get; set; }
        public void OnGet(int pageid = 1, string filterUserName = "", string filterEmail = "")
        {
            UserforAdminViewModel = _userServices.Getdeleteusers(pageid, filterEmail, filterUserName);
        }
    }
}