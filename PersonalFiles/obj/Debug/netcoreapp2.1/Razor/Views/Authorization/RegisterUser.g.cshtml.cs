#pragma checksum "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edd6da7db1dc6d486a9370453c6a1859a01f38a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authorization_RegisterUser), @"mvc.1.0.view", @"/Views/Authorization/RegisterUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Authorization/RegisterUser.cshtml", typeof(AspNetCore.Views_Authorization_RegisterUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edd6da7db1dc6d486a9370453c6a1859a01f38a1", @"/Views/Authorization/RegisterUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b12e5c64af18e6ff6423adfad90bb530508289c", @"/Views/_ViewImports.cshtml")]
    public class Views_Authorization_RegisterUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalFiles.Models.RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(93, 86, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-5\">\r\n        <section id=\"registerForm\">\r\n");
            EndContext();
#line 10 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
             using (Html.BeginForm("RegisterUser", "Authorization", FormMethod.Post, new { @class = "form-horizontal" }))
            {
                

#line default
#line hidden
            BeginContext(334, 23, false);
#line 12 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(376, 37, false);
#line 13 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
           Write(Html.HiddenFor(m => m.UserRole.Roles));

#line default
#line hidden
            EndContext();
            BeginContext(417, 62, true);
            WriteLiteral("                <h2>Регистрация</h2>\r\n                <hr />\r\n");
            EndContext();
            BeginContext(496, 64, false);
#line 17 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(562, 62, true);
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(625, 64, false);
#line 19 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
               Write(Html.LabelFor(m => m.UserName, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(689, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(743, 65, false);
#line 21 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.TextBoxFor(m => m.UserName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(808, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(835, 78, false);
#line 22 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.ValidationMessageFor(m => m.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(913, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1030, 61, false);
#line 26 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
               Write(Html.LabelFor(m => m.Email, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1145, 62, false);
#line 28 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1207, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1234, 75, false);
#line 29 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1426, 64, false);
#line 33 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
               Write(Html.LabelFor(m => m.Password, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1544, 66, false);
#line 35 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1637, 78, false);
#line 36 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1715, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1832, 71, false);
#line 40 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
               Write(Html.LabelFor(m => m.PasswordConfirm, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1903, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1957, 73, false);
#line 42 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.PasswordFor(m => m.PasswordConfirm, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2030, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2057, 85, false);
#line 43 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.ValidationMessageFor(m => m.PasswordConfirm, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2142, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(2259, 64, false);
#line 47 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
               Write(Html.LabelFor(m => m.LastName, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2323, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(2377, 65, false);
#line 49 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2442, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2469, 78, false);
#line 50 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.ValidationMessageFor(m => m.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2547, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(2664, 65, false);
#line 54 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
               Write(Html.LabelFor(m => m.FirstName, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2729, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(2783, 66, false);
#line 56 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.TextBoxFor(m => m.FirstName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2849, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2876, 79, false);
#line 57 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.ValidationMessageFor(m => m.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2955, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(3072, 66, false);
#line 61 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
               Write(Html.LabelFor(m => m.MiddleName, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(3138, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(3192, 67, false);
#line 63 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.TextBoxFor(m => m.MiddleName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3259, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3286, 80, false);
#line 64 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.ValidationMessageFor(m => m.MiddleName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3366, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(3483, 67, false);
#line 68 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
               Write(Html.LabelFor(m => m.DateOfBirth, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(3550, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(3604, 68, false);
#line 70 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.TextBoxFor(m => m.DateOfBirth, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3672, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3699, 81, false);
#line 71 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.ValidationMessageFor(m => m.DateOfBirth, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3780, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(3897, 62, false);
#line 75 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
               Write(Html.LabelFor(m => m.Gender, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(3959, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(4013, 116, false);
#line 77 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.DropDownListFor(m => m.Gender, new SelectList(Enum.GetValues(typeof(Gender))), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4129, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(4156, 76, false);
#line 78 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Gender, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4232, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(4349, 64, false);
#line 82 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
               Write(Html.LabelFor(m => m.UserRole, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(4413, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(4467, 168, false);
#line 84 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
                   Write(Html.DropDownListFor(m => m.UserRole.SelectedRoleId, new SelectList(Model.UserRole.Roles, "Id", "Name", Model.UserRole.SelectedRoleId), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4635, 275, true);
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group"">
                    <div>
                        <input type=""submit"" value=""Зарегистрироваться"" class=""btn btn-success"" />
                    </div>
                </div>
");
            EndContext();
#line 92 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\RegisterUser.cshtml"
            }

#line default
#line hidden
            BeginContext(4925, 42, true);
            WriteLiteral("        </section>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonalFiles.Models.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591