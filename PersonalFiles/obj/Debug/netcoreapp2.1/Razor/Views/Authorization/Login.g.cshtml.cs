#pragma checksum "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "824a012b8752cc4cc08b100cf93f322fb1ca3e0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authorization_Login), @"mvc.1.0.view", @"/Views/Authorization/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Authorization/Login.cshtml", typeof(AspNetCore.Views_Authorization_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"824a012b8752cc4cc08b100cf93f322fb1ca3e0a", @"/Views/Authorization/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b12e5c64af18e6ff6423adfad90bb530508289c", @"/Views/_ViewImports.cshtml")]
    public class Views_Authorization_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalFiles.Models.LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(87, 83, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-5\">\r\n        <section id=\"loginForm\">\r\n");
            EndContext();
#line 10 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
             using (Html.BeginForm("Login", "Security", FormMethod.Post, new { @class = "form-horizontal" }))
            {
                

#line default
#line hidden
            BeginContext(313, 23, false);
#line 12 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(338, 93, true);
            WriteLiteral("                <h4>Используйте локальный аккаунт чтобы войти.</h4>\r\n                <hr />\r\n");
            EndContext();
            BeginContext(448, 64, false);
#line 15 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(514, 62, true);
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(577, 64, false);
#line 17 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
               Write(Html.LabelFor(m => m.UserName, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(641, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(695, 65, false);
#line 19 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
                   Write(Html.TextBoxFor(m => m.UserName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(760, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(787, 78, false);
#line 20 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
                   Write(Html.ValidationMessageFor(m => m.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(865, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(982, 64, false);
#line 24 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
               Write(Html.LabelFor(m => m.Password, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1100, 66, false);
#line 26 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1193, 78, false);
#line 27 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 232, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <div class=\"col-md-offset-1 col-md-5\">\r\n                        <div class=\"checkbox\">\r\n                            ");
            EndContext();
            BeginContext(1504, 35, false);
#line 33 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
                       Write(Html.CheckBoxFor(m => m.RememberMe));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1570, 32, false);
#line 34 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
                       Write(Html.LabelFor(m => m.RememberMe));

#line default
#line hidden
            EndContext();
            BeginContext(1602, 353, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-md-10"">
                        <input type=""submit"" value=""Войти"" class=""btn btn-default"" />
                    </div>
                </div>
                <p>
                    ");
            EndContext();
            BeginContext(1956, 61, false);
#line 44 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
               Write(Html.ActionLink("Зарегистрироваться", "Register", "Security"));

#line default
#line hidden
            EndContext();
            BeginContext(2017, 24, true);
            WriteLiteral("\r\n                </p>\r\n");
            EndContext();
#line 46 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
            }

#line default
#line hidden
            BeginContext(2056, 40, true);
            WriteLiteral("        </section>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonalFiles.Models.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591