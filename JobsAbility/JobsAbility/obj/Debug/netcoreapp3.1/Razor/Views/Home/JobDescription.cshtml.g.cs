#pragma checksum "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\JobDescription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "611018fd370feab74827623441c01ddce635b9f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_JobDescription), @"mvc.1.0.view", @"/Views/Home/JobDescription.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611018fd370feab74827623441c01ddce635b9f8", @"/Views/Home/JobDescription.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fa88f134bf6e06f6ae69a843a87321cdb56d06e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_JobDescription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobsAbility.Models.JobDescriptionDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\JobDescription.cshtml"
  
    ViewData["Title"] = "JobDescription";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-xs-12"">
                <div class=""breadcrumb-wrapper"">

                    <div class=""content"">
                        <h3 class=""product-title"">");
#nullable restore
#line 13 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\JobDescription.cshtml"
                                             Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"brand\">");
#nullable restore
#line 14 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\JobDescription.cshtml"
                                    Write(Model.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <div class=\"tags\"><span><i class=\"lni-calendar\"></i>Posted ");
#nullable restore
#line 15 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\JobDescription.cshtml"
                                                                              Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>
<section class=""job-detail section"">
    <div class=""container"">
        <div class=""row justify-content-between"">
            <div class=""col-lg-8 col-md-12 col-xs-12"">
                <div class=""content-area"">
                    ");
#nullable restore
#line 28 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\JobDescription.cshtml"
               Write(Html.Raw(Model.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\JobDescription.cshtml"
                     using (Html.BeginForm("Apply", "home", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input name=\"id\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1101, "\"", 1118, 1);
#nullable restore
#line 31 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\JobDescription.cshtml"
WriteAttributeValue("", 1109, Model.Id, 1109, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                        <button type=\"submit\" class=\"btn btn-common\">Apply job</button>\r\n");
#nullable restore
#line 33 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\JobDescription.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
            <div class=""col-lg-4 col-md-12 col-xs-12"">
                <div class=""sideber"">
                    <div class=""widghet"">
                        <h3>Job Location</h3>
                        <div class=""maps"">
                            <div id=""map"" class=""map-full"">
                                <iframe");
            BeginWriteAttribute("src", " src=\"", 1608, "\"", 1633, 1);
#nullable restore
#line 42 "C:\awsTeckathon\JobsAbility\JobsAbility\JobsAbility\Views\Home\JobDescription.cshtml"
WriteAttributeValue("", 1614, Model.LocationLink, 1614, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1634, "\"", 1652, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section id=""featured"" class=""section bg-gray pb-45"">
    <div class=""container"">
        <h4 class=""small-title text-left"">Similar Jobs</h4>
        <div class=""row"">
            <div class=""col-lg-4 col-md-6 col-xs-12"">
                <div class=""job-featured"">
                   
                    <div class=""content"">
                        <h3><a href=""#"">Software Engineer</a></h3>
                        <p class=""brand"">MizTech</p>
                        <div class=""tags""><span><i class=""lni-map-marker""></i>New York</span><span><i class=""lni-user""></i>John Smith</span></div><span class=""full-time"">Full Time</span>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 col-xs-12"">
                <div class=""job-featured"">
                ");
            WriteLiteral(@"   
                    <div class=""content"">
                        <h3><a href=""#"">Graphic Designer</a></h3>
                        <p class=""brand"">Hunter Inc.</p>
                        <div class=""tags""><span><i class=""lni-map-marker""></i>New York</span><span><i class=""lni-user""></i>John Smith</span></div><span class=""part-time"">Part Time</span>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 col-xs-12"">
                <div class=""job-featured"">
                  
                    <div class=""content"">
                        <h3><a href=""#"">Managing Director</a></h3>
                        <p class=""brand"">MagNews</p>
                        <div class=""tags""><span><i class=""lni-map-marker""></i>New York</span><span><i class=""lni-user""></i>John Smith</span></div><span class=""full-time"">Full Time</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobsAbility.Models.JobDescriptionDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
