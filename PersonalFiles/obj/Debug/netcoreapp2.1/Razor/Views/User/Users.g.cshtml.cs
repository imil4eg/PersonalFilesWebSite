#pragma checksum "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\User\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a0ab1126a9ecda7c3e787ba3974150ec4be552f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Users), @"mvc.1.0.view", @"/Views/User/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Users.cshtml", typeof(AspNetCore.Views_User_Users))]
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
#line 1 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\_ViewImports.cshtml"
using PersonalFiles;

#line default
#line hidden
#line 2 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\_ViewImports.cshtml"
using PersonalFiles.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a0ab1126a9ecda7c3e787ba3974150ec4be552f", @"/Views/User/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b12e5c64af18e6ff6423adfad90bb530508289c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\User\Users.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
            BeginContext(78, 97, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <hr />\r\n        <table class=\"table\">\r\n");
            EndContext();
#line 11 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\User\Users.cshtml"
             foreach (var user in Model)
            {

#line default
#line hidden
            BeginContext(232, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(279, 7, false);
#line 14 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\User\Users.cshtml"
                   Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(286, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(318, 13, false);
#line 15 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\User\Users.cshtml"
                   Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(331, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(363, 13, false);
#line 16 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\User\Users.cshtml"
                   Write(user.RoleName);

#line default
#line hidden
            EndContext();
            BeginContext(376, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(408, 109, false);
#line 17 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\User\Users.cshtml"
                   Write(Html.ActionLink("Изменить", "EditUser", "User", new { userId = user.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(517, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(549, 95, false);
#line 18 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\User\Users.cshtml"
                   Write(Html.ActionLink("Удалить", "", "", new { userId = user.Id }, new {  @class = "btn btn-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(644, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 20 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\User\Users.cshtml"
            }

#line default
#line hidden
            BeginContext(689, 40, true);
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591