#pragma checksum "/Users/umutguler/Desktop/webProgramFile/shopapp/shopapp.webui/Views/Shared/Components/Categories/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf250954e19855f1999934de21d385612beea380"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Categories_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Categories/Default.cshtml")]
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
#line 2 "/Users/umutguler/Desktop/webProgramFile/shopapp/shopapp.webui/Views/_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf250954e19855f1999934de21d385612beea380", @"/Views/Shared/Components/Categories/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40e36929c2aa37fe7760fc9338bb537f2d63676c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Categories_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"list-group\">\n\n");
#nullable restore
#line 5 "/Users/umutguler/Desktop/webProgramFile/shopapp/shopapp.webui/Views/Shared/Components/Categories/Default.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href = \"", 102, "\"", 111, 0);
            EndWriteAttribute();
            WriteLiteral(" class = \"list-group-item list-group-item-action\">");
#nullable restore
#line 7 "/Users/umutguler/Desktop/webProgramFile/shopapp/shopapp.webui/Views/Shared/Components/Categories/Default.cshtml"
                                                                 Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\n");
#nullable restore
#line 8 "/Users/umutguler/Desktop/webProgramFile/shopapp/shopapp.webui/Views/Shared/Components/Categories/Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
