using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sonorous.Core.DTOs;
using sonorous.Core.Security;
using sonorous.Core.Services.Interfaces;
using sonorous.Datalayer.Entites.User;

namespace sonorous.Pages.Admin.Roles
{
    [PermissionChecker(6)]
    public class IndexModel : PageModel
    {
        private IPermissionService _permissionService;

        public IndexModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        public List<Role> listroles { get; set; }

        public void OnGet()
        {
            listroles = _permissionService.getroles();
        }
    }
}