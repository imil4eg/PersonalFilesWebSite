#pragma checksum "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0d3ce7bda38613677bcc03f42b7b8a2dbd9c81d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d3ce7bda38613677bcc03f42b7b8a2dbd9c81d", @"/Views/Authorization/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b12e5c64af18e6ff6423adfad90bb530508289c", @"/Views/_ViewImports.cshtml")]
    public class Views_Authorization_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalFiles.Models.LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("profile-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-img-card"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/avatar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(87, 74, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"card card-container\">\r\n        ");
            EndContext();
            BeginContext(161, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2d003c4bb5094a9384d9006a2fbb6a86", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(236, 63, true);
            WriteLiteral("\r\n        <p id=\"profile-name\" class=\"profile-name-card\"></p>\r\n");
            EndContext();
#line 11 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
             using (Html.BeginForm("Login", "Authorization", FormMethod.Post, new { @class = "form-signin" }))
            {
                

#line default
#line hidden
            BeginContext(443, 23, false);
#line 13 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(468, 94, true);
            WriteLiteral("                <span id=\"reauth-email\" class=\"reauth-email\"></span>\r\n                <hr />\r\n");
            EndContext();
            BeginContext(579, 64, false);
#line 16 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(645, 62, true);
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(708, 99, false);
#line 18 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
               Write(Html.TextBoxFor(m => m.UserName, new { placeholder = "Имя пользователя", @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(807, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(830, 78, false);
#line 19 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
               Write(Html.ValidationMessageFor(m => m.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(908, 88, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(997, 90, false);
#line 22 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
               Write(Html.PasswordFor(m => m.Password, new { placeholder = "Пароль", @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1087, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1110, 78, false);
#line 23 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
               Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 88, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1277, 35, false);
#line 26 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
               Write(Html.CheckBoxFor(m => m.RememberMe));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1335, 32, false);
#line 27 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
               Write(Html.LabelFor(m => m.RememberMe));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 132, true);
            WriteLiteral("\r\n                </div>\r\n                <button class=\"btn btn-lg btn-primary btn-block btn-signin\" type=\"submit\">Войти</button>\r\n");
            EndContext();
#line 30 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Authorization\Login.cshtml"
            }

#line default
#line hidden
            BeginContext(1514, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
