#pragma checksum "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c150230e62503ae81ec2d77ff8a6f48d62a64a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Security_Register), @"mvc.1.0.view", @"/Views/Security/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Security/Register.cshtml", typeof(AspNetCore.Views_Security_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c150230e62503ae81ec2d77ff8a6f48d62a64a5", @"/Views/Security/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b12e5c64af18e6ff6423adfad90bb530508289c", @"/Views/_ViewImports.cshtml")]
    public class Views_Security_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalFiles.Models.RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(93, 86, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-5\">\r\n        <section id=\"registerForm\">\r\n");
            EndContext();
#line 10 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
             using (Html.BeginForm("Password", "Security", FormMethod.Post, new { @class = "form-horizontal" }))
            {
                

#line default
#line hidden
            BeginContext(325, 23, false);
#line 12 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(352, 62, true);
            WriteLiteral("                <h2>Регистрация</h2>\r\n                <hr />\r\n");
            EndContext();
            BeginContext(431, 64, false);
#line 16 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(497, 62, true);
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(560, 61, false);
#line 18 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
               Write(Html.LabelFor(m => m.Login, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(621, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(675, 62, false);
#line 20 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.Login, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(737, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(764, 75, false);
#line 21 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Login, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(839, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(956, 64, false);
#line 25 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
               Write(Html.LabelFor(m => m.Password, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1074, 65, false);
#line 27 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1166, 78, false);
#line 28 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1361, 71, false);
#line 32 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
               Write(Html.LabelFor(m => m.PasswordConfirm, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1432, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1486, 72, false);
#line 34 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.PasswordConfirm, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1585, 85, false);
#line 35 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.ValidationMessageFor(m => m.PasswordConfirm, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1670, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1787, 64, false);
#line 39 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
               Write(Html.LabelFor(m => m.LastName, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1905, 65, false);
#line 41 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1970, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1997, 78, false);
#line 42 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.ValidationMessageFor(m => m.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2075, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(2192, 65, false);
#line 46 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
               Write(Html.LabelFor(m => m.FirstName, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2257, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(2311, 66, false);
#line 48 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.FirstName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2377, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2404, 79, false);
#line 49 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.ValidationMessageFor(m => m.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2483, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(2600, 66, false);
#line 53 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
               Write(Html.LabelFor(m => m.MiddleName, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2666, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(2720, 67, false);
#line 55 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.MiddleName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2787, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2814, 80, false);
#line 56 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.ValidationMessageFor(m => m.MiddleName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2894, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(3011, 67, false);
#line 60 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
               Write(Html.LabelFor(m => m.DateOfBirth, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(3078, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(3132, 68, false);
#line 62 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.TextBoxFor(m => m.DateOfBirth, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3200, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3227, 81, false);
#line 63 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.ValidationMessageFor(m => m.DateOfBirth, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3308, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(3425, 62, false);
#line 67 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
               Write(Html.LabelFor(m => m.Gender, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(3487, 53, true);
            WriteLiteral("\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(3541, 116, false);
#line 69 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.DropDownListFor(m => m.Gender, new SelectList(Enum.GetValues(typeof(Gender))), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3657, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3684, 75, false);
#line 70 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Login, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3759, 299, true);
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-md-offset-2"">
                        <input type=""submit"" value=""Зарегистрироваться"" class=""btn btn-default"" />
                    </div>
                </div>
");
            EndContext();
#line 78 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Security\Register.cshtml"
            }

#line default
#line hidden
            BeginContext(4073, 42, true);
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