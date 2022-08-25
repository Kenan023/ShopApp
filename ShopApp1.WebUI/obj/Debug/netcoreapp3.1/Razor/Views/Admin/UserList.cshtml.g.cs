#pragma checksum "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "596d26c8e3af88cf4259c34b971a7eccade8521d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserList), @"mvc.1.0.view", @"/Views/Admin/UserList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596d26c8e3af88cf4259c34b971a7eccade8521d", @"/Views/Admin/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0581a27b8847255a42f0a9fda05cb9c92c6cbcfa", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/user/delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.20/css/dataTables.bootstrap4.min.css\" />\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""//cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.20/js/dataTables.bootstrap4.min.js""></script>
    <script>
        $(document).ready(function () {
            $('#myTable').DataTable();
        });
    </script>
");
            }
            );
            WriteLiteral(@"
<div class=""row"">
    <div class=""col md-12"">
        <h1 class=""h3"">User List</h1>
        <hr />
        <a href=""/admin/user/create"" class=""btn btn-primary btn-sm"">Create User</a>
        <hr />
        <table data-page-lenght='3' id=""myTable"" class=""table table-bordered mt-3"">
            <thead>
                <tr>
                    <td>FirstName</td>
                    <td>LastName</td>
                    <td>UsertName</td>
                    <td>Email</td>
                    <td>EmailConfirmed</td>
                    <td style=""width:160px""></td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 34 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\UserList.cshtml"
                 if (Model.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\UserList.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("class", " class=\"", 1291, "\"", 1336, 1);
#nullable restore
#line 38 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\UserList.cshtml"
WriteAttributeValue("", 1299, item.EmailConfirmed?"":"bg-danger", 1299, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>");
#nullable restore
#line 39 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\UserList.cshtml"
                           Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\UserList.cshtml"
                           Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\UserList.cshtml"
                           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\UserList.cshtml"
                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\UserList.cshtml"
                           Write(item.EmailConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1677, "\"", 1704, 2);
            WriteAttributeValue("", 1684, "/admin/user/", 1684, 12, true);
#nullable restore
#line 45 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\UserList.cshtml"
WriteAttributeValue("", 1696, item.Id, 1696, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "596d26c8e3af88cf4259c34b971a7eccade8521d9260", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 1929, "\"", 1945, 1);
#nullable restore
#line 48 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\UserList.cshtml"
WriteAttributeValue("", 1937, item.Id, 1937, 8, false);

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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\UserList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\UserList.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>\r\n                            No Users\r\n                        </h3>\r\n                    </div>\r\n");
#nullable restore
#line 62 "C:\Users\HP\source\repos\ShopApp1\ShopApp1.WebUI\Views\Admin\UserList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591