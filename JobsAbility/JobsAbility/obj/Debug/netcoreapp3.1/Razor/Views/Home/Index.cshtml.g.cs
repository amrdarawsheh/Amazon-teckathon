#pragma checksum "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2a44d6d90fb866e7793f105122a09eeb1535247"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2a44d6d90fb866e7793f105122a09eeb1535247", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fa88f134bf6e06f6ae69a843a87321cdb56d06e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/intro.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""hero-area"">

    <div class=""container p-0"">
        <div class=""row space-100"">
            <div class=""col-lg-7 col-md-12 col-xs-12"">
                <div class=""contents"">
                    <h2 class=""head-title"">Find the job that fits your life</h2>
                    <p>Aliquam vestibulum cursus felis. In iaculis iaculis sapien ac condimentum. Vestibulum congue posuere lacus, id tincidunt nisi porta sit amet. Suspendisse et sapien varius, pellentesque dui non.</p>
                </div>
            </div>
            
            <div class=""col-lg-5 col-md-12 col-xs-12"">
                <div class=""intro-img"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c2a44d6d90fb866e7793f105122a09eeb15352474637", async() => {
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
            WriteLiteral(@"</div>
            </div>
        </div>
    </div>
</div>
<section class=""category section bg-gray"">
    <div class=""container"">
        <div class=""section-header"">
            <h2 class=""section-title"">Browse Categories</h2>
            <p>Most popular categories of portal, sorted by popularity</p>
        </div>
        <div class=""row"">
            <div class=""col-lg-3 col-md-6 col-xs-12 f-category"">
                <a href=""browse-jobs.html"">
                    <div class=""icon bg-color-1""><i class=""lni-home""></i></div>
                    <h3>Finance</h3>
                    <p>(4286 jobs)</p>
                </a>
            </div>
            <div class=""col-lg-3 col-md-6 col-xs-12 f-category"">
                <a href=""browse-jobs.html"">
                    <div class=""icon bg-color-2""><i class=""lni-world""></i></div>
                    <h3>Sale/Markting</h3>
                    <p>(2000 jobs)</p>
                </a>
            </div>
            <div class=""col-lg-3 col-");
            WriteLiteral(@"md-6 col-xs-12 f-category"">
                <a href=""browse-jobs.html"">
                    <div class=""icon bg-color-3""><i class=""lni-book""></i></div>
                    <h3>Education/Training</h3>
                    <p>(1450 jobs)</p>
                </a>
            </div>
            <div class=""col-lg-3 col-md-6 col-xs-12 f-category"">
                <a href=""browse-jobs.html"">
                    <div class=""icon bg-color-4""><i class=""lni-display""></i></div>
                    <h3>Technologies</h3>
                    <p>(5100 jobs)</p>
                </a>
            </div>
            <div class=""col-lg-3 col-md-6 col-xs-12 f-category"">
                <a href=""browse-jobs.html"">
                    <div class=""icon bg-color-5""><i class=""lni-brush""></i></div>
                    <h3>Art/Design</h3>
                    <p>(5079 jobs)</p>
                </a>
            </div>
            <div class=""col-lg-3 col-md-6 col-xs-12 f-category"">
                <a href=""browse-jobs");
            WriteLiteral(@".html"">
                    <div class=""icon bg-color-6""><i class=""lni-heart""></i></div>
                    <h3>Healthcare</h3>
                    <p>(3235 jobs)</p>
                </a>
            </div>
            <div class=""col-lg-3 col-md-6 col-xs-12 f-category"">
                <a href=""browse-jobs.html"">
                    <div class=""icon bg-color-7""><i class=""lni lni-microscope""></i></div>
                    <h3>Science</h3>
                    <p>(1800 jobs)</p>
                </a>
            </div>
            <div class=""col-lg-3 col-md-6 col-xs-12 f-category"">
                <a href=""browse-jobs.html"">
                    <div class=""icon bg-color-8""><i class=""lni lni-dinner""></i></div>
                    <h3>Food Services</h3>
                    <p>(4286 jobs)</p>
                </a>
            </div>
        </div>
    </div>
</section>
<section class=""how-it-works section"">
    <div class=""container"">
        <div class=""section-header"">
            <h2 c");
            WriteLiteral("lass=\"section-title\">How It Works?</h2>\r\n");
            WriteLiteral(@"        </div>
        <div class=""row"">
            <div class=""col-lg-4 col-md-4 col-sm-6 col-xs-12"">
                <div class=""work-process"">
                    <span class=""process-icon""><i class=""lni-user""></i></span>
                    <h4>Create an Account</h4>
                    <p>Post a job to tell us about your project. We'll quickly match you with the right freelancers find place best.</p>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6 col-xs-12"">
                <div class=""work-process step-2"">
                    <span class=""process-icon""><i class=""lni-search""></i></span>
                    <h4>Search Jobs</h4>
                    <p>Post a job to tell us about your project. We'll quickly match you with the right freelancers find place best.</p>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6 col-xs-12"">
                <div class=""work-process step-3"">
                    <span c");
            WriteLiteral(@"lass=""process-icon""><i class=""lni-cup""></i></span>
                    <h4>Apply</h4>
                    <p>Post a job to tell us about your project. We'll quickly match you with the right freelancers find place best.</p>
                </div>
            </div>
        </div>
    </div>
</section>");
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
