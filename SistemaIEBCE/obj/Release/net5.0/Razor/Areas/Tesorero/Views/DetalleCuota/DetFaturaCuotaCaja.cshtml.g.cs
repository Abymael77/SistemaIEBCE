#pragma checksum "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f13c968dbc2bf5b21acde4bcf31048b6cd44a53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Tesorero_Views_DetalleCuota_DetFaturaCuotaCaja), @"mvc.1.0.view", @"/Areas/Tesorero/Views/DetalleCuota/DetFaturaCuotaCaja.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f13c968dbc2bf5b21acde4bcf31048b6cd44a53", @"/Areas/Tesorero/Views/DetalleCuota/DetFaturaCuotaCaja.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df2b2f38e715333060f52fb2cddb5774dc274f4", @"/Areas/Tesorero/Views/_ViewImports.cshtml")]
    public class Areas_Tesorero_Views_DetalleCuota_DetFaturaCuotaCaja : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<SistemaIEBCE.Models.ViewModels.DetaFacVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DetalleCuota", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetalleCuotaCaja", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logoIEBCE.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
  
    ViewData["Title"] = "DetFaturaCuotaCaja";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var fec = 0;
    var num = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row oculto-impresion\">\r\n    <div class=\"col-8\">\r\n        <h1");
            BeginWriteAttribute("class", " class=\"", 298, "\"", 306, 0);
            EndWriteAttribute();
            WriteLiteral(">Comprobante</h1>\r\n    </div>\r\n    <div class=\"col-4 d-flex justify-content-end p-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f13c968dbc2bf5b21acde4bcf31048b6cd44a535982", async() => {
                WriteLiteral(" <i class=\"fa-solid fa-arrow-left\"></i> Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idCaja", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
                                                                             WriteLiteral(TempData["idCaja"].ToString());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idCaja"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idCaja", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idCaja"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
                                                                                                                                WriteLiteral(TempData["idCuota"].ToString());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idCuota"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idCuota", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idCuota"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <a class=\"btn text-white bg-primary m-1\" onclick=\"print()\"><i class=\"fa-solid fa-print\"></i> Imprimir </a>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row bg-white px-4\">\r\n    <div class=\"col-2 p-4\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2f13c968dbc2bf5b21acde4bcf31048b6cd44a539691", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n    <div class=\"col-8 text-center p-lg-4\">\r\n        <h5> INSTITUTO DE EDUCACION BASICA POR COOPERATIVA DE ENSE??ANZA </h5>\r\n        <h5>SANTA CLARA LA LAGUNA</h5>\r\n        <h5>NIT.: 2016526-9  TEL.: 7927-1969</h5>\r\n    </div>\r\n\r\n");
#nullable restore
#line 29 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
         if (fec == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-2 p-4"">
                <div class=""border text-center border-dark p-2"">
                    <h6>RECIBO NO.</h6>
                    <input class=""text-center bg-white border-top-0 border-dark border-left-0 border-right-0 form-control"" type=""number""");
            BeginWriteAttribute("value", " value=\"", 1497, "\"", 1528, 1);
#nullable restore
#line 36 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
WriteAttributeValue("", 1505, item.Factura.NoFactura, 1505, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""col-6 my-3"">
                <div class=""form-group row mt-3"">
                    <label class=""col-sm-2 col-form-label-sm font-weight-bold""> Estudiante </label>
                    <div class=""col-10"">
                        <input class=""form-control bg-white"" type=""text"" name=""name"" readonly");
            BeginWriteAttribute("value", " value=\"", 1914, "\"", 1985, 2);
#nullable restore
#line 44 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
WriteAttributeValue("", 1922, item.Estudiante.NomEstudiante, 1922, 30, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
WriteAttributeValue(" ", 1952, item.Estudiante.ApellEstudiante, 1953, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""col-6 my-3"">
                <div class=""form-group row mt-3"">
                    <label class=""col-sm-2 col-form-label-sm font-weight-bold""> Fecha </label>
                    <div class=""col-10"">
                        <input class=""form-control bg-white"" type=""text"" id=""fecha""");
            BeginWriteAttribute("value", " value=\"", 2375, "\"", 2427, 1);
#nullable restore
#line 53 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
WriteAttributeValue("", 2383, item.Factura.Fecha.Date.ToShortDateString(), 2383, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""col-6"">
                <div class=""form-group row"">
                    <label class=""col-sm-2 col-form-label-sm font-weight-bold""> Grado </label>
                    <div class=""col-10"">
                        <input class=""form-control bg-white"" type=""text"" id=""grado""");
            BeginWriteAttribute("value", " value=\"", 2816, "\"", 2844, 1);
#nullable restore
#line 62 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
WriteAttributeValue("", 2824, item.Grado.NomGrado, 2824, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""col-6"">
                <div class=""form-group row"">
                    <label class=""col-sm-2 col-form-label-sm font-weight-bold""> Secci??n </label>
                    <div class=""col-10"">
                        <input class=""form-control bg-white"" type=""text"" id=""seccion""");
            BeginWriteAttribute("value", " value=\"", 3237, "\"", 3269, 1);
#nullable restore
#line 71 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
WriteAttributeValue("", 3245, item.Seccion.NomSeccion, 3245, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 75 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
            fec = 1;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""col-12 mt-3"">
        <table id=""tblGasto"" class=""table text-primary table-bordered table-responsive-lg table-hover"" style=""width:100%"">
            <thead class=""bg-light text-dark"">
                <tr>
                    <td style=""width:10%"">#</td>
                    <td style=""width:30%"">Tipo</td>
                    <td style=""width:10%"">No. Pagos Establecidos</td>
                    <td style=""width:10%"">Pagos Realizados</td>
                    <td style=""width:10%"">Monto</td>
                    <td style=""width:15%"">Subtotal</td>
                </tr>
            </thead>
            <tbody id=""list"">

");
#nullable restore
#line 94 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 97 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
                       Write(Convert.ToInt32(num++));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 98 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
                       Write(item.Cuota.NomCuota);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 99 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
                       Write(item.Cuota.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 100 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
                       Write(item.DetalleFactura.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 101 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
                       Write(item.DetalleFactura.Monto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> <input class=\"subt bg-white form-control border-0\" type=\"number\"");
            BeginWriteAttribute("value", " value=\"", 4530, "\"", 4610, 1);
#nullable restore
#line 102 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
WriteAttributeValue("", 4538, Convert.ToInt32(item.DetalleFactura.Cantidad*item.DetalleFactura.Monto), 4538, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly /> </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 105 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Tesorero\Views\DetalleCuota\DetFaturaCuotaCaja.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div class=""col-12"">
        <h3 class=""text-right"" id=""TotalCuota""></h3>
    </div>

    <div class=""col-12 p-2"">
        <h5 class=""h3 text-right"" id=""tlsumCuota""> Total Q</h5>
    </div>

</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            var sumSubt = 0;
            $('.subt').each(function () {
                sumSubt += parseFloat($(this).val());
            });

            document.getElementById(""tlsumCuota"").innerHTML += sumSubt;
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<SistemaIEBCE.Models.ViewModels.DetaFacVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
