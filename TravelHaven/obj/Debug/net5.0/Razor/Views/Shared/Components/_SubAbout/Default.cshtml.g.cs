#pragma checksum "/Users/fleizean/Desktop/Self-Project/Asp.Net/TravelHaven/TravelHaven/Views/Shared/Components/_SubAbout/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a95f779907c900bc3b56fd36c0dab7b64c617653"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__SubAbout_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_SubAbout/Default.cshtml")]
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
#line 1 "/Users/fleizean/Desktop/Self-Project/Asp.Net/TravelHaven/TravelHaven/Views/_ViewImports.cshtml"
using TravelHaven;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/fleizean/Desktop/Self-Project/Asp.Net/TravelHaven/TravelHaven/Views/_ViewImports.cshtml"
using TravelHaven.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/fleizean/Desktop/Self-Project/Asp.Net/TravelHaven/TravelHaven/Views/Shared/Components/_SubAbout/Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a95f779907c900bc3b56fd36c0dab7b64c617653", @"/Views/Shared/Components/_SubAbout/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b7dba3d5d5a462db553d5aea8fcdc155fb4a663", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__SubAbout_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SubAbout>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <section class=""w3l-bottom py-5"">
        <div class=""container py-md-4 py-3 text-center"">
            <div class=""row my-lg-4 mt-4"">
                <div class=""col-lg-9 col-md-10 ml-auto"">
                    <div class=""bottom-info ml-auto"">
                        <div class=""header-section text-left"">
                            <h3 class=""hny-title two"">");
#nullable restore
#line 10 "/Users/fleizean/Desktop/Self-Project/Asp.Net/TravelHaven/TravelHaven/Views/Shared/Components/_SubAbout/Default.cshtml"
                                                 Write(Model[0].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            <p class=\"mt-3 pr-lg-5\">\n                                ");
#nullable restore
#line 12 "/Users/fleizean/Desktop/Self-Project/Asp.Net/TravelHaven/TravelHaven/Views/Shared/Components/_SubAbout/Default.cshtml"
                           Write(Model[0].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                            <a href=""about.html"" class=""btn btn-style btn-secondary mt-5"">Devamını Oku</a>
                        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SubAbout>> Html { get; private set; }
    }
}
#pragma warning restore 1591
