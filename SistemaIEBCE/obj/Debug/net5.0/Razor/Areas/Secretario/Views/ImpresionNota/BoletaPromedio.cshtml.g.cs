#pragma checksum "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\ImpresionNota\BoletaPromedio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "550dfb865e5cd4054617162c92cc87659d512e01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Secretario_Views_ImpresionNota_BoletaPromedio), @"mvc.1.0.view", @"/Areas/Secretario/Views/ImpresionNota/BoletaPromedio.cshtml")]
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
#line 1 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\_ViewImports.cshtml"
using SistemaIEBCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\_ViewImports.cshtml"
using SistemaIEBCE.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\ImpresionNota\BoletaPromedio.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"550dfb865e5cd4054617162c92cc87659d512e01", @"/Areas/Secretario/Views/ImpresionNota/BoletaPromedio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df2b2f38e715333060f52fb2cddb5774dc274f4", @"/Areas/Secretario/Views/_ViewImports.cshtml")]
    public class Areas_Secretario_Views_ImpresionNota_BoletaPromedio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataTable>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Boleta.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ImpresionNota.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\ImpresionNota\BoletaPromedio.cshtml"
  
    ViewData["Title"] = "BoletaPromedio";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var res = ViewData["res"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "550dfb865e5cd4054617162c92cc87659d512e015053", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"container-fluid my-2 text-center\">\r\n    <h1");
            BeginWriteAttribute("class", " class=\"", 337, "\"", 345, 0);
            EndWriteAttribute();
            WriteLiteral(@">Boleta de Calificaciones Final</h1>
</div>
<div class=""bg-white text-center p-3"" style=""height: 529px;"" id=""boleta"">
    <h4>EVALUACIÓN DE LAS ASIGNATURAS</h4>
    <div class=""row"">
        <div class=""col-10"">
            <table id=""NotasFull"" class=""table table-bordered"" style=""width:100%"">
                <thead>
                    <tr>
");
#nullable restore
#line 23 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\ImpresionNota\BoletaPromedio.cshtml"
                         foreach (DataColumn column in Model.Columns)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 25 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\ImpresionNota\BoletaPromedio.cshtml"
                           Write(column.ColumnName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 26 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\ImpresionNota\BoletaPromedio.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\ImpresionNota\BoletaPromedio.cshtml"
                     foreach (DataRow Notas in Model.Rows)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n");
#nullable restore
#line 33 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\ImpresionNota\BoletaPromedio.cshtml"
                             foreach (DataColumn col in Model.Columns)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 35 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\ImpresionNota\BoletaPromedio.cshtml"
                               Write(Convert.ToString(Notas[col.ColumnName]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\ImpresionNota\BoletaPromedio.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\ImpresionNota\BoletaPromedio.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div class=""col-2 d-flex align-items-start flex-column"">
            <h6 class=""font-weight-bolder"">Firma de Aprobación</h6>
            <div class=""row pt-4 pl-2 ml-1 border-bottom"" style=""width:100%"">
                <p>f)</p>
            </div>
            <div class=""text-center "" style=""width:100%""> <h6>Ciclo completo</h6> </div>
            <div class=""row mt-5 border p-2 mt-auto mb-3 bd-highlight"">
                <p class=""text-justify"" style=""font-size: 10px;"">
                    Cada unidad tiene un valor de 100 puntos. <br /><br />
                    Al estudiante se le concidera que ha ganado la unidad, si ha obtenido como minimo 60 puntos. <br /><br />
                    Se realizra examen de recuperación a final del ciclo escolar en una sola oportunidad cuando es reprobado
                    cuatro áreas o sub áreas. (Acuerdo Ministerial 1171-2010). <br /><br />
                    Por cada unidad se suplica ");
            WriteLiteral("firmar de enterado.\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<button class=\"btn bg-primary text-white\" type=\"button\" onclick=\"printDiv(\'boleta\')\" value=\"imprimir div\">\r\n    Imprimir\r\n</button>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "550dfb865e5cd4054617162c92cc87659d512e0110886", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n\r\n            CargarBoletaPromedio(");
#nullable restore
#line 74 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\ImpresionNota\BoletaPromedio.cshtml"
                            Write(Model.Columns.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"-1);

        });
    </script>

    <script>
        function printDiv(nombreDiv) {
            var contenido = document.getElementById(nombreDiv).innerHTML;
            var contenidoOriginal = document.body.innerHTML;

            document.body.innerHTML = contenido;

            window.print();

            document.body.innerHTML = contenidoOriginal;
        }
    </script>

    
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
