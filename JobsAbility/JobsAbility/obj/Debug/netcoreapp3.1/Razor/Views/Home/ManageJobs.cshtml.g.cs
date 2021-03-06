#pragma checksum "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\ManageJobs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5fe1d593f130a668789386c903322989bf7d8c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ManageJobs), @"mvc.1.0.view", @"/Views/Home/ManageJobs.cshtml")]
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
#nullable restore
#line 1 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\_ViewImports.cshtml"
using JobsAbility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\_ViewImports.cshtml"
using JobsAbility.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5fe1d593f130a668789386c903322989bf7d8c7", @"/Views/Home/ManageJobs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fa88f134bf6e06f6ae69a843a87321cdb56d06e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ManageJobs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobsAbility.Models.ManageJobDTO>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\ManageJobs.cshtml"
  
    ViewData["Title"] = "ManageJobs";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-header"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""inner-header"">
                    <h3>Manage Jobs</h3>
                </div>
            </div>
        </div>
    </div>
</div>
<div id=""content"">
    <div class=""container"">
        <div class=""row"">

            <div class=""col-lg-12 col-md-12 col-xs-12"">
                <div class=""job-alerts-item candidates text-center"">
                    <h3 class=""alerts-title text-left"">Manage Jobs</h3>
                    <div class=""alerts-list"">
                        <div class=""row"">
                            <div class=""col-lg-4 col-md-3 col-xs-12 text-center"">
                                <p class=""manageHeader"">Job Title</p>
                            </div>
                            <div class=""col-lg-2 col-md-3 col-xs-12"">
                                <p class=""manageHeader"">Status</p>
                            </div>
     ");
            WriteLiteral(@"                       <div class=""col-lg-2 col-md-3 col-xs-12"">
                                <p class=""manageHeader""># Applications</p>
                            </div>
                            <div class=""col-lg-4 col-md-3 col-xs-12"">
                                <p class=""manageHeader"">Options</p>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 39 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\ManageJobs.cshtml"
                     foreach (var jobPost in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alerts-content\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-lg-4 col-md-5 col-xs-12 text-center\">\r\n                                    <h3>");
#nullable restore
#line 44 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\ManageJobs.cshtml"
                                   Write(jobPost.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                </div>\r\n\r\n                                <div class=\"col-lg-2 col-md-2 col-xs-12\">\r\n                                    <p>");
#nullable restore
#line 48 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\ManageJobs.cshtml"
                                  Write(jobPost.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                                <div class=\"col-lg-2 col-md-2 col-xs-12\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5fe1d593f130a668789386c903322989bf7d8c76200", async() => {
                WriteLiteral("<p>");
#nullable restore
#line 51 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\ManageJobs.cshtml"
                                                                             Write(jobPost.NoApp);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2192, "~/home/Applicants?id=", 2192, 21, true);
#nullable restore
#line 51 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\ManageJobs.cshtml"
AddHtmlAttributeValue("", 2213, jobPost.Id, 2213, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-lg-4 col-md-2 col-xs-12\">\r\n                                    <p class=\"d-inline\"><a");
            BeginWriteAttribute("href", " href=\"", 2426, "\"", 2468, 2);
            WriteAttributeValue("", 2433, "/home/JobDescription?id=", 2433, 24, true);
#nullable restore
#line 54 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\ManageJobs.cshtml"
WriteAttributeValue("", 2457, jobPost.Id, 2457, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"full-time\"><i class=\"lni lni-eye\"></i></a></p>\r\n                                    <p class=\"d-inline\"><a");
            BeginWriteAttribute("href", " href=\"", 2583, "\"", 2590, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"full-time\"><i class=\"lni lni-pencil\"></i></a></p>\r\n                                    <p class=\"d-inline\"><a");
            BeginWriteAttribute("href", " href=\"", 2708, "\"", 2715, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"part-time\"><i class=\"lni lni-trash\"></i></a></p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 60 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\ManageJobs.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <br>
                    <ul class=""pagination justify-content-center"">
                        <li class=""active""><a href=""#"" class=""btn-prev""><i class=""lni-angle-left""></i>prev</a></li>
                        <li><a href=""#"">1</a></li>
                        <li><a href=""#"">2</a></li>
                        <li><a href=""#"">3</a></li>
                        <li><a href=""#"">4</a></li>
                        <li><a href=""#"">5</a></li>
                        <li class=""active""><a href=""#"" class=""btn-next"">Next <i class=""lni-angle-right""></i></a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<JobsAbility.Models.ManageJobDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
