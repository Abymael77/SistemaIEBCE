#pragma checksum "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a37a6917e116d9a32d6f24b7a80d8966bf480f35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Secretario_Views_Asistencia_UpdateAsis), @"mvc.1.0.view", @"/Areas/Secretario/Views/Asistencia/UpdateAsis.cshtml")]
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
#line 1 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a37a6917e116d9a32d6f24b7a80d8966bf480f35", @"/Areas/Secretario/Views/Asistencia/UpdateAsis.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df2b2f38e715333060f52fb2cddb5774dc274f4", @"/Areas/Secretario/Views/_ViewImports.cshtml")]
    public class Areas_Secretario_Views_Asistencia_UpdateAsis : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataTable>
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
#line 4 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
  
    ViewData["Title"] = "UpdateAsis";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"bg-white p-4 mt-5\">\r\n    <div class=\"row mb-3\">\r\n        <div class=\"col-6\">\r\n            <h2>Listado de Estudiantes</h2>\r\n            <p class=\"h6\">");
#nullable restore
#line 13 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
                     Write(ViewData["NomCurso"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 13 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
                                             Write(ViewData["NomBloque"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p class=\"h6\">");
#nullable restore
#line 14 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
                     Write(ViewData["NomGrado"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 14 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
                                             Write(ViewData["NomSeccion"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 14 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
                                                                       Write(ViewData["Anio"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n            <label class=\"h6\">Fecha</label>\r\n            <input type=\"date\" id=\"dateAsisUp\" name=\"fechaUp\" class=\"fechaUp mx-3\"");
            BeginWriteAttribute("value", " value=\"", 631, "\"", 657, 1);
#nullable restore
#line 18 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue("", 639, ViewData["Fecha"], 639, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <button class=\"guardar btn btn-dark\"");
            BeginWriteAttribute("onclick", " onclick=\"", 711, "\"", 755, 3);
            WriteAttributeValue("", 721, "UpdateAsis(", 721, 11, true);
#nullable restore
#line 19 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue("", 732, ViewData["idBlkAsCu"], 732, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 754, ")", 754, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"submit\">Guardar</button>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 803, "\"", 960, 6);
            WriteAttributeValue("", 810, "/Secretario/Asistencia/TblAsistencia/?IdBlkAsCu=", 810, 48, true);
#nullable restore
#line 20 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue("", 858, ViewData["idBlkAsCu"], 858, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 880, "&IdCicloEscolar=", 880, 16, true);
#nullable restore
#line 20 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue("", 896, ViewData["IdCicloEscolar"], 896, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 923, "&IdAsigCurso=", 923, 13, true);
#nullable restore
#line 20 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue("", 936, ViewData["IdAsigCurso"], 936, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn text-white bg-primary m-1""> <i class=""fa-solid fa-arrow-left""></i> Volver</a>
        </div>
    </div>
    <table id=""listEstuAsisUpdate"" class=""display table table-hover"" style=""width:100%"">
        <thead class=""thead-dark"">
            <tr>
                <th style=""width:10%"">IdAsis</th>
                <th style=""width:10%"">IdAsEs</th>
                <th>Nombre</th>
                <th>Apellido</th>
                <th>Tipo</th>
                <th>Comentario</th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 36 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
             foreach (DataRow r in Model.Rows)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td> <input class=\"form-control-plaintext idasis\"");
            BeginWriteAttribute("value", " value=\"", 1672, "\"", 1706, 1);
#nullable restore
#line 39 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue("", 1680, Convert.ToString(r["id"]), 1680, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly></td>\r\n                    <td> <input class=\"form-control-plaintext idases\"");
            BeginWriteAttribute("value", " value=\"", 1793, "\"", 1841, 1);
#nullable restore
#line 40 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue("", 1801, Convert.ToString(r["IdAsigEstudinate"]), 1801, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly></td>\r\n                    <td> ");
#nullable restore
#line 41 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
                    Write(Convert.ToString(r["NomEstudiante"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 42 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
                    Write(Convert.ToString(r["ApellEstudiante"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>\r\n");
#nullable restore
#line 44 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
                         if (@Convert.ToString(r["Tipo"]) == "Presente")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"form-check form-check-inline\">\r\n                                <input class=\"form-check-input tipo\" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 2281, "\"", 2347, 2);
            WriteAttributeValue("", 2288, "inlineRadioOptions", 2288, 18, true);
#nullable restore
#line 47 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 2306, Convert.ToString(r["IdAsigEstudinate"]), 2307, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2348, "\"", 2406, 2);
            WriteAttributeValue("", 2353, "inlineRadio1", 2353, 12, true);
#nullable restore
#line 47 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 2365, Convert.ToString(r["IdAsigEstudinate"]), 2366, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" checked value=\"Presente\">\r\n                                <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 2498, "\"", 2557, 2);
            WriteAttributeValue("", 2504, "inlineRadio1", 2504, 12, true);
#nullable restore
#line 48 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 2516, Convert.ToString(r["IdAsigEstudinate"]), 2517, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Presente</label>\r\n                            </div>\r\n                            <div class=\"form-check form-check-inline\">\r\n                                <input class=\"form-check-input tipo\" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 2766, "\"", 2832, 2);
            WriteAttributeValue("", 2773, "inlineRadioOptions", 2773, 18, true);
#nullable restore
#line 51 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 2791, Convert.ToString(r["IdAsigEstudinate"]), 2792, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2833, "\"", 2891, 2);
            WriteAttributeValue("", 2838, "inlineRadio2", 2838, 12, true);
#nullable restore
#line 51 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 2850, Convert.ToString(r["IdAsigEstudinate"]), 2851, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"Ausente\">\r\n                                <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 2974, "\"", 3033, 2);
            WriteAttributeValue("", 2980, "inlineRadio2", 2980, 12, true);
#nullable restore
#line 52 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 2992, Convert.ToString(r["IdAsigEstudinate"]), 2993, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ausente</label>\r\n                            </div>\r\n                            <div class=\"form-check form-check-inline\">\r\n                                <input class=\"form-check-input tipo\" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 3241, "\"", 3307, 2);
            WriteAttributeValue("", 3248, "inlineRadioOptions", 3248, 18, true);
#nullable restore
#line 55 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 3266, Convert.ToString(r["IdAsigEstudinate"]), 3267, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3308, "\"", 3366, 2);
            WriteAttributeValue("", 3313, "inlineRadio3", 3313, 12, true);
#nullable restore
#line 55 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 3325, Convert.ToString(r["IdAsigEstudinate"]), 3326, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"Justificado\">\r\n                                <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 3453, "\"", 3512, 2);
            WriteAttributeValue("", 3459, "inlineRadio3", 3459, 12, true);
#nullable restore
#line 56 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 3471, Convert.ToString(r["IdAsigEstudinate"]), 3472, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Justificado</label>\r\n                            </div>\r\n");
#nullable restore
#line 58 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
                        }
                        else if (@Convert.ToString(r["Tipo"]) == "Ausente")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"form-check form-check-inline\">\r\n                                <input class=\"form-check-input tipo\" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 3855, "\"", 3921, 2);
            WriteAttributeValue("", 3862, "inlineRadioOptions", 3862, 18, true);
#nullable restore
#line 62 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 3880, Convert.ToString(r["IdAsigEstudinate"]), 3881, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3922, "\"", 3980, 2);
            WriteAttributeValue("", 3927, "inlineRadio1", 3927, 12, true);
#nullable restore
#line 62 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 3939, Convert.ToString(r["IdAsigEstudinate"]), 3940, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"Presente\">\r\n                                <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 4064, "\"", 4123, 2);
            WriteAttributeValue("", 4070, "inlineRadio1", 4070, 12, true);
#nullable restore
#line 63 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 4082, Convert.ToString(r["IdAsigEstudinate"]), 4083, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Presente</label>\r\n                            </div>\r\n                            <div class=\"form-check form-check-inline\">\r\n                                <input class=\"form-check-input tipo\" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 4332, "\"", 4398, 2);
            WriteAttributeValue("", 4339, "inlineRadioOptions", 4339, 18, true);
#nullable restore
#line 66 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 4357, Convert.ToString(r["IdAsigEstudinate"]), 4358, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4399, "\"", 4457, 2);
            WriteAttributeValue("", 4404, "inlineRadio2", 4404, 12, true);
#nullable restore
#line 66 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 4416, Convert.ToString(r["IdAsigEstudinate"]), 4417, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" checked value=\"Ausente\">\r\n                                <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 4548, "\"", 4607, 2);
            WriteAttributeValue("", 4554, "inlineRadio2", 4554, 12, true);
#nullable restore
#line 67 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 4566, Convert.ToString(r["IdAsigEstudinate"]), 4567, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ausente</label>\r\n                            </div>\r\n                            <div class=\"form-check form-check-inline\">\r\n                                <input class=\"form-check-input tipo\" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 4815, "\"", 4881, 2);
            WriteAttributeValue("", 4822, "inlineRadioOptions", 4822, 18, true);
#nullable restore
#line 70 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 4840, Convert.ToString(r["IdAsigEstudinate"]), 4841, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4882, "\"", 4940, 2);
            WriteAttributeValue("", 4887, "inlineRadio3", 4887, 12, true);
#nullable restore
#line 70 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 4899, Convert.ToString(r["IdAsigEstudinate"]), 4900, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"Justificado\">\r\n                                <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 5027, "\"", 5086, 2);
            WriteAttributeValue("", 5033, "inlineRadio3", 5033, 12, true);
#nullable restore
#line 71 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 5045, Convert.ToString(r["IdAsigEstudinate"]), 5046, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Justificado</label>\r\n                            </div>\r\n");
#nullable restore
#line 73 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
                        }
                        else if (@Convert.ToString(r["Tipo"]) == "Justificado")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"form-check form-check-inline\">\r\n                                <input class=\"form-check-input tipo\" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 5433, "\"", 5499, 2);
            WriteAttributeValue("", 5440, "inlineRadioOptions", 5440, 18, true);
#nullable restore
#line 77 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 5458, Convert.ToString(r["IdAsigEstudinate"]), 5459, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 5500, "\"", 5558, 2);
            WriteAttributeValue("", 5505, "inlineRadio1", 5505, 12, true);
#nullable restore
#line 77 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 5517, Convert.ToString(r["IdAsigEstudinate"]), 5518, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"Presente\">\r\n                                <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 5642, "\"", 5701, 2);
            WriteAttributeValue("", 5648, "inlineRadio1", 5648, 12, true);
#nullable restore
#line 78 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 5660, Convert.ToString(r["IdAsigEstudinate"]), 5661, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Presente</label>\r\n                            </div>\r\n                            <div class=\"form-check form-check-inline\">\r\n                                <input class=\"form-check-input tipo\" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 5910, "\"", 5976, 2);
            WriteAttributeValue("", 5917, "inlineRadioOptions", 5917, 18, true);
#nullable restore
#line 81 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 5935, Convert.ToString(r["IdAsigEstudinate"]), 5936, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 5977, "\"", 6035, 2);
            WriteAttributeValue("", 5982, "inlineRadio2", 5982, 12, true);
#nullable restore
#line 81 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 5994, Convert.ToString(r["IdAsigEstudinate"]), 5995, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" value=\"Ausente\">\r\n                                <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 6118, "\"", 6177, 2);
            WriteAttributeValue("", 6124, "inlineRadio2", 6124, 12, true);
#nullable restore
#line 82 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 6136, Convert.ToString(r["IdAsigEstudinate"]), 6137, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ausente</label>\r\n                            </div>\r\n                            <div class=\"form-check form-check-inline\">\r\n                                <input class=\"form-check-input tipo\" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 6385, "\"", 6451, 2);
            WriteAttributeValue("", 6392, "inlineRadioOptions", 6392, 18, true);
#nullable restore
#line 85 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 6410, Convert.ToString(r["IdAsigEstudinate"]), 6411, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 6452, "\"", 6510, 2);
            WriteAttributeValue("", 6457, "inlineRadio3", 6457, 12, true);
#nullable restore
#line 85 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 6469, Convert.ToString(r["IdAsigEstudinate"]), 6470, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" checked value=\"Justificado\">\r\n                                <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 6605, "\"", 6664, 2);
            WriteAttributeValue("", 6611, "inlineRadio3", 6611, 12, true);
#nullable restore
#line 86 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue(" ", 6623, Convert.ToString(r["IdAsigEstudinate"]), 6624, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Justificado</label>\r\n                            </div>\r\n");
#nullable restore
#line 88 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td> <input class=\"form-control-plaintext coment border\"");
            BeginWriteAttribute("value", " value=\"", 6853, "\"", 6895, 1);
#nullable restore
#line 90 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
WriteAttributeValue("", 6861, Convert.ToString(r["Comentario"]), 6861, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                </tr>\r\n");
#nullable restore
#line 92 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a37a6917e116d9a32d6f24b7a80d8966bf480f3529997", async() => {
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
                WriteLiteral("\r\n\r\n\r\n    <script>\r\n\r\n        $(document).ready(function () {\r\n            //Actualizar\r\n            cargarDatatableLsEstAs(");
#nullable restore
#line 107 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
                              Write(ViewData["idBlkAsCu"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 107 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
                                                      Write(ViewData["IdCicloEscolar"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 107 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Secretario\Views\Asistencia\UpdateAsis.cshtml"
                                                                                   Write(ViewData["IdAsigCurso"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n\r\n\r\n        });\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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