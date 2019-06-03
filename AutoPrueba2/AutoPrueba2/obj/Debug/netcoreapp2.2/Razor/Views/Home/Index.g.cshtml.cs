#pragma checksum "C:\Users\prisc\source\repos\PruebaVehiculo2\AutoPrueba2\AutoPrueba2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c83060439a53dbc058d381308bb088d3702bbd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\prisc\source\repos\PruebaVehiculo2\AutoPrueba2\AutoPrueba2\Views\_ViewImports.cshtml"
using AutoPrueba2;

#line default
#line hidden
#line 2 "C:\Users\prisc\source\repos\PruebaVehiculo2\AutoPrueba2\AutoPrueba2\Views\_ViewImports.cshtml"
using AutoPrueba2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c83060439a53dbc058d381308bb088d3702bbd8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f82e595f68249ebe3a8dd846a27bbaa1cc10738", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Auto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Lista.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2133, true);
            WriteLiteral(@"<div id=""app"">
    <section class=""container"">
        <div class=""row"">
            <div class=""col-md-8 animated fadeInLeft notransition"">
                <h1 class=""smalltitle"">
                    <span>Registro de Autos</span>
                </h1>

                <table class=""table table-hover"">
                    <thead>
                        <tr>

                            <th>Id</th>

                            <th>Tipo</th>

                            <th>Marca</th>

                            <th>Modelo</th>

                            <th>Color</th>

                            <th>Deposito</th>

                            <th>MatriculaCaracterUno</th>

                            <th>MatriculaCaracterDos   </th>

                            <th>MatriculaCaracterTres</th>

                            <th>Fecha</th>

                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for=""item in vehicul");
            WriteLiteral(@"o "">
                            <td>{{ item.id }}</td>
                            <td>{{ item.tipo }}</td>
                            <td>{{ item.marca }}</td>
                            <td>{{ item.modelo }}</td>
                            <td>{{ item.color}}</td>
                            <td>{{ item.deposito }}</td>
                            <td>{{ item.matriculaCaracterUno }}</td>
                            <td>{{ item.matriculaCaracterDos }}</td>
                            <td>{{ item.matriculaCaracterTres}}</td>
                            <td>{{ item.fecha}}</td>
                            <td>

                                <a :href=""'/Vehiculos/Eliminar/' + item.id"" class=""btn btn-danger"">Eliminar</a>
                                <a :href=""'/Vehiculos/Editar/' + item.id"" class=""btn btn-dark"">Editar</a>
                            </td>
                        </tr>

                    </tbody>
                </table>

            </div>
        </div>
    </s");
            WriteLiteral("ection>\r\n</div>\r\n<a href=\"/Vehiculos/Agregar\" class=\"btn btn-success\">Agregar</a>\r\n\r\n");
            EndContext();
            DefineSection("ScriptsSection", async() => {
                BeginContext(2171, 845, true);
                WriteLiteral(@"

    <script>
        $(document).ready(function () {



            // refresh captcha
            $('img#refresh').click(function () {

                change_captcha();
            });

            function change_captcha() {
                document.getElementById('captcha').src = ""get_captcha.php?rnd="" + Math.random();
            }

            function clear_form() {





                $(""Tipo"").val('');
                $(""Marca"").val('');
                $(""Modelo"").val('');
                $(""Color"").val('');
                $(""Deposito"").val('');
                $(""MatriculaCaracterUno"").val('');
                $(""MatriculaCaracterDos"").val('');
                $(""MatriculaCaracterTres"").val('');
                $(""Fecha"").val('');


            }


        });

    </script>
    ");
                EndContext();
                BeginContext(3016, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c83060439a53dbc058d381308bb088d3702bbd86862", async() => {
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
                EndContext();
                BeginContext(3053, 148, true);
                WriteLiteral("\r\n    <script>\r\n\r\n\r\n        $(document).ready(function () {\r\n            initVue();\r\n            vm.obtenerVehiculo();\r\n        });\r\n    </script>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Auto> Html { get; private set; }
    }
}
#pragma warning restore 1591
