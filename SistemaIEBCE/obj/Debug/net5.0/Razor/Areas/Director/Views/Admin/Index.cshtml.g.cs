#pragma checksum "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Director\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b189bc606c5146a0a294d2537754cdf95b203cdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Director_Views_Admin_Index), @"mvc.1.0.view", @"/Areas/Director/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Director\Views\_ViewImports.cshtml"
using SistemaIEBCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Director\Views\_ViewImports.cshtml"
using SistemaIEBCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b189bc606c5146a0a294d2537754cdf95b203cdc", @"/Areas/Director/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df2b2f38e715333060f52fb2cddb5774dc274f4", @"/Areas/Director/Views/_ViewImports.cshtml")]
    public class Areas_Director_Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Director", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Grado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Seccion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Curso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bloque", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catedratico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CicloEscolar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Nitro 7\Documents\X Semestre\Sistema\SistemaIEBCE.v1\SistemaIEBCE\Areas\Director\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"mt-4\">Administración</h1>\r\n\r\n<div class=\"container-fluid\">\r\n    <section>\r\n        <div class=\"row\">\r\n            <div class=\"col-xl-4 col-sm-6 col-12 mb-4\">\r\n                <div class=\"card shadow\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b189bc606c5146a0a294d2537754cdf95b203cdc6609", async() => {
                WriteLiteral(@"
                        <div class=""card-body"">
                            <div class=""d-flex justify-content-between px-md-1"">
                                <div class=""align-self-center"">
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""40"" height=""50"" viewBox=""0 0 40 50"">
                                        <path id=""Trazado_470"" data-name=""Trazado 470"" d=""M5,0H35a4.852,4.852,0,0,1,5,4.688V47.627A2.459,2.459,0,0,1,37.469,50a2.64,2.64,0,0,1-1.458-.43L20,39.063,3.987,49.57A2.623,2.623,0,0,1,2.534,50,2.459,2.459,0,0,1,0,47.627V4.688A4.851,4.851,0,0,1,5,0Z"" fill=""#17172b"" />
                                    </svg>
                                </div>
                                <div class=""col-9 text-right"">
                                    <h3 class=""text-nowrap text-primary"">Grados</h3>
                                    <p class=""mb-0 text-secondary"">Gestionar grados del centro educativo</p>
                                </div>
           ");
                WriteLiteral(@"                 </div>
                            <div class=""px-md-1"">
                                <div class=""progress mt-3 mb-1 rounded"" style=""height: 7px;"">
                                    <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 100%;"" aria-valuenow=""60""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-xl-4 col-sm-6 col-12 mb-4\">\r\n                <div class=\"card shadow\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b189bc606c5146a0a294d2537754cdf95b203cdc10046", async() => {
                WriteLiteral(@"

                        <div class=""card-body"">
                            <div class=""d-flex justify-content-between px-md-1"">
                                <div class=""align-self-center"">
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""50"" height=""50"" viewBox=""0 0 50 50"">
                                        <path id=""Trazado_472"" data-name=""Trazado 472"" d=""M6.25,48.438A1.57,1.57,0,0,1,4.688,50H1.563A1.57,1.57,0,0,1,0,48.438V3.125a3.125,3.125,0,0,1,6.25,0ZM46.514,0a4.568,4.568,0,0,0-1.889.413C40.163,2.45,36.855,3.142,34.1,3.142,28.242,3.142,24.839.031,18.092.03A30.156,30.156,0,0,0,9.375,1.538V35.767a27.694,27.694,0,0,1,8.286-1.377c7.19,0,12.2,3.1,19.395,3.1a28.938,28.938,0,0,0,10.85-2.255A3.018,3.018,0,0,0,50,32.432V3C50,1.084,48.369,0,46.514,0Z"" fill=""#17172b"" />
                                    </svg>
                                </div>
                                <div class=""col-9 text-right"">
                                    <h3 class=""te");
                WriteLiteral(@"xt-nowrap text-primary"">Secciones</h3>
                                    <p class=""mb-0 text-secondary"">Gestionar secciones para los grados</p>
                                </div>
                            </div>
                            <div class=""px-md-1"">
                                <div class=""progress mt-3 mb-1 rounded"" style=""height: 7px;"">
                                    <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 100%;"" aria-valuenow=""60""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-xl-4 col-sm-6 col-12 mb-4\">\r\n                <div class=\"card shadow\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b189bc606c5146a0a294d2537754cdf95b203cdc13683", async() => {
                WriteLiteral(@"
                        <div class=""card-body"">
                            <div class=""d-flex justify-content-between px-md-1"">
                                <div class=""align-self-center"">
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""50"" height=""50"" viewBox=""0 0 50 50"">
                                        <path id=""Trazado_471"" data-name=""Trazado 471"" d=""M0,3.125A3.125,3.125,0,0,1,3.125,0h12.5A3.124,3.124,0,0,1,18.75,3.125v37.5a9.375,9.375,0,0,1-18.75,0ZM12.5,6.25H6.25V12.5H12.5ZM6.25,25H12.5V18.75H6.25ZM9.375,42.969a2.344,2.344,0,1,0-2.344-2.344A2.338,2.338,0,0,0,9.375,42.969Zm12.5-2.344V15.039l7.363-7.36a3.13,3.13,0,0,1,4.424,0L42.5,16.514a3.13,3.13,0,0,1,0,4.424L21.836,41.592c.029-.312.039-.645.039-.967ZM36.6,31.25H46.875A3.122,3.122,0,0,1,50,34.375v12.5A3.122,3.122,0,0,1,46.875,50H17.852Z"" fill=""#17172b"" />
                                    </svg>
                                </div>
                                <div class=""col-9 text-right"">
");
                WriteLiteral(@"                                    <h3 class=""text-nowrap text-primary"">Cursos</h3>
                                    <p class=""mb-0 text-secondary"">Gestionar cursos del centro educativo</p>
                                </div>
                            </div>
                            <div class=""px-md-1"">
                                <div class=""progress mt-3 mb-1 rounded"" style=""height: 7px;"">
                                    <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 100%;"" aria-valuenow=""60""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-xl-4 col-sm-6 col-12 mb-4\">\r\n                <div class=\"card shadow\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b189bc606c5146a0a294d2537754cdf95b203cdc17421", async() => {
                WriteLiteral(@"
                        <div class=""card-body"">
                            <div class=""d-flex justify-content-between px-md-1"">
                                <div class=""align-self-center"">
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""50"" height=""50"" viewBox=""0 0 50 50"">
                                        <path id=""Trazado_473"" data-name=""Trazado 473"" d=""M46.429,39.143H3.571a3.571,3.571,0,1,1,0-7.143H46.429a3.571,3.571,0,1,1,0,7.143Zm0,28.571H3.571a3.571,3.571,0,0,1,0-7.143H46.429a3.571,3.571,0,1,1,0,7.143ZM0,49.857a3.57,3.57,0,0,1,3.571-3.571H46.429a3.571,3.571,0,0,1,0,7.143H3.571A3.57,3.57,0,0,1,0,49.857ZM46.429,82H3.571a3.571,3.571,0,0,1,0-7.143H46.429a3.571,3.571,0,1,1,0,7.143Z"" transform=""translate(0 -32)"" fill=""#17172b"" />
                                    </svg>
                                </div>
                                <div class=""col-9 text-right"">
                                    <h3 class=""text-nowrap text-primary"">Bloque</h3>");
                WriteLiteral(@"
                                    <p class=""mb-0 text-secondary"">Gestionar los bloques de trabajo </p>
                                </div>
                            </div>
                            <div class=""px-md-1"">
                                <div class=""progress mt-3 mb-1 rounded"" style=""height: 7px;"">
                                    <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 100%;"" aria-valuenow=""60""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-xl-4 col-sm-6 col-12 mb-4\">\r\n                <div class=\"card shadow\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b189bc606c5146a0a294d2537754cdf95b203cdc21020", async() => {
                WriteLiteral(@"

                        <div class=""card-body"">
                            <div class=""d-flex justify-content-between px-md-1"">
                                <div class=""align-self-center"">
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""50"" height=""57.143"" viewBox=""0 0 50 57.143"">
                                        <path id=""Trazado_474"" data-name=""Trazado 474"" d=""M39.286,14.286A14.286,14.286,0,1,1,25,0,14.285,14.285,0,0,1,39.286,14.286Zm-15.949,25.8-3.694-6.161H30.357l-3.694,6.161,3.717,13.828,4.408-17.991A18.008,18.008,0,0,1,50,53.717a3.434,3.434,0,0,1-3.426,3.426H3.429A3.431,3.431,0,0,1,0,53.717a18.007,18.007,0,0,1,15.212-17.79l4.408,17.991Z"" fill=""#17172b"" />
                                    </svg>
                                </div>
                                <div class=""col-9 text-right"">
                                    <h3 class=""text-nowrap text-primary"">Catedráticos</h3>
                                    <p class=""mb-0 text-sec");
                WriteLiteral(@"ondary"">Gestionar datos de los catedráticos</p>
                                </div>
                            </div>
                            <div class=""px-md-1"">
                                <div class=""progress mt-3 mb-1 rounded"" style=""height: 7px;"">
                                    <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 100%;"" aria-valuenow=""60""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-xl-4 col-sm-6 col-12 mb-4\">\r\n                <div class=\"card shadow\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b189bc606c5146a0a294d2537754cdf95b203cdc24558", async() => {
                WriteLiteral(@"
                        <div class=""card-body"">
                            <div class=""d-flex justify-content-between px-md-1"">
                                <div class=""align-self-center"">
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""50"" height=""57.143"" viewBox=""0 0 50 57.143"">
                                        <path id=""Trazado_475"" data-name=""Trazado 475"" d=""M17.857,3.571V7.143H32.143V3.571a3.571,3.571,0,1,1,7.143,0V7.143h5.357A5.358,5.358,0,0,1,50,12.5v5.357H0V12.5A5.357,5.357,0,0,1,5.357,7.143h5.357V3.571a3.571,3.571,0,0,1,7.143,0ZM0,21.429H50V51.786a5.359,5.359,0,0,1-5.357,5.357H5.357A5.358,5.358,0,0,1,0,51.786ZM33.94,33.94a2.424,2.424,0,0,0,0-3.694,2.58,2.58,0,0,0-3.694,0L25,35.5l-5.346-5.257A2.612,2.612,0,1,0,15.96,33.94l5.257,5.346L15.96,44.531a2.58,2.58,0,0,0,0,3.694,2.424,2.424,0,0,0,3.694,0L25,43.069l5.246,5.156a2.612,2.612,0,0,0,3.694-3.694l-5.156-5.246Z"" fill=""#17172b"" />
                                    </svg>
                           ");
                WriteLiteral(@"     </div>
                                <div class=""col-9 text-right"">
                                    <h3 class=""text-nowrap text-primary"">Ciclo Escolar</h3>
                                    <p class=""mb-0 text-secondary"">Cerrar ciclo escolar actual</p>
                                </div>
                            </div>
                            <div class=""px-md-1"">
                                <div class=""progress mt-3 mb-1 rounded"" style=""height: 7px;"">
                                    <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 100%;"" aria-valuenow=""60""
                                         aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </section>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
