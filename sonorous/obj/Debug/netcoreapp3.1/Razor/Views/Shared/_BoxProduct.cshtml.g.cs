#pragma checksum "C:\Users\user\source\repos\sonorous\sonorous\Views\Shared\_BoxProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0177c2781128b27b79b5cfe01ad7afc30a75b3dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BoxProduct), @"mvc.1.0.view", @"/Views/Shared/_BoxProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0177c2781128b27b79b5cfe01ad7afc30a75b3dc", @"/Views/Shared/_BoxProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BoxProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sonorous.Core.DTOs.ShowProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card\">\r\n    <span class=\"saving saving-left\">50%</span>\r\n\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 133, "\"", 178, 2);
            WriteAttributeValue("", 139, "/Products/image/", 139, 16, true);
#nullable restore
#line 6 "C:\Users\user\source\repos\sonorous\sonorous\Views\Shared\_BoxProduct.cshtml"
WriteAttributeValue("", 155, Model.ProductImageName, 155, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 179, "\"", 215, 2);
            WriteAttributeValue("", 186, "/ShowProduct/", 186, 13, true);
#nullable restore
#line 6 "C:\Users\user\source\repos\sonorous\sonorous\Views\Shared\_BoxProduct.cshtml"
WriteAttributeValue("", 199, Model.ProductID, 199, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n    <div class=\"card-body\">\r\n        <div class=\"caption\">\r\n            <h4><a");
            BeginWriteAttribute("href", " href=\"", 328, "\"", 364, 2);
            WriteAttributeValue("", 335, "/ShowProduct/", 335, 13, true);
#nullable restore
#line 9 "C:\Users\user\source\repos\sonorous\sonorous\Views\Shared\_BoxProduct.cshtml"
WriteAttributeValue("", 348, Model.ProductID, 348, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "C:\Users\user\source\repos\sonorous\sonorous\Views\Shared\_BoxProduct.cshtml"
                                                   Write(Model.ProductTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n            <p class=\"price\"> <span class=\"price-new\">");
#nullable restore
#line 10 "C:\Users\user\source\repos\sonorous\sonorous\Views\Shared\_BoxProduct.cshtml"
                                                 Write(Model.Price.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> <span class=""price-old"">240000 تومان</span> </p>
            <div class=""rating"">
                <span class=""fa fa-stack"">
                    <i class=""fa fa-star fa-stack-2x""></i>
                    <i class=""fa fa-star-o fa-stack-2x""></i>
                </span> <span class=""fa fa-stack"">
                    <i class=""fa fa-star fa-stack-2x""></i>
                    <i class=""fa fa-star-o fa-stack-2x""></i>
                </span><span class=""fa fa-stack"">
                    <i class=""fa fa-star fa-stack-2x""></i><i class=""fa fa-star-o fa-stack-2x""></i>
                </span>
                <span class=""fa fa-stack"">
                    <i class=""fa fa-star fa-stack-2x""></i>
                    <i class=""fa fa-star-o fa-stack-2x""></i>
                </span>
                <span class=""fa fa-stack""><i class=""fa fa-star-o fa-stack-2x""></i></span>
            </div>
        </div>
        <div class=""button-group"">
            <a class=""afzoden""");
            BeginWriteAttribute("href", " href=\"", 1470, "\"", 1506, 2);
            WriteAttributeValue("", 1477, "/ShowProduct/", 1477, 13, true);
#nullable restore
#line 29 "C:\Users\user\source\repos\sonorous\sonorous\Views\Shared\_BoxProduct.cshtml"
WriteAttributeValue("", 1490, Model.ProductID, 1490, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span> نمایش</span></a>\r\n            <div class=\"add-to-links\">\r\n                <button class=\"favorite\" type=\"button\" data-toggle=\"tooltip\"");
            BeginWriteAttribute("title", " title=\"", 1649, "\"", 1657, 0);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1658, "\"", 1668, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"افزودن به علاقه مندی ها\"><i class=\"fa fa-heart\"></i></button>\r\n                <button class=\"favorite\" type=\"button\" data-toggle=\"tooltip\"");
            BeginWriteAttribute("title", " title=\"", 1830, "\"", 1838, 0);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1839, "\"", 1849, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"افزودن به علاقه مندی ها\"><i class=\"fa fa-heart\"></i></button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sonorous.Core.DTOs.ShowProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591