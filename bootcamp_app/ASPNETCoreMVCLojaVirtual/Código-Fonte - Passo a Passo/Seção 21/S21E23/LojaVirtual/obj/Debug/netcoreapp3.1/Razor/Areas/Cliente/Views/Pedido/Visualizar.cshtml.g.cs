#pragma checksum "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0879198662b3bb72fe036151665641a608d87b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_Pedido_Visualizar), @"mvc.1.0.view", @"/Areas/Cliente/Views/Pedido/Visualizar.cshtml")]
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
#line 3 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Json.Resolver;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0879198662b3bb72fe036151665641a608d87b6", @"/Areas/Cliente/Views/Pedido/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c06482c6d69c88a4c3bb64f1a8dc72f1babff4e", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_Pedido_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pedido>
    {
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
        private global::AspNetCore.Areas_Cliente_Views_Pedido_Visualizar.__Generated__PedidoSituacaoViewComponentTagHelper __PedidoSituacaoViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
  
    ViewData["Title"] = "Visualizar";
    TransacaoPagarMe transacao = JsonConvert.DeserializeObject<TransacaoPagarMe>(Model.DadosTransaction);
    List<ProdutoItem> produtos = JsonConvert.DeserializeObject<List<ProdutoItem>>(Model.DadosProdutos, new JsonSerializerSettings() { ContractResolver = new ProdutoItemResolver<List<ProdutoItem>>() });
    var aniversario = DateTime.Parse(transacao.Customer.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12 text-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:pedido-situacao", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f0879198662b3bb72fe036151665641a608d87b65670", async() => {
            }
            );
            __PedidoSituacaoViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Areas_Cliente_Views_Pedido_Visualizar.__Generated__PedidoSituacaoViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__PedidoSituacaoViewComponentTagHelper);
#nullable restore
#line 12 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
__PedidoSituacaoViewComponentTagHelper.pedido = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("pedido", __PedidoSituacaoViewComponentTagHelper.pedido, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <br />
            <br />
        </div>
    </div>
    <div class=""row"">
        
        <div class=""col-md-12"">
            <h3>Dados pedido</h3>
            <table class=""table table-bordered"">
                <tr>
                    <td colspan=""2""><strong>Situação do pedido:</strong> ");
#nullable restore
#line 23 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                                    Write(Model.Situacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    \r\n                </tr>\r\n                <tr>\r\n                    <td><strong>Cliente:</strong> ");
#nullable restore
#line 27 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                             Write(transacao.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Nascimento:</strong> ");
#nullable restore
#line 28 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                Write(aniversario.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>Forma de pagamento: </strong>");
#nullable restore
#line 31 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                        Write(Model.FormaPagamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Nota Fiscal Eletrônica: </strong>- ");
#nullable restore
#line 32 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                              Write(Model.NFE);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </table>


            <h3>Entrega</h3>
            <table class=""table table-bordered"">
                <tr>
                    <td colspan=""4"">
                        <strong>Endereço de entrega: </strong>");
#nullable restore
#line 41 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                         Write(transacao.Shipping.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>CEP:</strong> ");
#nullable restore
#line 45 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                         Write(transacao.Shipping.Address.Zipcode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Estado:</strong> ");
#nullable restore
#line 46 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                            Write(transacao.Shipping.Address.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Cidade:</strong> ");
#nullable restore
#line 47 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                            Write(transacao.Shipping.Address.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Bairro:</strong> ");
#nullable restore
#line 48 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                            Write(transacao.Shipping.Address.Neighborhood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"2\"><strong>Endereço: </strong> ");
#nullable restore
#line 51 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                           Write(transacao.Shipping.Address.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Complemento: </strong>");
#nullable restore
#line 52 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                 Write(transacao.Shipping.Address.Complementary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Número: </strong>");
#nullable restore
#line 53 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                            Write(transacao.Shipping.Address.StreetNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"2\"><strong>Transportadora:</strong> ");
#nullable restore
#line 56 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                                Write(Model.FreteEmpresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Valor do frete:</strong> ");
#nullable restore
#line 57 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                    Write(Mascara.ConverterPagarMeIntToDecimal(transacao.Shipping.Fee).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><strong>Rastreamento: </strong> - ");
#nullable restore
#line 58 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                     Write(Model.FreteCodRastreamento);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </table>

            <h3>Lista de produtos</h3>
            <table class=""table table-bordered"">
                <tr>
                    <th>Quantidade</th>
                    <th>Nome</th>
                    <th>Valor</th>
                    <th>TOTAL</th>
                </tr>

");
#nullable restore
#line 71 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                 foreach (var produto in produtos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 74 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                       Write(produto.UnidadesPedidas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 75 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                       Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 76 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                       Write(produto.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 77 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                        Write((produto.Valor * produto.UnidadesPedidas).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 79 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <tr>\r\n                    <td colspan=\"3\"><strong>FRETE</strong></td>\r\n                    <td>");
#nullable restore
#line 83 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                   Write(Mascara.ConverterPagarMeIntToDecimal(transacao.Shipping.Fee).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"3\"><strong>TOTAL</strong></td>\r\n                    <td>");
#nullable restore
#line 87 "C:\Dev\Projetos\ASPNETCoreMVCLojaVirtual\Código-Fonte - Passo a Passo\Seção 21\S21E23\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                   Write(Model.ValorTotal.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n\r\n            <br />\r\n            <br />\r\n            <button class=\"btn btn-outline-primary btn-lg btn-imprimir\">Imprimir</button>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pedido> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:pedido-situacao")]
        public class __Generated__PedidoSituacaoViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__PedidoSituacaoViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public LojaVirtual.Models.Pedido pedido { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("PedidoSituacao", new { pedido });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
