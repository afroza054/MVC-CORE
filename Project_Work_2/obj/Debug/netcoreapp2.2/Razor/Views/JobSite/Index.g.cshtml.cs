#pragma checksum "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15fac465d0ef0cb6fc78e7cb88ce527941905327"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobSite_Index), @"mvc.1.0.view", @"/Views/JobSite/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JobSite/Index.cshtml", typeof(AspNetCore.Views_JobSite_Index))]
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
#line 2 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\_ViewImports.cshtml"
using Project_Work_2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15fac465d0ef0cb6fc78e7cb88ce527941905327", @"/Views/JobSite/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b01dd045a240dfc6642ab535d85a5c4813d8c72", @"/Views/_ViewImports.cshtml")]
    public class Views_JobSite_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineJobSite>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/font/css/font-awesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(76, 138, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n  \r\n    <div class=\"card-body\">\r\n        \r\n        <h4 class=\"card-title\">JobSite & Advertisement & Applicant</h4>\r\n");
            EndContext();
            BeginContext(436, 576, true);
            WriteLiteral(@"
    </div>
</div>
<div class=""card-text"">
    <table class=""table table-bordered table-success"">
        <thead class=""thead-light"">
            <tr>
                <th style=""width:50px"">
                    <button type=""button"" class=""btn btn-sm all""><span class=""fa fa-plus""></span></button>
                </th>
                <th>Job Site ID</th>
                <th>Job Site Name</th>
                <th>Started Journey</th>
                <th>Response Instantly</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 33 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1069, 153, true);
            WriteLiteral("                <tr>\r\n                    <td style=\"width:50px\">\r\n                        <button type=\"button\" class=\"btn btn-sm trade\" data-trade-pk=\"");
            EndContext();
            BeginContext(1223, 20, false);
#line 37 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
                                                                                 Write(item.OnlineJobSiteId);

