#pragma checksum "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41149e47a70a926585f9b6d10e4df549c428e804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductList), @"mvc.1.0.view", @"/Views/Admin/ProductList.cshtml")]
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
#line 2 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\_ViewImports.cshtml"
using ShopApp1.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\_ViewImports.cshtml"
using ShopApp1.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\_ViewImports.cshtml"
using ShopApp1.WebUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\_ViewImports.cshtml"
using ShopApp1.WebUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41149e47a70a926585f9b6d10e4df549c428e804", @"/Views/Admin/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0581a27b8847255a42f0a9fda05cb9c92c6cbcfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deleteproduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col md-12"">
        <h1 class=""h3"">Admin Products</h1>
        <hr />
        <a href=""/admin/products/create"" class=""btn btn-primary btn-sm"">Add Product</a>
        <table class=""table table-bordered mt-3"">
            <thead>
                <tr>
                    <td style=""width:30px"">Id</td>
                    <td style=""width:100px"">Image</td>
                    <td>Name</td>
                    <td style=""width:20px"">Price</td>
                    <td style=""width:20px"">HomePage</td>
                    <td style=""width:20px"">Approved</td>
                    <td style=""width:150px""></td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 21 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
                 if (Model.Products.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
                     foreach (var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
                           Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "41149e47a70a926585f9b6d10e4df549c428e8047128", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1028, "~/img/", 1028, 6, true);
#nullable restore
#line 27 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
AddHtmlAttributeValue("", 1034, item.ImageUrl, 1034, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 31 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
                                 if (item.IsHome)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-check-circle\" style=\"color:blue\"></i>\r\n");
#nullable restore
#line 34 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-times-circle\" style=\"color:red\"></i>\r\n");
#nullable restore
#line 38 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 41 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
                                 if (item.IsApproved)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-check-circle\" style=\"color:blue\"></i>\r\n");
#nullable restore
#line 44 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-times-circle\" style=\"color:red\"></i>\r\n");
#nullable restore
#line 48 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2203, "\"", 2241, 2);
            WriteAttributeValue("", 2210, "/admin/products/", 2210, 16, true);
#nullable restore
#line 51 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
WriteAttributeValue("", 2226, item.ProductId, 2226, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41149e47a70a926585f9b6d10e4df549c428e80412007", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 2471, "\"", 2494, 1);
#nullable restore
#line 54 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
WriteAttributeValue("", 2479, item.ProductId, 2479, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <button class=\"btn btn-danger btn-sm\" type=\"submit\">Delete</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 59 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>\r\n                            No Products\r\n                        </h3>\r\n                    </div>\r\n");
#nullable restore
#line 68 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\ProductList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591