#pragma checksum "C:\Users\user\source\repos\sonorous\sonorous\Views\Shared\_ForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ce20937a41002cd6069a711a12b420c6ff3bb1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ForgotPassword), @"mvc.1.0.view", @"/Views/Shared/_ForgotPassword.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ce20937a41002cd6069a711a12b420c6ff3bb1b", @"/Views/Shared/_ForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sonorous.Datalayer.Entites.User.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\source\repos\sonorous\sonorous\Views\Shared\_ForgotPassword.cshtml"
  
    ViewData["Title"] = "_AvtivateEmail";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"direction:rtl;padding:20px\">\r\n    <h2>");
#nullable restore
#line 6 "C:\Users\user\source\repos\sonorous\sonorous\Views\Shared\_ForgotPassword.cshtml"
   Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" !عزیز</h2>\r\n    <p>جهت بازیابی گلمه عبوری خود لطفا روی لینک کلیک کنید</p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 242, "\"", 312, 2);
            WriteAttributeValue("", 249, "https://localhost:44396/Account/ResetPassword/", 249, 46, true);
#nullable restore
#line 8 "C:\Users\user\source\repos\sonorous\sonorous\Views\Shared\_ForgotPassword.cshtml"
WriteAttributeValue("", 295, Model.Activecode, 295, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">بازیابی گلمه عبوری</a>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sonorous.Datalayer.Entites.User.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
