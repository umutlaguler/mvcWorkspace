#pragma checksum "/Users/umutguler/Desktop/webProgramFile/mvcWorkspace/Views/Product/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "389a4690b713f034518f0e4929dd98eb3c888ba5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 2 "/Users/umutguler/Desktop/webProgramFile/mvcWorkspace/Views/_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"389a4690b713f034518f0e4929dd98eb3c888ba5", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40e36929c2aa37fe7760fc9338bb537f2d63676c", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/umutguler/Desktop/webProgramFile/mvcWorkspace/Views/Product/List.cshtml"
  
    var popularClass = Model.Products.Count>3? "popular":"";
    var products = Model.Products;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 9 "/Users/umutguler/Desktop/webProgramFile/mvcWorkspace/Views/Product/List.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n   ");
            }
            );
#nullable restore
#line 11 "/Users/umutguler/Desktop/webProgramFile/mvcWorkspace/Views/Product/List.cshtml"
 if(Model.Products.Count == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class = \"row\">\n        <div class=\"col-md-12\">\n            <div class=\"alert alert-danger\">\n                Ürün Bulunmamaktadır\n            </div>\n       </div>\n    </div>\n");
#nullable restore
#line 19 "/Users/umutguler/Desktop/webProgramFile/mvcWorkspace/Views/Product/List.cshtml"
}else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">  \n");
#nullable restore
#line 21 "/Users/umutguler/Desktop/webProgramFile/mvcWorkspace/Views/Product/List.cshtml"
         foreach (var product in Model.Products)
        {      

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class = ""col-md-3"">
            <div class = ""card"">
                <img class = ""card-img-top"" src=""https://images.hepsiburada.net/assets/Telefon/ProductDesc/iphone7-açıklama-apple-yeni.jpg"" alt=""photo of phone"">
                <div class = ""card-body"">
                    <h5 class=""card-title"">");
#nullable restore
#line 27 "/Users/umutguler/Desktop/webProgramFile/mvcWorkspace/Views/Product/List.cshtml"
                                      Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <p class=\"card-text\">");
#nullable restore
#line 28 "/Users/umutguler/Desktop/webProgramFile/mvcWorkspace/Views/Product/List.cshtml"
                                    Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 930, "\"", 937, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">İncele</a>\n                </div>\n            </div>  \n        </div> \n");
#nullable restore
#line 33 "/Users/umutguler/Desktop/webProgramFile/mvcWorkspace/Views/Product/List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div> \n");
#nullable restore
#line 35 "/Users/umutguler/Desktop/webProgramFile/mvcWorkspace/Views/Product/List.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
