#pragma checksum "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 20\09_Fim\LojaVirtual\Views\Error\Error500.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb044d4127fff188c851f51c374fca0d5306c626"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_Error500), @"mvc.1.0.view", @"/Views/Error/Error500.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Error/Error500.cshtml", typeof(AspNetCore.Views_Error_Error500))]
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
#line 3 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 20\09_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 4 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 20\09_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 20\09_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 20\09_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#line 7 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 20\09_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels.Components;

#line default
#line hidden
#line 8 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 20\09_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 9 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 20\09_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Contants;

#line default
#line hidden
#line 10 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 20\09_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb044d4127fff188c851f51c374fca0d5306c626", @"/Views/Error/Error500.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2cd83e19214e30239a18602a7f0fd276d947335", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_Error500 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 20\09_Fim\LojaVirtual\Views\Error\Error500.cshtml"
  
    ViewData["Title"] = "Error500";

#line default
#line hidden
            BeginContext(46, 159, true);
            WriteLiteral("<br />\r\n<br />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <h1>Error 500</h1>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(206, 16, false);
#line 12 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 20\09_Fim\LojaVirtual\Views\Error\Error500.cshtml"
           Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(222, 60, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
