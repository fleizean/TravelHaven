#pragma checksum "/Users/fleizean/Desktop/Self-Project/Asp.Net/TravelHaven/TravelHaven/Views/Shared/Components/_Statistics/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de4b7cb10c718ca33cf7f8be83abeeceae72080c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Statistics_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_Statistics/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de4b7cb10c718ca33cf7f8be83abeeceae72080c", @"/Views/Shared/Components/_Statistics/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b7dba3d5d5a462db553d5aea8fcdc155fb4a663", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__Statistics_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<section class=\"w3l-stats py-5\" id=\"stats\">\n    <div class=\"gallery-inner container py-lg-0 py-3\">\n        <div class=\"row stats-con pb-lg-3\">\n            <div class=\"col-lg-3 col-6 stats_info counter_grid\">\n                <p class=\"counter\">");
#nullable restore
#line 6 "/Users/fleizean/Desktop/Self-Project/Asp.Net/TravelHaven/TravelHaven/Views/Shared/Components/_Statistics/Default.cshtml"
                              Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <h4>Şubelerimiz</h4>\n            </div>\n            <div class=\"col-lg-3 col-6 stats_info counter_grid1\">\n                <p class=\"counter\">");
#nullable restore
#line 10 "/Users/fleizean/Desktop/Self-Project/Asp.Net/TravelHaven/TravelHaven/Views/Shared/Components/_Statistics/Default.cshtml"
                              Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <h4>Gezi Rehberleri</h4>
            </div>
            <div class=""col-lg-3 col-6 stats_info counter_grid mt-lg-0 mt-5"">
                <p class=""counter"">812</p>
                <h4>Mutlu Müşteri</h4>
            </div>
            <div class=""col-lg-3 col-6 stats_info counter_grid2 mt-lg-0 mt-5"">
                <p class=""counter"">990</p>
                <h4>Ödüller</h4>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
