#pragma checksum "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f1f7f90f432ca581687e4c33482adecca42af90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Colaborador_Views_Cliente_Index), @"mvc.1.0.view", @"/Areas/Colaborador/Views/Cliente/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Colaborador/Views/Cliente/Index.cshtml", typeof(AspNetCore.Areas_Colaborador_Views_Cliente_Index))]
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
#line 2 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 3 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 4 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 5 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Contants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f1f7f90f432ca581687e4c33482adecca42af90", @"/Areas/Colaborador/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ec12adda21896c2e12c0ff5a3bc3a04581649b", @"/Areas/Colaborador/Views/_ViewImports.cshtml")]
    public class Areas_Colaborador_Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<LojaVirtual.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtivarDesativar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 154, true);
            WriteLiteral("\r\n<h1>Cliente</h1>\r\n\r\n<br />\r\n<br />\r\n<!--\r\n    Formulário\r\n    -- QueryString: Colaborador/Cliente/Index?pesquisa={palavraDigitada}&pagina=3\r\n    \r\n-->\r\n");
            EndContext();
            BeginContext(254, 302, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f1f7f90f432ca581687e4c33482adecca42af905840", async() => {
                BeginContext(273, 276, true);
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""pesquisa""></label>
        <input type=""text"" name=""pesquisa"" id=""pesquisa"" class=""form-control"" placeholder=""Digite o nome ou e-mail do cliente"">
    </div>
    <button type=""submit"" class=""btn btn-primary"">OK</button>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(556, 20, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n");
            EndContext();
#line 25 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
 if (TempData["MSG_S"] != null)
{

#line default
#line hidden
            BeginContext(612, 35, true);
            WriteLiteral("    <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(648, 17, false);
#line 27 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                              Write(TempData["MSG_S"]);

#line default
#line hidden
            EndContext();
            BeginContext(665, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 28 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
}

#line default
#line hidden
            BeginContext(674, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
 if (Model.Count > 0)
{


#line default
#line hidden
            BeginContext(704, 161, true);
            WriteLiteral("    <div class=\"table-responsive\">\r\n        <table class=\"table table-bordered\">\r\n            <thead>\r\n                <tr>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(866, 46, false);
#line 37 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Id));

#line default
#line hidden
            EndContext();
            BeginContext(912, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(956, 48, false);
#line 38 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1004, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(1048, 49, false);
#line 39 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Email));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 121, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">Ações</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 44 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                 foreach (Cliente cliente in Model)
                {

#line default
#line hidden
            BeginContext(1290, 66, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(1357, 10, false);
#line 47 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                                   Write(cliente.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1367, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(1403, 12, false);
#line 48 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                       Write(cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1415, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1451, 13, false);
#line 49 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                       Write(cliente.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1464, 37, true);
            WriteLiteral("</td>\r\n                        <td>\r\n");
            EndContext();
#line 51 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                             if (cliente.Situacao == "A")
                            {

#line default
#line hidden
            BeginContext(1591, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1623, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f1f7f90f432ca581687e4c33482adecca42af9012839", async() => {
                BeginContext(1705, 9, true);
                WriteLiteral("Desativar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                                                                  WriteLiteral(cliente.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1718, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1816, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1848, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f1f7f90f432ca581687e4c33482adecca42af9015718", async() => {
                BeginContext(1933, 6, true);
                WriteLiteral("Ativar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                                                                  WriteLiteral(cliente.Id);

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
            BeginContext(1943, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 58 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1976, 58, true);
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 61 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2053, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2112, 85, false);
#line 66 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina })));

#line default
#line hidden
            EndContext();
#line 66 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
                                                                                          

}
else
{

#line default
#line hidden
            BeginContext(2213, 46, true);
            WriteLiteral("    <span>Nenhum registro cadastrado!</span>\r\n");
            EndContext();
#line 72 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 15\05_Fim\LojaVirtual\Areas\Colaborador\Views\Cliente\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<LojaVirtual.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
