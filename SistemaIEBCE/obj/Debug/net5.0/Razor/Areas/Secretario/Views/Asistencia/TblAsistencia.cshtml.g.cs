#pragma checksum "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4c04d984accdecfda7d256d34dbb85108d9dd3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Secretario_Views_Asistencia_TblAsistencia), @"mvc.1.0.view", @"/Areas/Secretario/Views/Asistencia/TblAsistencia.cshtml")]
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
#line 1 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c04d984accdecfda7d256d34dbb85108d9dd3e", @"/Areas/Secretario/Views/Asistencia/TblAsistencia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df2b2f38e715333060f52fb2cddb5774dc274f4", @"/Areas/Secretario/Views/_ViewImports.cshtml")]
    public class Areas_Secretario_Views_Asistencia_TblAsistencia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataTable>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Asistencia.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
  
    ViewData["Title"] = "TblAsistencia";
    Layout = "~/Views/Shared/_Layout.cshtml";

    var message = TempData["error"] ?? string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container-fluid bg-white p-4 mt-4\">\r\n\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row py-3\">\r\n            <div class=\"col-4\">\r\n                <h2>Asistencias</h2>\r\n                <p class=\"h6\">");
#nullable restore
#line 23 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
                         Write(ViewData["NomCurso"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 23 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
                                                 Write(ViewData["NomBloque"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                <p class=\"h6\">");
#nullable restore
#line 24 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
                         Write(ViewData["NomGrado"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 24 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
                                                 Write(ViewData["NomSeccion"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 24 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
                                                                           Write(ViewData["Anio"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-8 text-right\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 832, "\"", 936, 4);
            WriteAttributeValue("", 839, "/Secretario/Asistencia/Bloque/", 839, 30, true);
#nullable restore
#line 27 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
WriteAttributeValue("", 869, ViewData["IdAsigCurso"], 869, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 893, "?IdCicloEscolar=", 893, 16, true);
#nullable restore
#line 27 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
WriteAttributeValue("", 909, ViewData["IdCicloEscolar"], 909, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn text-white bg-primary m-1\"> <i class=\"fa-solid fa-arrow-left\"></i> Volver</a>\r\n");
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 1181, "\"", 1341, 6);
            WriteAttributeValue("", 1188, "/Secretario/Asistencia/CreateAsistencia/?IdBlkAsCu=", 1188, 51, true);
#nullable restore
#line 29 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
WriteAttributeValue("", 1239, ViewData["idBlkAsCu"], 1239, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1261, "&IdCicloEscolar=", 1261, 16, true);
#nullable restore
#line 29 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
WriteAttributeValue("", 1277, ViewData["IdCicloEscolar"], 1277, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1304, "&IdAsigCurso=", 1304, 13, true);
#nullable restore
#line 29 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
WriteAttributeValue("", 1317, ViewData["IdAsigCurso"], 1317, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn text-white bg-primary m-1""> <i class=""fa-solid fa-plus""></i> Agregar Asistencia</a>
            </div>
        </div>

        <div class=""row shadow p-3 mb-5 bg-white rounded py-2"">
            <div class=""col-12"">
                <table id=""tblBloqueAsis"" class=""table text-primary table-bordered table-responsive-lg table-hover"" style=""width:100%"">
                    <thead class=""bg-primary text-light"">
                        <tr>
                            <td>Id</td>
                            <td>Fecha</td>
                            <td>Accion </td>
                        </tr>
                    </thead>

");
#nullable restore
#line 44 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
                     foreach (DataRow r in Model.Rows)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td> ");
#nullable restore
#line 47 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
                            Write(Convert.ToString(r["IdBloqueAsigCurso"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 48 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
                            Write(Convert.ToDateTime(r["Fecha"]).ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td class=\"text-center\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2367, "\"", 2583, 8);
            WriteAttributeValue("", 2374, "/Secretario/Asistencia/UpdateAsis/?IdBlkAsCu=", 2374, 45, true);
#nullable restore
#line 50 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
WriteAttributeValue("", 2419, r["IdBloqueAsigCurso"], 2419, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2442, "&IdCicloEscolar=", 2442, 16, true);
#nullable restore
#line 50 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
WriteAttributeValue("", 2458, ViewData["IdCicloEscolar"], 2458, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2485, "&IdAsigCurso=", 2485, 13, true);
#nullable restore
#line 50 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
WriteAttributeValue("", 2498, ViewData["IdAsigCurso"], 2498, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2522, "&Fecha=", 2522, 7, true);
#nullable restore
#line 50 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
WriteAttributeValue("", 2529, Convert.ToDateTime(r["Fecha"]).ToString("yyyy-MM-dd"), 2529, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\'btn btn-outline-primary mr-1\' title=\"Editar\">\r\n                                    <i class=\'fas fa-edit\'></i>\r\n                                </a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n                var message = \'");
#nullable restore
#line 68 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\TblAsistencia.cshtml"
                          Write(message);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                if (message) {
                    const Toast = Swal.mixin({
                        toast: true,
                        position: 'bottom-end',
                        showConfirmButton: false,
                        timer: 2000,
                        timerProgressBar: true,
                        didOpen: (toast) => {
                            toast.addEventListener('mouseenter', Swal.stopTimer)
                            toast.addEventListener('mouseleave', Swal.resumeTimer)
                        }
                    })
                    Toast.fire({
                        icon: 'error',
                        title: 'Error: ' + message
                    })
                }
            if (message == ""dodo"") {
                    const Toast = Swal.mixin({
                        toast: true,
                        position: 'bottom-end',
                        showConfirmButton: false,
                        timer: 2000,
                    ");
                WriteLiteral(@"    timerProgressBar: true,
                        didOpen: (toast) => {
                            toast.addEventListener('mouseenter', Swal.stopTimer)
                            toast.addEventListener('mouseleave', Swal.resumeTimer)
                        }
                    })
                    Toast.fire({
                        icon: 'success',
                        title: 'Operaci??n Exitosa '
                    })
                }
            });
    </script>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4c04d984accdecfda7d256d34dbb85108d9dd3e14788", async() => {
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
                WriteLiteral("\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n");
                WriteLiteral("            ListTblAsis();\r\n        });\r\n    </script>\r\n\r\n");
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
