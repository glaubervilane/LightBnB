#pragma checksum "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a53aef330a5469c37cf26e44dcacd204caf229c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Visualizar.cshtml", typeof(AspNetCore.Views_Produto_Visualizar))]
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
#line 3 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 4 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a53aef330a5469c37cf26e44dcacd204caf229c", @"/Views/Produto/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c8e441a1ad085f94e3a56d46d99a0c2d222558b", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.Produto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/imagem-produto.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/imagem-produto.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 417, true);
            WriteLiteral(@"
<br style=""clear: both"" />
<div class=""container"">

    <section id=""product_detail"">
        <div id=""code_prod_detail"">
            <div class=""card"">
                <div class=""row no-gutters"">
                    <aside class=""col-sm-5 border-right"">
                        <article class=""gallery-wrap"">
                            <div class=""img-big-wrap"">
                                <div>
");
            EndContext();
#line 14 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                     if (Model.Imagens != null && Model.Imagens.Count > 0)
                                    {

#line default
#line hidden
            BeginContext(583, 42, true);
            WriteLiteral("                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 625, "\"", 667, 1);
#line 16 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 632, Model.Imagens.ElementAt(0).Caminho, 632, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(668, 19, true);
            WriteLiteral(" data-fancybox><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 687, "\"", 728, 1);
#line 16 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 693, Model.Imagens.ElementAt(0).Caminho, 693, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(729, 7, true);
            WriteLiteral("></a>\r\n");
            EndContext();
#line 17 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(856, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(896, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a53aef330a5469c37cf26e44dcacd204caf229c6724", async() => {
                BeginContext(945, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6a53aef330a5469c37cf26e44dcacd204caf229c6987", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-fancybox", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(985, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1026, 161, true);
            WriteLiteral("                                </div>\r\n                            </div> <!-- slider-product.// -->\r\n                            <div class=\"img-small-wrap\">\r\n");
            EndContext();
#line 25 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                 if (Model.Imagens != null && Model.Imagens.Count > 0)
                                {
                                    foreach (Imagem imagem in Model.Imagens)
                                    {

#line default
#line hidden
            BeginContext(1427, 71, true);
            WriteLiteral("                                        <div class=\"item-gallery\"> <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1498, "\"", 1519, 1);
#line 29 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 1504, imagem.Caminho, 1504, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1520, 9, true);
            WriteLiteral("></div>\r\n");
            EndContext();
#line 30 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(1603, 298, true);
            WriteLiteral(@"                            </div> <!-- slider-nav.// -->
                        </article> <!-- gallery-wrap .end// -->
                    </aside>
                    <aside class=""col-sm-7"">
                        <article class=""p-5"">
                            <h3 class=""title mb-3"">");
            EndContext();
            BeginContext(1902, 10, false);
#line 37 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                              Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1912, 178, true);
            WriteLiteral("</h3>\r\n                            <div class=\"mb-3\">\r\n                                <var class=\"price h3 text-warning\">\r\n                                    <span class=\"num\">");
            EndContext();
            BeginContext(2091, 25, false);
#line 40 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                 Write(Model.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2116, 373, true);
            WriteLiteral(@"</span>
                                </var>
                                <span>/unid</span>
                            </div> <!-- price-detail-wrap .// -->
                            <dl>
                                <dt>Descrição</dt>
                                <dd>
                                    <p>
                                        ");
            EndContext();
            BeginContext(2490, 15, false);
#line 48 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                   Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(2505, 285, true);
            WriteLiteral(@"
                                    </p>
                                </dd>
                            </dl>
                            <dl class=""row"">
                                <dt class=""col-sm-3"">Peso(kg)</dt>
                                <dd class=""col-sm-9"">");
            EndContext();
            BeginContext(2791, 10, false);
#line 54 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Peso);

#line default
#line hidden
            EndContext();
            BeginContext(2801, 127, true);
            WriteLiteral("</dd>\r\n                                <dt class=\"col-sm-3\">Largura</dt>\r\n                                <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(2929, 13, false);
#line 56 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Largura);

#line default
#line hidden
            EndContext();
            BeginContext(2942, 126, true);
            WriteLiteral("</dd>\r\n                                <dt class=\"col-sm-3\">Altura</dt>\r\n                                <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(3069, 12, false);
#line 58 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Altura);

#line default
#line hidden
            EndContext();
            BeginContext(3081, 131, true);
            WriteLiteral("</dd>\r\n                                <dt class=\"col-sm-3\">Comprimento</dt>\r\n                                <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(3213, 17, false);
#line 60 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Comprimento);

#line default
#line hidden
            EndContext();
            BeginContext(3230, 141, true);
            WriteLiteral("</dd>\r\n                                <dt class=\"col-sm-3\">Quantidade em estoque</dt>\r\n                                <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(3372, 16, false);
#line 62 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\07_Fim\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(3388, 508, true);
            WriteLiteral(@"</dd>
                            </dl>
                            <hr>
                            <div class=""row"">
                                <div class=""col-sm-5"">
                                    <dl class=""dlist-inline"">
                                        <dt>Quantity: </dt>
                                        <dd>
                                            <select class=""form-control form-control-sm"" style=""width:70px;"">
                                                ");
            EndContext();
            BeginContext(3896, 20, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a53aef330a5469c37cf26e44dcacd204caf229c16523", async() => {
                BeginContext(3904, 3, true);
                WriteLiteral(" 1 ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3916, 50, true);
            WriteLiteral("\r\n                                                ");
            EndContext();
            BeginContext(3966, 20, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a53aef330a5469c37cf26e44dcacd204caf229c17745", async() => {
                BeginContext(3974, 3, true);
                WriteLiteral(" 2 ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3986, 50, true);
            WriteLiteral("\r\n                                                ");
            EndContext();
            BeginContext(4036, 20, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a53aef330a5469c37cf26e44dcacd204caf229c18967", async() => {
                BeginContext(4044, 3, true);
                WriteLiteral(" 3 ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4056, 697, true);
            WriteLiteral(@"
                                            </select>
                                        </dd>
                                    </dl>  <!-- item-property .// -->
                                </div> <!-- col.// -->
                            </div> <!-- row.// -->
                            <hr>
                            <a href=""#"" class=""btn  btn-outline-primary""> <i class=""fas fa-shopping-cart""></i> Adicionar ao Carrinho </a>
                        </article> <!-- card-body.// -->
                    </aside> <!-- col.// -->
                </div> <!-- row.// -->
            </div> <!-- card.// -->
        </div> <!-- code-wrap.// -->
    </section>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
