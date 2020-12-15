using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using sonorous.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace sonorous.Core.Security
{
    public class PermissionCheckerAttribute : AuthorizeAttribute, IAuthorizationFilter 
    {
        private IPermissionService _permissionService;



        private int _permissionid=0;
        public PermissionCheckerAttribute(int permissionid)
        {
            _permissionid = permissionid;
            
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _permissionService = (IPermissionService)context.HttpContext.RequestServices.GetService(typeof(IPermissionService));
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                string username = context.HttpContext.User.Identity.Name;
                if (!_permissionService.CheckPermission(_permissionid, username))
                {
                    context.Result = new RedirectResult("/Login");
                }
            }
            else
            {
                context.Result = new RedirectResult("/Login");
            }
        }
    }
}
