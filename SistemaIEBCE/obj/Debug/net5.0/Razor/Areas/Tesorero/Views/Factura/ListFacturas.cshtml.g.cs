#pragma checksum "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Factura\ListFacturas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de4d8462538c51e7f94cc0976cf03640f0296c73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Tesorero_Views_Factura_ListFacturas), @"mvc.1.0.view", @"/Areas/Tesorero/Views/Factura/ListFacturas.cshtml")]
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
#line 1 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\_ViewImports.cshtml"
using SistemaIEBCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\_ViewImports.cshtml"
using SistemaIEBCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de4d8462538c51e7f94cc0976cf03640f0296c73", @"/Areas/Tesorero/Views/Factura/ListFacturas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df2b2f38e715333060f52fb2cddb5774dc274f4", @"/Areas/Tesorero/Views/_ViewImports.cshtml")]
    public class Areas_Tesorero_Views_Factura_ListFacturas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<SistemaIEBCE.Models.ViewModels.FacturaVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Factura\ListFacturas.cshtml"
  
    ViewData["Title"] = "ListFacturas";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"row shadow p-3 my-5 bg-white rounded py-2\">\r\n    <div class=\"col-12 row\">\r\n        <div class=\"col-8\">\r\n            <h1>Facturas Generadas</h1>\r\n        </div>\r\n        <div class=\"col-4 p-2 d-flex justify-content-end\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de4d8462538c51e7f94cc0976cf03640f0296c734930", async() => {
                WriteLiteral(" <i class=\"fa-solid fa-arrow-left\"></i> Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <div class=""col-12"">
        <table id=""tblFacList"" class=""table text-primary table-bordered table-responsive-lg table-hover"" style=""width:100%"">
            <thead class=""bg-primary text-light"">
                <tr>
                    <td>Id</td>
                    <td>Fecha</td>
                    <td>No. Recibo</td>
                    <td>Estudiante</td>
                    <td>Acci??n</td>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 33 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Factura\ListFacturas.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td> ");
#nullable restore
#line 36 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Factura\ListFacturas.cshtml"
                        Write(item.Factura.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> ");
#nullable restore
#line 37 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Factura\ListFacturas.cshtml"
                        Write(item.Factura.Fecha.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> ");
#nullable restore
#line 38 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Factura\ListFacturas.cshtml"
                        Write(item.Factura.NoFactura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> ");
#nullable restore
#line 39 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Factura\ListFacturas.cshtml"
                        Write(item.EstLstFact.NomEstudiante);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 39 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Factura\ListFacturas.cshtml"
                                                        Write(item.EstLstFact.ApellEstudiante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">  <a");
            BeginWriteAttribute("href", " href=\"", 1497, "\"", 1594, 4);
            WriteAttributeValue("", 1504, "/Tesorero/Factura/DetFactEst/?IdFac=", 1504, 36, true);
#nullable restore
#line 40 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Factura\ListFacturas.cshtml"
WriteAttributeValue("", 1540, item.Factura.Id, 1540, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1556, "&IdAsEs=", 1556, 8, true);
#nullable restore
#line 40 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Factura\ListFacturas.cshtml"
WriteAttributeValue("", 1564, item.Factura.IdAsigEstudiante, 1564, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa-solid fa-circle-info\"></i>  </a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Factura\ListFacturas.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#tblFacList').DataTable({
                ""language"": {
                    ""url"": ""../lib/DataTables/idioma/es-ES.json"",
                    ""emptyTable"": ""Ning??n dato disponible en esta tabla"",
                    ""search"": ""Buscar:"",
                    ""paginate"": {
                        ""first"": ""Primero"",
                        ""last"": ""??ltimo"",
                        ""next"": ""Siguiente"",
                        ""previous"": ""Anterior""
                    },
                    ""info"": ""Mostrando _START_ a _END_ de _TOTAL_ registros"",
                    ""lengthMenu"": ""Mostrar _MENU_ registros"",
                    ""zeroRecords"": ""No se encontraron resultados"",
                    ""infoEmpty"": ""Mostrando registros del 0 al 0 de un total de 0 registros"",
                    ""infoFiltered"": ""(filtrado de un total de _MAX_ registros)"",
                },
            });
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<SistemaIEBCE.Models.ViewModels.FacturaVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
