#pragma checksum "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05fc4087659c74db933914147cee5bfd6ed522dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Profile), @"mvc.1.0.view", @"/Views/Person/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Profile.cshtml", typeof(AspNetCore.Views_Person_Profile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05fc4087659c74db933914147cee5bfd6ed522dd", @"/Views/Person/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b12e5c64af18e6ff6423adfad90bb530508289c", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/avatar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(69, 133, true);
            WriteLiteral("\r\n<div class=\"container emp-profile\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <div class=\"profile-img\">\r\n");
            EndContext();
#line 11 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                 if (Model.Image.Length == 0)
                {

#line default
#line hidden
            BeginContext(268, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(288, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "84203bb6fd81464c8442672f34370b1b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(328, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(390, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 414, "\"", 481, 2);
            WriteAttributeValue("", 420, "data:image;base64,", 420, 18, true);
#line 17 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
WriteAttributeValue("", 438, System.Convert.ToBase64String(Model.Image), 438, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(482, 12, true);
            WriteLiteral(" alt=\"\" />\r\n");
            EndContext();
#line 18 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                }

#line default
#line hidden
            BeginContext(513, 128, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <div class=\"profile-head\">\r\n                <h5>");
            EndContext();
            BeginContext(642, 57, false);
#line 23 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
               Write(string.Format("{0} {1}", Model.FirstName, Model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(699, 27, true);
            WriteLiteral("</h5>\r\n                <h6>");
            EndContext();
            BeginContext(727, 15, false);
#line 24 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
               Write(Model.Post.Name);

#line default
#line hidden
            EndContext();
            BeginContext(742, 1098, true);
            WriteLiteral(@"</h6>
                <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""true"">Инофрмация</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""passport-tab"" data-toggle=""tab"" href=""#passport"" role=""tab"" aria-controls=""passport"" aria-selected=""false"">Паспорт</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""education-tab"" data-toggle=""tab"" href=""#education"" role=""tab"" aria-controls=""education"" aria-selected=""false"">Образование</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""insurance-tab"" data-toggle=""tab"" href=""#insurance"" role=""tab"" aria-controls=""insurance"" aria-selected=""false"">Страховка</a>
            ");
            WriteLiteral("        </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 41 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
         if (!User.IsInRole("Read"))
        {

#line default
#line hidden
            BeginContext(1889, 52, true);
            WriteLiteral("            <div class=\"col-md-2\">\r\n                ");
            EndContext();
            BeginContext(1942, 125, false);
#line 44 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
           Write(Html.ActionLink("Изменить данные", "EditProfile", "Person", new { personId = Model.Id }, new { @class = "profile-edit-btn" }));

#line default
#line hidden
            EndContext();
            BeginContext(2067, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 46 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
        }

#line default
#line hidden
            BeginContext(2100, 400, true);
            WriteLiteral(@"    </div>
    <div class=""row"">
        <div class=""col-md-4""></div>
        <div class=""col-md-8"">
            <div class=""tab-content profile-tab"" id=""myTabContent"">
                <div class=""tab-pane fade active"" id=""profile"" role=""tabpanel"" aria-labelledby=""profile-tab"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            ");
            EndContext();
            BeginContext(2501, 30, false);
#line 55 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                       Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2531, 113, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
            EndContext();
            BeginContext(2645, 14, false);
#line 58 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                          Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2659, 181, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            ");
            EndContext();
            BeginContext(2841, 31, false);
#line 63 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                       Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2872, 113, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
            EndContext();
            BeginContext(2986, 15, false);
#line 66 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                          Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3001, 181, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            ");
            EndContext();
            BeginContext(3183, 32, false);
#line 71 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                       Write(Html.LabelFor(m => m.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(3215, 113, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
            EndContext();
            BeginContext(3329, 16, false);
#line 74 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                          Write(Model.MiddleName);

#line default
#line hidden
            EndContext();
            BeginContext(3345, 181, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            ");
            EndContext();
            BeginContext(3527, 28, false);
#line 79 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                       Write(Html.LabelFor(m => m.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(3555, 113, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
            EndContext();
            BeginContext(3669, 12, false);
#line 82 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                          Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(3681, 181, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            ");
            EndContext();
            BeginContext(3863, 25, false);
#line 87 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                       Write(Html.LabelFor(m => m.INN));

#line default
#line hidden
            EndContext();
            BeginContext(3888, 113, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
            EndContext();
            BeginContext(4002, 9, false);
#line 90 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                          Write(Model.INN);

#line default
#line hidden
            EndContext();
            BeginContext(4011, 181, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            ");
            EndContext();
            BeginContext(4193, 27, false);
#line 95 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                       Write(Html.LabelFor(m => m.SNILS));

#line default
#line hidden
            EndContext();
            BeginContext(4220, 113, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
            EndContext();
            BeginContext(4334, 11, false);
#line 98 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                          Write(Model.SNILS);

#line default
#line hidden
            EndContext();
            BeginContext(4345, 311, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""tab-pane fade"" id=""passport"" role=""tabpanel"" aria-labelledby=""passport-tab"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            ");
            EndContext();
            BeginContext(4657, 37, false);
#line 105 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                       Write(Html.LabelFor(m => m.Passport.Number));

#line default
#line hidden
            EndContext();
            BeginContext(4694, 113, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
            EndContext();
            BeginContext(4808, 21, false);
#line 108 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                          Write(Model.Passport.Number);

#line default
#line hidden
            EndContext();
            BeginContext(4829, 181, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            ");
            EndContext();
            BeginContext(5011, 37, false);
#line 113 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                       Write(Html.LabelFor(m => m.Passport.Series));

#line default
#line hidden
            EndContext();
            BeginContext(5048, 113, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
            EndContext();
            BeginContext(5162, 21, false);
#line 116 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                          Write(Model.Passport.Series);

#line default
#line hidden
            EndContext();
            BeginContext(5183, 181, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            ");
            EndContext();
            BeginContext(5365, 38, false);
#line 121 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                       Write(Html.LabelFor(m => m.Passport.GivenBy));

#line default
#line hidden
            EndContext();
            BeginContext(5403, 113, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
            EndContext();
            BeginContext(5517, 22, false);
#line 124 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                          Write(Model.Passport.GivenBy);

#line default
#line hidden
            EndContext();
            BeginContext(5539, 181, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            ");
            EndContext();
            BeginContext(5721, 41, false);
#line 129 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                       Write(Html.LabelFor(m => m.Passport.DateOfGive));

#line default
#line hidden
            EndContext();
            BeginContext(5762, 113, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
            EndContext();
            BeginContext(5876, 25, false);
#line 132 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                          Write(Model.Passport.DateOfGive);

#line default
#line hidden
            EndContext();
            BeginContext(5901, 181, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            ");
            EndContext();
            BeginContext(6083, 38, false);
#line 137 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                       Write(Html.LabelFor(m => m.Passport.Address));

#line default
#line hidden
            EndContext();
            BeginContext(6121, 113, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
            EndContext();
            BeginContext(6235, 22, false);
#line 140 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                          Write(Model.Passport.Address);

#line default
#line hidden
            EndContext();
            BeginContext(6257, 198, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"tab-pane fade\" id=\"education\" role=\"tabpanel\" aria-labelledby=\"education-tab\">\r\n");
            EndContext();
#line 145 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                     for (int i = 0; i < Model.Educations.Count(); i++)
                    {

#line default
#line hidden
            BeginContext(6551, 194, true);
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-md-4\">\r\n                                <div class=\"profile-img\">\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 6745, "\"", 6825, 2);
            WriteAttributeValue("", 6751, "data:image;base64,", 6751, 18, true);
#line 150 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
WriteAttributeValue("", 6769, System.Convert.ToBase64String(Model.Educations[i].File), 6769, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6826, 300, true);
            WriteLiteral(@" onclick=""imageResize(this)"" alt="""" style=""cursor: pointer;"" />
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                ");
            EndContext();
            BeginContext(7127, 43, false);
#line 156 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                           Write(Html.LabelFor(m => m.Educations[i].EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(7170, 122, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                ");
            EndContext();
            BeginContext(7293, 27, false);
#line 159 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                           Write(Model.Educations[i].EndDate);

#line default
#line hidden
            EndContext();
            BeginContext(7320, 102, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <hr />\r\n");
            EndContext();
#line 163 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                    }

#line default
#line hidden
            BeginContext(7445, 247, true);
            WriteLiteral("                </div> \r\n                <div class=\"tab-pane fade\" id=\"insurance\" role=\"tabpanel\" aria-labelledby=\"insrance-tab\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            ");
            EndContext();
            BeginContext(7693, 38, false);
#line 168 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                       Write(Html.LabelFor(m => m.Insurance.Number));

#line default
#line hidden
            EndContext();
            BeginContext(7731, 113, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
            EndContext();
            BeginContext(7845, 22, false);
#line 171 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                          Write(Model.Insurance.Number);

#line default
#line hidden
            EndContext();
            BeginContext(7867, 181, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-6\">\r\n                            ");
            EndContext();
            BeginContext(8049, 31, false);
#line 176 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                       Write(Html.LabelFor(m => m.Insurance));

#line default
#line hidden
            EndContext();
            BeginContext(8080, 113, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <p>");
            EndContext();
            BeginContext(8194, 23, false);
#line 179 "C:\Users\kudryavii\source\repos\PersonalFiles\PersonalFiles\Views\Person\Profile.cshtml"
                          Write(Model.Insurance.Company);

#line default
#line hidden
            EndContext();
            BeginContext(8217, 150, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
