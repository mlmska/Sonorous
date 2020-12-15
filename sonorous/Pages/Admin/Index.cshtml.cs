using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sonorous.Core.Security;

namespace sonorous.Pages.Admin
{
    [PermissionChecker(2)]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}