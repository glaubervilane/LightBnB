#pragma checksum "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f74047ff45776ae27f9ffe53c27fe66aeadebbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
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
#line 3 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Contants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f74047ff45776ae27f9ffe53c27fe66aeadebbb", @"/Views/Produto/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2cd83e19214e30239a18602a7f0fd276d947335", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.ProdutoAgregador.Produto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/imagem-produto.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/imagem-produto.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CarrinhoCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdicionarItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
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
#nullable restore
#line 14 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                     if (Model.Imagens != null && Model.Imagens.Count > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 642, "\"", 684, 1);
#nullable restore
#line 16 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 649, Model.Imagens.ElementAt(0).Caminho, 649, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-fancybox><img");
            BeginWriteAttribute("src", " src=\"", 704, "\"", 745, 1);
#nullable restore
#line 16 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 710, Model.Imagens.ElementAt(0).Caminho, 710, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n");
#nullable restore
#line 17 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f74047ff45776ae27f9ffe53c27fe66aeadebbb8735", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6f74047ff45776ae27f9ffe53c27fe66aeadebbb8951", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div> <!-- slider-product.// -->\r\n                            <div class=\"img-small-wrap\">\r\n");
#nullable restore
#line 25 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                 if (Model.Imagens != null && Model.Imagens.Count > 0)
                                {
                                    foreach (Imagem imagem in Model.Imagens)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"item-gallery\"> <img");
            BeginWriteAttribute("src", " src=\"", 1515, "\"", 1536, 1);
#nullable restore
#line 29 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
WriteAttributeValue("", 1521, imagem.Caminho, 1521, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 30 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div> <!-- slider-nav.// -->
                        </article> <!-- gallery-wrap .end// -->
                    </aside>
                    <aside class=""col-sm-7"">
                        <article class=""p-5"">
                            <h3 class=""title mb-3"">");
#nullable restore
#line 37 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                              Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <div class=\"mb-3\">\r\n                                <var class=\"price h3 text-warning\">\r\n                                    <span class=\"num\">");
#nullable restore
#line 40 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                 Write(Model.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </var>
                                <span>/unid</span>
                            </div> <!-- price-detail-wrap .// -->
                            <dl>
                                <dt>Descrição</dt>
                                <dd>
                                    <p>
                                        ");
#nullable restore
#line 48 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                   Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </p>
                                </dd>
                            </dl>
                            <dl class=""row"">
                                <dt class=""col-sm-3"">Peso(kg)</dt>
                                <dd class=""col-sm-9"">");
#nullable restore
#line 54 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                                <dt class=\"col-sm-3\">Largura</dt>\r\n                                <dd class=\"col-sm-9\">");
#nullable restore
#line 56 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Largura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                                <dt class=\"col-sm-3\">Altura</dt>\r\n                                <dd class=\"col-sm-9\">");
#nullable restore
#line 58 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Altura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                                <dt class=\"col-sm-3\">Comprimento</dt>\r\n                                <dd class=\"col-sm-9\">");
#nullable restore
#line 60 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Comprimento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                                <dt class=\"col-sm-3\">Quantidade em estoque</dt>\r\n                                <dd class=\"col-sm-9\">");
#nullable restore
#line 62 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                Write(Model.Estoque);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                            </dl>\r\n                            <hr>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f74047ff45776ae27f9ffe53c27fe66aeadebbb17208", async() => {
                WriteLiteral(" <i class=\"fas fa-shopping-cart\"></i> Adicionar ao Carrinho ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                                                                            WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </article> <!-- card-body.// -->\r\n                    </aside> <!-- col.// -->\r\n                </div> <!-- row.// -->\r\n            </div> <!-- card.// -->\r\n        </div> <!-- code-wrap.// -->\r\n    </section>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.ProdutoAgregador.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
