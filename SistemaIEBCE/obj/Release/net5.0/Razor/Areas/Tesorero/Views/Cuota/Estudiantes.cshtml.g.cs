#pragma checksum "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Cuota\Estudiantes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e24ee314f4a961619bef8e11e11b6c1f0ad0047a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Tesorero_Views_Cuota_Estudiantes), @"mvc.1.0.view", @"/Areas/Tesorero/Views/Cuota/Estudiantes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e24ee314f4a961619bef8e11e11b6c1f0ad0047a", @"/Areas/Tesorero/Views/Cuota/Estudiantes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df2b2f38e715333060f52fb2cddb5774dc274f4", @"/Areas/Tesorero/Views/_ViewImports.cshtml")]
    public class Areas_Tesorero_Views_Cuota_Estudiantes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<SistemaIEBCE.Models.ViewModels.AsigEstudianteVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cuota", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RepPagos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Cuota\Estudiantes.cshtml"
  
    ViewData["Title"] = "Estudiantes";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var num = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row shadow p-3 my-5 bg-white rounded py-2\">\r\n    <div class=\"col-12 row\">\r\n        <div class=\"col-8\">\r\n            <h1");
            BeginWriteAttribute("class", " class=\"", 339, "\"", 347, 0);
            EndWriteAttribute();
            WriteLiteral(">Estudiantes</h1>\r\n        </div>\r\n        <div class=\"col-4 p-2 d-flex justify-content-end\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e24ee314f4a961619bef8e11e11b6c1f0ad0047a6020", async() => {
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
            WriteLiteral("\r\n");
            WriteLiteral(@"        </div>
    </div>
    <div class=""col-12"">
        <table id=""tblEstudiantesCuenta"" class=""table text-primary table-bordered table-responsive-lg table-hover"" style=""width:100%"">
            <thead class=""bg-primary text-light"">
                <tr>
                    <td>#</td>
                    <td>Nombre</td>
                    <td>Apellido</td>
                    <td>Ciclo Escolar</td>
                    <td>Estado</td>
                    <td>Acci??n</td>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 34 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Cuota\Estudiantes.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td> ");
#nullable restore
#line 37 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Cuota\Estudiantes.cshtml"
                        Write(Convert.ToInt32(num++));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-uppercase\"> ");
#nullable restore
#line 38 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Cuota\Estudiantes.cshtml"
                                               Write(item.nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-uppercase\" > ");
#nullable restore
#line 39 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Cuota\Estudiantes.cshtml"
                                                Write(item.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\"> ");
#nullable restore
#line 40 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Cuota\Estudiantes.cshtml"
                                            Write(item.cicloEscolar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">\r\n");
#nullable restore
#line 42 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Cuota\Estudiantes.cshtml"
                             if (item.estado == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"d-flex justify-content-center\"> <span class=\"badge badge-primary\">Activo</span> </div>\r\n");
#nullable restore
#line 45 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Cuota\Estudiantes.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"d-flex justify-content-center\"> <span class=\"badge badge-secondary\">Inactivo</span> </div>\r\n");
#nullable restore
#line 49 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Cuota\Estudiantes.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td class=\"text-center\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e24ee314f4a961619bef8e11e11b6c1f0ad0047a11183", async() => {
                WriteLiteral(" <i class=\"fas fa-chart-column\"></i>  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idAsEs", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Cuota\Estudiantes.cshtml"
                                                                                                                            WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idAsEs"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idAsEs", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idAsEs"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n                    </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\Cuota\Estudiantes.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            cargarDatatableNotaCurso();
        });

        function cargarDatatableNotaCurso() {
            dataTable = $(""#tblEstudiantesCuenta"").DataTable({
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
                    ""infoFiltered"": ""(f");
                WriteLiteral("iltrado de un total de _MAX_ registros)\",\r\n                },\r\n                \"width\": \"100%\"\r\n            });\r\n        }\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<SistemaIEBCE.Models.ViewModels.AsigEstudianteVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
