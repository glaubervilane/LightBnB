#pragma checksum "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1c520953eba3b7b86815ee98b3d7f089ce7a3c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Colaborador_Views_Categoria_Index), @"mvc.1.0.view", @"/Areas/Colaborador/Views/Categoria/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Colaborador/Views/Categoria/Index.cshtml", typeof(AspNetCore.Areas_Colaborador_Views_Categoria_Index))]
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
#line 2 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 3 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 4 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1c520953eba3b7b86815ee98b3d7f089ce7a3c0", @"/Areas/Colaborador/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90799275c998573c5584c7fde9507bc8004803f8", @"/Areas/Colaborador/Views/_ViewImports.cshtml")]
    public class Areas_Colaborador_Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<LojaVirtual.Models.Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#line 5 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
  
    /*
        @if (categoria.CategoriaPai != null)
        {
            <span>@categoria.CategoriaPai.Id - @categoria.CategoriaPai.Nome</span>
        }
        else
        {
            <span>--</span>
        }
    */

#line default
#line hidden
            BeginContext(342, 24, true);
            WriteLiteral("\r\n<h1>Categoria</h1>\r\n\r\n");
            EndContext();
            BeginContext(366, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c520953eba3b7b86815ee98b3d7f089ce7a3c06295", async() => {
                BeginContext(416, 9, true);
                WriteLiteral("Cadastrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(429, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 22 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
 if (TempData["MSG_S"] != null)
{

#line default
#line hidden
            BeginContext(469, 35, true);
            WriteLiteral("    <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(505, 17, false);
#line 24 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                              Write(TempData["MSG_S"]);

#line default
#line hidden
            EndContext();
            BeginContext(522, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 25 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
}

#line default
#line hidden
            BeginContext(531, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
 if (Model.Count > 0)
{


#line default
#line hidden
            BeginContext(561, 391, true);
            WriteLiteral(@"    <div class=""table-responsive"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th scope=""col"">Código</th>
                    <th scope=""col"">Nome</th>
                    <th scope=""col"">Categoria pai</th>
                    <th scope=""col"">Ações</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 41 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                 foreach (Categoria categoria in Model)
                {

#line default
#line hidden
            BeginContext(1028, 66, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(1095, 12, false);
#line 44 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                   Write(categoria.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1107, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(1143, 14, false);
#line 45 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                       Write(categoria.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1157, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1223, 51, false);
#line 47 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                       Write(Html.DisplayFor(model => categoria.CategoriaPai.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1274, 61, true);
            WriteLiteral("\r\n                            -\r\n                            ");
            EndContext();
            BeginContext(1336, 53, false);
#line 49 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                       Write(Html.DisplayFor(model => categoria.CategoriaPai.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1480, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c520953eba3b7b86815ee98b3d7f089ce7a3c011772", async() => {
                BeginContext(1561, 9, true);
                WriteLiteral("Atualizar");
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
#line 52 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                                        WriteLiteral(categoria.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1574, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1604, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c520953eba3b7b86815ee98b3d7f089ce7a3c014281", async() => {
                BeginContext(1680, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                                      WriteLiteral(categoria.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1691, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 56 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1770, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1829, 85, false);
#line 61 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina })));

#line default
#line hidden
            EndContext();
#line 61 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                                                                          

}
else
{

#line default
#line hidden
            BeginContext(1930, 46, true);
            WriteLiteral("    <span>Nenhum registro cadastrado!</span>\r\n");
            EndContext();
#line 67 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 12\20_Fim\LojaVirtual\Areas\Colaborador\Views\Categoria\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<LojaVirtual.Models.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
