#pragma checksum "C:\Users\e.stultjens\source\repos\FirstMVC\Exo1-Route\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f5da8d67399f8b063af6ed0075effb5901b4e38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\e.stultjens\source\repos\FirstMVC\Exo1-Route\Views\_ViewImports.cshtml"
using Exo1_Route;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\e.stultjens\source\repos\FirstMVC\Exo1-Route\Views\_ViewImports.cshtml"
using Exo1_Route.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\e.stultjens\source\repos\FirstMVC\Exo1-Route\Views\Product\Index.cshtml"
using Exo1_Route.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f5da8d67399f8b063af6ed0075effb5901b4e38", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67387a02d84ae61c6699c02642a49f5bf4e60a0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\e.stultjens\source\repos\FirstMVC\Exo1-Route\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Shopping";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\Users\e.stultjens\source\repos\FirstMVC\Exo1-Route\Views\Product\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(", faîtes votre choix!</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\e.stultjens\source\repos\FirstMVC\Exo1-Route\Views\Product\Index.cshtml"
  
    int count = Model.Products.Count;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\e.stultjens\source\repos\FirstMVC\Exo1-Route\Views\Product\Index.cshtml"
 if (count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 17 "C:\Users\e.stultjens\source\repos\FirstMVC\Exo1-Route\Views\Product\Index.cshtml"
         foreach (Product product in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 19 "C:\Users\e.stultjens\source\repos\FirstMVC\Exo1-Route\Views\Product\Index.cshtml"
           Write(product.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" coute ");
#nullable restore
#line 19 "C:\Users\e.stultjens\source\repos\FirstMVC\Exo1-Route\Views\Product\Index.cshtml"
                              Write(product.Prix);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (stock disponible = ");
#nullable restore
#line 19 "C:\Users\e.stultjens\source\repos\FirstMVC\Exo1-Route\Views\Product\Index.cshtml"
                                                                Write(product.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</li>\r\n");
#nullable restore
#line 20 "C:\Users\e.stultjens\source\repos\FirstMVC\Exo1-Route\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>Nombre de produit affiche = ");
#nullable restore
#line 21 "C:\Users\e.stultjens\source\repos\FirstMVC\Exo1-Route\Views\Product\Index.cshtml"
                                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n");
#nullable restore
#line 23 "C:\Users\e.stultjens\source\repos\FirstMVC\Exo1-Route\Views\Product\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
