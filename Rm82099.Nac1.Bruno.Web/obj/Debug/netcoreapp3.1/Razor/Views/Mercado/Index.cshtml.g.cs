#pragma checksum "C:\Users\bbrun\Desktop\faculdade\2°ANO FACULDADE\2SEMESTRE\Enterprise\Rm82099.Nac1.Bruno.Web\Rm82099.Nac1.Bruno.Web\Views\Mercado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b118e3f06d1592ad39e77f21829288d1a027e352"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mercado_Index), @"mvc.1.0.view", @"/Views/Mercado/Index.cshtml")]
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
#line 1 "C:\Users\bbrun\Desktop\faculdade\2°ANO FACULDADE\2SEMESTRE\Enterprise\Rm82099.Nac1.Bruno.Web\Rm82099.Nac1.Bruno.Web\Views\_ViewImports.cshtml"
using Rm82099.Nac1.Bruno.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bbrun\Desktop\faculdade\2°ANO FACULDADE\2SEMESTRE\Enterprise\Rm82099.Nac1.Bruno.Web\Rm82099.Nac1.Bruno.Web\Views\_ViewImports.cshtml"
using Rm82099.Nac1.Bruno.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b118e3f06d1592ad39e77f21829288d1a027e352", @"/Views/Mercado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b621b3e128426cceba7c2ac4ddea61adf7d433ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Mercado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mercado>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "pesquisar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Rm82099.Nac1.Bruno.Web.TagHelpers.NacTagHelper __Rm82099_Nac1_Bruno_Web_TagHelpers_NacTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\bbrun\Desktop\faculdade\2°ANO FACULDADE\2SEMESTRE\Enterprise\Rm82099.Nac1.Bruno.Web\Rm82099.Nac1.Bruno.Web\Views\Mercado\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"margin-top: 75px\">Lista de Mercados</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nac", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b118e3f06d1592ad39e77f21829288d1a027e3526244", async() => {
            }
            );
            __Rm82099_Nac1_Bruno_Web_TagHelpers_NacTagHelper = CreateTagHelper<global::Rm82099.Nac1.Bruno.Web.TagHelpers.NacTagHelper>();
            __tagHelperExecutionContext.Add(__Rm82099_Nac1_Bruno_Web_TagHelpers_NacTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\bbrun\Desktop\faculdade\2°ANO FACULDADE\2SEMESTRE\Enterprise\Rm82099.Nac1.Bruno.Web\Rm82099.Nac1.Bruno.Web\Views\Mercado\Index.cshtml"
WriteLiteral(TempData["msg"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Rm82099_Nac1_Bruno_Web_TagHelpers_NacTagHelper.Texto = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("texto", __Rm82099_Nac1_Bruno_Web_TagHelpers_NacTagHelper.Texto, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b118e3f06d1592ad39e77f21829288d1a027e3527842", async() => {
                WriteLiteral(@"
        <input name=""nome"" class=""form-control mr-sm-2 w-50"" type=""text"" placeholder=""Pesquisar pelo Nome (Ordenado pelo porte!)"" aria-label=""Pesquisar"">
        <button class=""btn btn-outline-success my-2 my-sm-0"" type=""submit"">Pesquisar</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<!-- Tabela html com uma linha com os titulos e (loop) uma linha para cada mercado da lista-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b118e3f06d1592ad39e77f21829288d1a027e3529929", async() => {
                WriteLiteral("Cadastrar um novo Mercado");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Código</th>\r\n        <th>Nome</th>\r\n        <th>Capacidade</th>\r\n        <th>Novo</th>\r\n        <th>Porte</th>\r\n        <th>Data de abertura</th>\r\n    </tr>\r\n");
#nullable restore
#line 29 "C:\Users\bbrun\Desktop\faculdade\2°ANO FACULDADE\2SEMESTRE\Enterprise\Rm82099.Nac1.Bruno.Web\Rm82099.Nac1.Bruno.Web\Views\Mercado\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\bbrun\Desktop\faculdade\2°ANO FACULDADE\2SEMESTRE\Enterprise\Rm82099.Nac1.Bruno.Web\Rm82099.Nac1.Bruno.Web\Views\Mercado\Index.cshtml"
           Write(item.MercadoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\bbrun\Desktop\faculdade\2°ANO FACULDADE\2SEMESTRE\Enterprise\Rm82099.Nac1.Bruno.Web\Rm82099.Nac1.Bruno.Web\Views\Mercado\Index.cshtml"
           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\bbrun\Desktop\faculdade\2°ANO FACULDADE\2SEMESTRE\Enterprise\Rm82099.Nac1.Bruno.Web\Rm82099.Nac1.Bruno.Web\Views\Mercado\Index.cshtml"
           Write(item.Capacidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\bbrun\Desktop\faculdade\2°ANO FACULDADE\2SEMESTRE\Enterprise\Rm82099.Nac1.Bruno.Web\Rm82099.Nac1.Bruno.Web\Views\Mercado\Index.cshtml"
            Write(item.Novo?"Sim":"Não");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\bbrun\Desktop\faculdade\2°ANO FACULDADE\2SEMESTRE\Enterprise\Rm82099.Nac1.Bruno.Web\Rm82099.Nac1.Bruno.Web\Views\Mercado\Index.cshtml"
           Write(item.Porte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\bbrun\Desktop\faculdade\2°ANO FACULDADE\2SEMESTRE\Enterprise\Rm82099.Nac1.Bruno.Web\Rm82099.Nac1.Bruno.Web\Views\Mercado\Index.cshtml"
           Write(item.DataAbertura.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b118e3f06d1592ad39e77f21829288d1a027e35213591", async() => {
                WriteLiteral("Editar");
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
#nullable restore
#line 39 "C:\Users\bbrun\Desktop\faculdade\2°ANO FACULDADE\2SEMESTRE\Enterprise\Rm82099.Nac1.Bruno.Web\Rm82099.Nac1.Bruno.Web\Views\Mercado\Index.cshtml"
                                         WriteLiteral(item.MercadoId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1324, "\"", 1366, 2);
            WriteAttributeValue("", 1334, "mercadoId.value=", 1334, 16, true);
#nullable restore
#line 40 "C:\Users\bbrun\Desktop\faculdade\2°ANO FACULDADE\2SEMESTRE\Enterprise\Rm82099.Nac1.Bruno.Web\Rm82099.Nac1.Bruno.Web\Views\Mercado\Index.cshtml"
WriteAttributeValue(" ", 1350, item.MercadoId, 1351, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-sm btn-outline-danger\" data-toggle=\"modal\" data-target=\"#exampleModal\">\r\n                    Excluir\r\n                </button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\bbrun\Desktop\faculdade\2°ANO FACULDADE\2SEMESTRE\Enterprise\Rm82099.Nac1.Bruno.Web\Rm82099.Nac1.Bruno.Web\Views\Mercado\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</table>



<!-- Button trigger modal -->
<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Confimação</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Confirma essa transação?
            </div>
            <div class=""modal-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b118e3f06d1592ad39e77f21829288d1a027e35217668", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" name=""id"" id=""mercadoId"" />
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Não</button>
                    <button type=""submit"" class=""btn btn-danger"">Sim</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mercado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
