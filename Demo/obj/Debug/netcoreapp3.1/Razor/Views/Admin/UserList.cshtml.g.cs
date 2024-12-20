#pragma checksum "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3a8a3b340c2b336c9ac74e2b66561841401a663034b3cbf54f35feef23ebc64f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Admin_UserList), @"mvc.1.0.view", @"/Views/Admin/UserList.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\workspace\FGW-1670\1670\Demo\Views\_ViewImports.cshtml"
using Demo

#nullable disable
    ;
#nullable restore
#line 2 "D:\workspace\FGW-1670\1670\Demo\Views\_ViewImports.cshtml"
using Demo.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3a8a3b340c2b336c9ac74e2b66561841401a663034b3cbf54f35feef23ebc64f", @"/Views/Admin/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8700511b3c3dbec7cfe891098073c85db464dcba3f7a81a0aee725929ed53c12", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Admin_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
       List<Demo.Models.UserViewModel>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResetPass", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
 if (TempData["Message"] != null) {

#line default
#line hidden
#nullable disable

            WriteLiteral("   <span class=\"alert alert-success\">");
            Write(
#nullable restore
#line 4 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
                                      TempData["Message"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n");
#nullable restore
#line 5 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
 if (TempData["Error"] != null)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <span class=\"alert alert-danger\">");
            Write(
#nullable restore
#line 9 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
                                      TempData["Error"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n");
#nullable restore
#line 10 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<h1 class=""text text-primary mt-3 mb-3"">User List</h1>
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>No.</th>
            <th>Id</th>
            <th>Username</th>
            <th>Email</th>
            <th>Roles</th>
            <th>Menu</th>
        </tr>
    </thead>
");
#nullable restore
#line 24 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
      
        var counter = 1;
    

#line default
#line hidden
#nullable disable

            WriteLiteral("    <tbody>\r\n");
#nullable restore
#line 28 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
         foreach (var user in Model) {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <td>");
            Write(
#nullable restore
#line 30 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
                 counter

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 31 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
                 user.Id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 32 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
                 user.Username

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 33 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
                 user.Email

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 34 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
                 string.Join(", ", user.Roles)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a8a3b340c2b336c9ac74e2b66561841401a663034b3cbf54f35feef23ebc64f7595", async() => {
                WriteLiteral("Reset Pass");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 36 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
                                                                                 user.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "D:\workspace\FGW-1670\1670\Demo\Views\Admin\UserList.cshtml"
        counter++;
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Demo.Models.UserViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
