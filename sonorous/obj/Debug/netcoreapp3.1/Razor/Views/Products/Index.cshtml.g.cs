#pragma checksum "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3e952899aebdfa2f265e82a4ade733b2a9304ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
using sonorous.Datalayer.Entites.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e952899aebdfa2f265e82a4ade733b2a9304ac", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<sonorous.Core.DTOs.ShowProductListViewModel>,int>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "updatedate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BoxProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formfilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Products"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"container\" class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3e952899aebdfa2f265e82a4ade733b2a9304ac5498", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"pageid\" id=\"pageid\"");
                BeginWriteAttribute("value", " value=\"", 310, "\"", 344, 1);
#nullable restore
#line 9 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
WriteAttributeValue("", 318, ViewBag.pageid.ToString(), 318, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
        <section class=""term-categories"">
            <div class=""top-bar"">
                <header>
                    <h1> دوره های <span> برنامه نویسی وب </span> </h1> <span> 123 دوره </span>
                </header>
                <div class=""row"">
                    <div class=""col-md-4 col-sm-12 col-xs-12 pull-right""> 
                            <div class=""input search"">
                                <input type=""text"" name=""filter"" placeholder=""موضوع مورد نظر ..."">
                                <button><i class=""zmdi zmdi-search""></i></button>
                            </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-xs-12 pull-right"">
                        <div class=""switch-field available"">
                            <input id=""available-filter-1"" name=""gettype"" value=""all""");
                BeginWriteAttribute("checked", " checked=\"", 1212, "\"", 1222, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""radio"">
                            <label for=""available-filter-1""> همه </label>
                            <input id=""available-filter-2"" name=""gettype"" value=""bestseller"" type=""radio"">
                            <label for=""available-filter-2""> پرفروش </label>
                            <input id=""available-filter-3"" name=""gettype"" value=""expensive"" type=""radio"">
                            <label for=""available-filter-3""> گران ترین </label>
                            <input id=""available-filter-4"" name=""gettype"" value=""visit"" type=""radio"">
                            <label for=""available-filter-4"">پر بازدید ترین </label>
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-xs-12 pull-left"">
                        <div class=""select-ddl"">
                            <select name=""orderbytype"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3e952899aebdfa2f265e82a4ade733b2a9304ac8215", async() => {
                    WriteLiteral(" تاریخ انتشار ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3e952899aebdfa2f265e82a4ade733b2a9304ac9478", async() => {
                    WriteLiteral(" تخفیف ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""row"">
                <aside class=""col-lg-3 col-md-4 col-sm-12 col-xs-12"">
                    <section class=""aside-section filter-by-price"">
                        <header><h3> فیلتر بر اساس قیمت </h3></header>
                        <div class=""price-range"">
                            <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 2758, "\"", 2766, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"min-value\" name=\"startprice\">\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2851, "\"", 2859, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""max-value"" name=""endprice"">
                            <div class=""price-bar""><div id=""priceFilter""></div></div>
                            <div class=""max-price"">تا <span id=""max-text"">500000</span> تومان</div>
                            <div class=""min-price"">از <span id=""min-text"">20000</span> تومان</div>
                            <div class=""clearfix""></div>
                        </div>
                    </section>

                    <section class=""aside-section filter-by-category"">
                        <header>
                            <h3> دسته بندی موضوعات </h3>
                        </header>
                        <div class=""inner"">
");
#nullable restore
#line 64 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                              
                                List<Product_Group> groups = ViewBag.groups as List<Product_Group>;
                                List<int> selected = ViewBag.selectedgroups as List<int>;

                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <ul>\r\n");
#nullable restore
#line 70 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                                 foreach (var item in groups.Where(p=>p.ParentID==null))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li>\r\n                                        <input onchange=\"changegroups()\" ");
#nullable restore
#line 73 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                                                                     Write((selected.Any(s => s == item.GroupID) ? "checked":""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" type=\"checkbox\" name=\"selectedGroups\" value=\"");
#nullable restore
#line 73 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                                                                                                                                                                          Write(item.GroupID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"cat-1\">\r\n                                        <label for=\"cat-1\"> ");
#nullable restore
#line 74 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                                                       Write(item.GroupTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n");
#nullable restore
#line 75 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                                         if (groups.Any(p => p.ParentID == item.GroupID))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <ul>\r\n");
#nullable restore
#line 78 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                                         foreach (var sub in groups.Where(p => p.ParentID == item.GroupID))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li>\r\n                                            <input onchange=\"changegroups()\" ");
#nullable restore
#line 81 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                                                                         Write((selected.Any(s => s == sub.GroupID) ? "checked":""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" type=\"checkbox\" name=\"selectedGroups\" value=\"");
#nullable restore
#line 81 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                                                                                                                                                                             Write(sub.GroupID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"cat-1\">\r\n                                            <label for=\"cat-1\"> ");
#nullable restore
#line 82 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                                                           Write(sub.GroupTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n                                        </li>\r\n");
#nullable restore
#line 84 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </ul>\r\n");
#nullable restore
#line 87 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </li>\r\n");
#nullable restore
#line 89 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </ul>
                        </div>
                    </section>

                </aside>
                <div class=""col-lg-9 col-md-8 col-sm-12 col-xs-12"">
                    <section class=""terms-items"">
                        <div class=""row"">
                            <div class=""cards-section"">
");
#nullable restore
#line 100 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                                foreach (var item in Model.Item1)
                               {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                   ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b3e952899aebdfa2f265e82a4ade733b2a9304ac17821", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 102 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 103 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                               }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </div>\r\n\r\n\r\n                        </div>\r\n\r\n\r\n");
#nullable restore
#line 112 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                         if (Model.Item2>1)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <nav aria-label=\"Page navigation\">\r\n                        <ul class=\"pagination justify-content-center\">\r\n\r\n");
#nullable restore
#line 117 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                             for (int i=1; i <= Model.Item2; i++)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"page-item\"><a class=\"page-link\"");
                BeginWriteAttribute("onclick", " onclick=\"", 6242, "\"", 6266, 3);
                WriteAttributeValue("", 6252, "changepage(", 6252, 11, true);
#nullable restore
#line 119 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
WriteAttributeValue("", 6263, i, 6263, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6265, ")", 6265, 1, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 119 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                                                                                               Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n");
#nullable restore
#line 120 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </ul>\r\n                    </nav>\r\n");
#nullable restore
#line 125 "C:\Users\user\source\repos\sonorous\sonorous\Views\Products\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </section>\r\n\r\n                </div>\r\n            </div>\r\n        </section>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""/noUiSlider/nouislider.min.js""></script>
    <script src=""/js/scriptss.js""></script>
    <script type=""text/javascript"">
        $(function () {

            var slider = document.getElementById('priceFilter');
            noUiSlider.create(slider, {
                start: [20000, 100000],
                step: 5000,
                connect: true,
                direction: 'rtl',
                range: {
                    'min': 20000,
                    'max': 100000
                }
            });

            var marginMin = document.getElementById('min-text'),
                marginMax = document.getElementById('max-text');

            slider.noUiSlider.on('update', function (values, handle) {
                var xvalue = Math.round(values[handle]);
                if (handle) {
                    marginMax.innerHTML = xvalue;
                } else {
                    marginMin.innerHTML = xvalue;
                }
                //console.log(valu");
                WriteLiteral(@"es[handle]);
            });

            slider.noUiSlider.on('change', function (values, handle) {
                var xvalue = Math.round(values[handle]);
                if (handle) {
                    // setGetParameter('max_price', xvalue);
                    $('#max-value').val(xvalue);
                } else {
                    // setGetParameter('min_price', xvalue);
                    $('#min-value').val(xvalue);
                }
            });


            slider.noUiSlider.on('slide', function (values, handle) {

                console.log(values[0]);
                console.log(values[1]);

                var xvalue = Math.round(values[handle]);
                //updateSliderRange( Math.round(values[0]), Math.round(values[1]) );
            });

          


            function updateSliderRange(min, max) {
                slider.noUiSlider.updateOptions({
                    range: {
                        'min': min,
                        'max': max");
                WriteLiteral(@"
                    }
                });
            }
        });
        function changegroups() {
            $(""#formfilter"").submit();
        }

        function changepage(pageid) {
            $(""#pageid"").val(pageid);
            $(""#formfilter"").submit();
        }
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<sonorous.Core.DTOs.ShowProductListViewModel>,int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
