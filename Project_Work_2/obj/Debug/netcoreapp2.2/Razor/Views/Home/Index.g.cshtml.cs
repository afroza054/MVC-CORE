#pragma checksum "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa9749abef74aa529a4bd09a9163c43d2982d602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa9749abef74aa529a4bd09a9163c43d2982d602", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b01dd045a240dfc6642ab535d85a5c4813d8c72", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 508, true);
            WriteLiteral(@"
<div style=""background-color:lightskyblue; text-align:center;"">
    
    
        <h5 class=""display-2"">Online Job Site</h5>
        <p>
            Online job site will help you to find out suitable job with in a moment.
        </p>
   

    <div class=""row"">
        <div class=""card mr-2  mb-1  offset-2"" style=""min-width: 10rem;"">
            <div class=""card-body"">
                <h4 class=""card-title"">Online Job Site</h4>
                <div class=""card-text"">
                    ");
            EndContext();
            BeginContext(552, 94, false);
#line 20 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Table 1", "Index", "OnlineJobSite", new { }, new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(646, 288, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""card mr-2  mb-1"" style=""min-width: 10rem;"">
            <div class=""card-body"">
                <h4 class=""card-title"">Job Advertisement</h4>
                <div class=""card-text"">
                    ");
            EndContext();
            BeginContext(935, 100, false);
#line 28 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Table 2", "Index", "JobAdvertisement", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 284, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""card mr-2  mb-1"" style=""min-width: 10rem;"">
            <div class=""card-body"">
                <h4 class=""card-title"">Job Applicant</h4>
                <div class=""card-text"">
                    ");
            EndContext();
            BeginContext(1320, 96, false);
#line 36 "E:\Module_7_MVC_Entity\Project_joma_Core\EE_Coreproj_1255708\Project_Works\Project_Work_2\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Table 3", "Index", "JobApplicant", new { }, new { @class = "btn btn-warning" }));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 455, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""card mr-2  mb-1"" style=""min-width: 10rem;"">
            <div class=""card-body"">
                <h4 class=""card-title"">Apply For A Online Job</h4>
                <div class=""card-text"">
                    <a href=""https://www.youtube.com/watch?v=ZOdVNSh_9Mk"">You Tube Video</a>
                </div>
            </div>
        </div>

    </div>

</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