#line default
#line hidden
            EndContext();
            BeginContext(1243, 103, true);
            WriteLiteral("\"><span class=\"fa fa-plus-square\"></span></button>\r\n                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(1347, 20, false);
#line 39 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
                   Write(item.OnlineJobSiteId);

#line default
#line hidden
            EndContext();
            BeginContext(1367, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1399, 22, false);
#line 40 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
                   Write(item.OnlineJobSiteName);

#line default
#line hidden
            EndContext();
            BeginContext(1421, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1453, 42, false);
#line 41 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
                   Write(item.StartedJourney.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1528, 23, false);
#line 42 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
                    Write(item.Web ? "Yes" : "No");

#line default
#line hidden
            EndContext();
            BeginContext(1552, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(1975, 64, true);
            WriteLiteral("                </tr>\r\n                <tr style=\"display: none\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2039, "\"", 2071, 2);
            WriteAttributeValue("", 2044, "trade-", 2044, 6, true);
#line 48 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
WriteAttributeValue("", 2050, item.OnlineJobSiteId, 2050, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2072, 597, true);
            WriteLiteral(@" class=""child-row"">
                    <td></td>
                    <td colspan=""4"">
                        <table class=""table table-bordered table-warning"">
                            <thead class=""thead-light"">
                                <tr>
                                    <th style=""width:50px"">

                                    </th>
                                    <th>Job Type</th>
                                    <th>Responsibility</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 62 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
                                 foreach (var child in item.JobAdvertisements)
                                {

#line default
#line hidden
            BeginContext(2784, 196, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            <button type=\"button\" class=\"btn btn-sm course\" data-course-pk=\"");
            EndContext();
            BeginContext(2981, 24, false);
#line 66 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
                                                                                                       Write(child.JobAdvertisementId);

#line default
#line hidden
            EndContext();
            BeginContext(3005, 143, true);
            WriteLiteral("\"><span class=\"fa fa-plus-square\"></span></button>\r\n                                        </td>\r\n                                        <td>");
            EndContext();
            BeginContext(3149, 17, false);
#line 68 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
                                       Write(child.JobTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(3166, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3218, 20, false);
#line 69 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
                                       Write(child.Responsibility);

#line default
#line hidden
            EndContext();
            BeginContext(3238, 113, true);
            WriteLiteral("</td>\r\n\r\n                                    </tr>\r\n                                    <tr style=\"display:none;\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3351, "\"", 3388, 2);
            WriteAttributeValue("", 3356, "course-", 3356, 7, true);
#line 72 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
WriteAttributeValue("", 3363, child.JobAdvertisementId, 3363, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3389, 706, true);
            WriteLiteral(@" class=""child-row"">
                                        <td>&nbsp;</td>
                                        <td colspan=""2"">
                                            <table class=""table table-bordered table-primary"">
                                                <thead class=""thead-light"">
                                                    <tr>

                                                        <th>Applicant name</th>
                                                        <th>Contact Email</th>

                                                    </tr>
                                                </thead>
                                                <tbody>
");
            EndContext();
#line 85 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
                                                     foreach (var grand in child.JobApplicants)
                                                    {

#line default
#line hidden
            BeginContext(4247, 128, true);
            WriteLiteral("                                                        <tr>\r\n\r\n                                                            <td>");
            EndContext();
            BeginContext(4376, 22, false);
#line 89 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
                                                           Write(grand.JobApplicantName);

#line default
#line hidden
            EndContext();
            BeginContext(4398, 73, true);
            WriteLiteral("</td>\r\n                                                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4471, "\"", 4504, 2);
            WriteAttributeValue("", 4478, "mailto:", 4478, 7, true);
#line 90 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
WriteAttributeValue("", 4485, grand.ContactEmail, 4485, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4505, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4507, 18, false);
#line 90 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
                                                                                                Write(grand.ContactEmail);

#line default
#line hidden
            EndContext();
            BeginContext(4525, 11, true);
            WriteLiteral("</a></td>\r\n");
            EndContext();
            BeginContext(4645, 63, true);
            WriteLiteral("                                                        </tr>\r\n");
            EndContext();
#line 93 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(4763, 202, true);
            WriteLiteral("                                                </tbody>\r\n                                            </table>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 98 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(5000, 122, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 103 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\JobSite\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(5137, 50, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(5203, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5209, 1710, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15fac465d0ef0cb6fc78e7cb88ce52794190532716424", async() => {
                    BeginContext(5244, 12, true);
                    WriteLiteral("\r\n\r\n        ");
                    EndContext();
                    BeginContext(5256, 65, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "15fac465d0ef0cb6fc78e7cb88ce52794190532716848", async() => {
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
                    BeginContext(5321, 1584, true);
                    WriteLiteral(@"
        <script>
            $(document).ready(() => {
                $(""button.trade"").click(function () {
                    var id = $(this).data(""trade-pk"");
                    $(""#trade-"" + id).toggle();
                    $(this).find(""span"").toggleClass(""fa-plus-square fa-minus-square"");
                });
                $(""button.course"").click(function () {
                    var id = $(this).data(""course-pk"");
                    $(""#course-"" + id).toggle();
                    $(this).find(""span"").toggleClass(""fa-plus-square fa-minus-square"");
                });
                $(""button.all"").click(function () {
                    if ($(this).find(""span"").hasClass(""fa-plus"")) {
                        $(""tr.child-row"").show();
                        $(""button.course span"")
                            .removeClass(""fa-plus-square"")
                            .addClass(""fa-minus-square"");
                        $(""button.trade span"")
                            .remo");
                    WriteLiteral(@"veClass(""fa-plus-square"")
                            .addClass(""fa-minus-square"");
                    }
                    else {
                        $(""tr.child-row"").hide();
                        $(""button.course span"").removeClass(""fa-minus-square"").addClass(""fa-plus-square"");
                        $(""button.trade span"").removeClass(""fa-minus-square"").addClass(""fa-plus-square"");
                    }
                    $(this).find(""span"").toggleClass(""fa-plus fa-minus"");
                })
            })
        </script>
    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6919, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(6924, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineJobSite>> Html { get; private set; }
    }
}
#pragma warning restore 1591
