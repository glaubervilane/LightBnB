#pragma checksum "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "100a1ae52ac9650a211c3dde7382b9f63b5e0f5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Colaborador_Views_Pedido_Index), @"mvc.1.0.view", @"/Areas/Colaborador/Views/Pedido/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Colaborador/Views/Pedido/Index.cshtml", typeof(AspNetCore.Areas_Colaborador_Views_Pedido_Index))]
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
#line 2 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 3 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 5 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 6 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 7 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Contants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"100a1ae52ac9650a211c3dde7382b9f63b5e0f5a", @"/Areas/Colaborador/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f79f489b0e1d83948206292eb79b45696046965", @"/Areas/Colaborador/Views/_ViewImports.cshtml")]
    public class Areas_Colaborador_Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Visualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(68, 51, true);
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n<div class=\"container\">\r\n\r\n    ");
            EndContext();
            BeginContext(119, 372, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "100a1ae52ac9650a211c3dde7382b9f63b5e0f5a5530", async() => {
                BeginContext(158, 326, true);
                WriteLiteral(@"

        <label for=""numeroPedido"">Nº pedido</label>
        <input type=""text"" name=""codigoPedido"" class=""form-control"" id=""numeroPedido"">

        <label for=""cpf"">CPF</label>
        <input type=""text"" class=""form-control"" id=""cpf"">

        <button type=""submit"" class=""btn btn-primary"" value=""Pesquisar"" />
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(491, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 23 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
       await Html.RenderPartialAsync("~/Views/Shared/_Mensagem.cshtml"); 

#line default
#line hidden
            BeginContext(573, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
            BeginContext(609, 659, true);
            WriteLiteral(@"        <div class=""table-responsive"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th scope=""col"">Nº Pedido</th>
                        <th scope=""col"">Cliente</th>
                        <th scope=""col"">Data compra</th>
                        <th scope=""col"">Valor</th>
                        <th scope=""col"">Forma pagamento</th>
                        <th scope=""col"">Situação</th>
                        <th scope=""col"">NF-e</th>
                        <th scope=""col"">Ações</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 42 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                     foreach (var pedido in Model)
                    {

#line default
#line hidden
            BeginContext(1343, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1406, 9, false);
#line 45 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1415, 1, true);
            WriteLiteral("-");
            EndContext();
            BeginContext(1417, 20, false);
#line 45 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                                      Write(pedido.TransactionId);

#line default
#line hidden
            EndContext();
            BeginContext(1437, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1477, 19, false);
#line 46 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1496, 4, true);
            WriteLiteral("  - ");
            EndContext();
            BeginContext(1501, 18, false);
#line 46 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                                                   Write(pedido.Cliente.CPF);

#line default
#line hidden
            EndContext();
            BeginContext(1519, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1559, 42, false);
#line 47 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.DataRegistro.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1601, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1641, 31, false);
#line 48 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.ValorTotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1672, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1712, 21, false);
#line 49 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.FormaPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(1733, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1773, 15, false);
#line 50 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(1788, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1828, 10, false);
#line 51 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                           Write(pedido.NFE);

#line default
#line hidden
            EndContext();
            BeginContext(1838, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1911, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "100a1ae52ac9650a211c3dde7382b9f63b5e0f5a13231", async() => {
                BeginContext(1964, 10, true);
                WriteLiteral("Visualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                                                             WriteLiteral(pedido.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1978, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 56 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2069, 66, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n");
            EndContext();
#line 61 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2142, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(2147, 94, false);
#line 62 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 19\03_Fim\LojaVirtual\Areas\Colaborador\Views\Pedido\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina = pagina })));

#line default
#line hidden
            EndContext();
            BeginContext(2241, 12, true);
            WriteLiteral("\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
