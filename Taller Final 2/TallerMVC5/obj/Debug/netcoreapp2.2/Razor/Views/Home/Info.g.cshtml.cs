#pragma checksum "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\Home\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe93c61ee1029ae0d18a8ba453e6c6689997071a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Info), @"mvc.1.0.view", @"/Views/Home/Info.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Info.cshtml", typeof(AspNetCore.Views_Home_Info))]
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
#line 1 "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\_ViewImports.cshtml"
using TallerMVC5;

#line default
#line hidden
#line 2 "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\_ViewImports.cshtml"
using TallerMVC5.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe93c61ee1029ae0d18a8ba453e6c6689997071a", @"/Views/Home/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b22516509ccc92c4b03e347d6d676809583d03fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\Home\Info.cshtml"
  
    ViewData["Title"] = "Resultados";

#line default
#line hidden
            BeginContext(48, 93, true);
            WriteLiteral("\r\n<h1>Informacion</h1>\r\n<p>De acuerdo a los datos ingresados:</p>\r\n<strong>Nombre</strong> : ");
            EndContext();
            BeginContext(142, 18, false);
#line 8 "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\Home\Info.cshtml"
                     Write(ViewData["Nombre"]);

#line default
#line hidden
            EndContext();
            BeginContext(160, 36, true);
            WriteLiteral("<br />\r\n<strong>Apellido</strong> : ");
            EndContext();
            BeginContext(197, 20, false);
#line 9 "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\Home\Info.cshtml"
                       Write(ViewData["Apellido"]);

#line default
#line hidden
            EndContext();
            BeginContext(217, 43, true);
            WriteLiteral("<br />\r\n<strong>Numero de horas</strong> : ");
            EndContext();
            BeginContext(261, 39, false);
#line 10 "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\Home\Info.cshtml"
                              Write(Math.Abs((int)ViewData["Numero_horas"]));

#line default
#line hidden
            EndContext();
            BeginContext(300, 38, true);
            WriteLiteral("<br />\r\n<strong>Valor hora</strong> : ");
            EndContext();
            BeginContext(339, 38, false);
#line 11 "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\Home\Info.cshtml"
                         Write(Math.Abs((int)ViewData["Valor_horas"]));

#line default
#line hidden
            EndContext();
            BeginContext(377, 43, true);
            WriteLiteral("<br />\r\n<strong>Nivel de riesgo</strong> : ");
            EndContext();
            BeginContext(421, 34, false);
#line 12 "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\Home\Info.cshtml"
                              Write(Math.Abs((int)@ViewData["Riesgo"]));

#line default
#line hidden
            EndContext();
            BeginContext(455, 10, true);
            WriteLiteral("<br />\r\n\r\n");
            EndContext();
#line 14 "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\Home\Info.cshtml"
  
    Usuario user = new Usuario();

    user.Riesgo = (int)ViewData["Riesgo"];
    user.Valor_horas = (int)ViewData["Valor_horas"];
    user.Numero_horas = (int)ViewData["Numero_horas"];

    var result = user.CalcularSalario();




#line default
#line hidden
            BeginContext(713, 35, true);
            WriteLiteral("\r\n<strong>Salario bruto</strong> : ");
            EndContext();
            BeginContext(749, 15, false);
#line 27 "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\Home\Info.cshtml"
                            Write(result["bruto"]);

#line default
#line hidden
            EndContext();
            BeginContext(764, 33, true);
            WriteLiteral("<br />\r\n<strong>Salud</strong> : ");
            EndContext();
            BeginContext(798, 15, false);
#line 28 "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\Home\Info.cshtml"
                    Write(result["salud"]);

#line default
#line hidden
            EndContext();
            BeginContext(813, 35, true);
            WriteLiteral("<br />\r\n<strong>Pension</strong> : ");
            EndContext();
            BeginContext(849, 17, false);
#line 29 "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\Home\Info.cshtml"
                      Write(result["pension"]);

#line default
#line hidden
            EndContext();
            BeginContext(866, 35, true);
            WriteLiteral("<br />\r\n<strong>Riesgos</strong> : ");
            EndContext();
            BeginContext(902, 16, false);
#line 30 "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\Home\Info.cshtml"
                      Write(result["riesgo"]);

#line default
#line hidden
            EndContext();
            BeginContext(918, 36, true);
            WriteLiteral("<br />\r\n<strong>Total descuentos :  ");
            EndContext();
            BeginContext(955, 20, false);
#line 31 "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\Home\Info.cshtml"
                       Write(result["descuentos"]);

#line default
#line hidden
            EndContext();
            BeginContext(975, 54, true);
            WriteLiteral(" </strong> <br />\r\n<strong>Salario neto :   </strong> ");
            EndContext();
            BeginContext(1030, 20, false);
#line 32 "C:\Users\Laika\Documents\EAN-Programacion.NET\Taller Final 2\TallerMVC5\Views\Home\Info.cshtml"
                              Write(result["diferencia"]);

#line default
#line hidden
            EndContext();
            BeginContext(1050, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
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
