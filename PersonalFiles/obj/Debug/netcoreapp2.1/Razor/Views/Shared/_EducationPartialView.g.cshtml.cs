#pragma checksum "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Shared\_EducationPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48635d17754379780066700ba5a78da698a3ba83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__EducationPartialView), @"mvc.1.0.view", @"/Views/Shared/_EducationPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_EducationPartialView.cshtml", typeof(AspNetCore.Views_Shared__EducationPartialView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48635d17754379780066700ba5a78da698a3ba83", @"/Views/Shared/_EducationPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b12e5c64af18e6ff6423adfad90bb530508289c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__EducationPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EducationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 100, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <div class=\"profile-img\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 127, "\"", 187, 1);
#line 6 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Shared\_EducationPartialView.cshtml"
WriteAttributeValue("", 133, Url.Action("RenderImage", new { image = Model.File }), 133, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(188, 103, true);
            WriteLiteral(" alt=\"\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(292, 29, false);
#line 12 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Shared\_EducationPartialView.cshtml"
   Write(Html.LabelFor(m => m.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(321, 50, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(372, 64, false);
#line 15 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Shared\_EducationPartialView.cshtml"
   Write(Html.TextBoxFor(m => m.EndDate, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(436, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(447, 77, false);
#line 16 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Shared\_EducationPartialView.cshtml"
   Write(Html.ValidationMessageFor(m => m.EndDate, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(524, 45, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(570, 123, false);
#line 20 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Shared\_EducationPartialView.cshtml"
Write(Html.ActionLink("Изменить", "EditEducation", "Education", new { educationId = Model.Id }, new { @class = "btn btn-group" }));

#line default
#line hidden
            EndContext();
            BeginContext(693, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(700, 125, false);
#line 21 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Shared\_EducationPartialView.cshtml"
Write(Html.ActionLink("Удалить", "DeleteEducation", "Education", new { educationId = Model.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(825, 20, true);
            WriteLiteral("\r\n</div>\r\n<hr />\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EducationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591