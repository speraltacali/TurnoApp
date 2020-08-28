#pragma checksum "C:\Users\santi\source\repos\speraltacali\TurnoApp\TA.TurnoApp\TurnosMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63d30394a95af437c517c7b27dfe7aa46519edcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\santi\source\repos\speraltacali\TurnoApp\TA.TurnoApp\TurnosMVC\Views\_ViewImports.cshtml"
using TurnosMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\santi\source\repos\speraltacali\TurnoApp\TA.TurnoApp\TurnosMVC\Views\_ViewImports.cshtml"
using TurnosMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63d30394a95af437c517c7b27dfe7aa46519edcc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"313c4093843dd446b51c32781b9be55513bec7ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\santi\source\repos\speraltacali\TurnoApp\TA.TurnoApp\TurnosMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <main>

        <div class=""img-header"">
            <div class=""welcome"">
                <br>
                <br>
                <h1>Bienvenidos al sistemas de turnos</h1>
                <hr>
                <p>Agencia de diseño y desarrolo web</p>
                <br>
                <button id=""abajo"">Ver Abajo</button>
            </div>
        </div>

        <!-- Acerca de nosotros  -->

        <section class=""acerca-de"">

            <div class=""info-container"">
                Acerca de nosotros
                <p>Es importante tener en cuenta que las capacidades de Entity Framework en .NET ""tradicional"" (EF6) y en .NET Core (EF Core) son completamente diferentes. Así, los tres modos de trabajo descritos a continuación están completamente soportados en EF6, pero EF Core solamente soporta ""Code First"" y muy poquito de ""Database First"". ""Model First"" en .NET Core ni está ni se le espera. A continuación lo detallaremos más.</p>
                <p>En este modo se parte de ");
            WriteLiteral(@"una base de datos pre-existente con la que queremos trabajar. Es decir, tenemos la base de datos ya diseñada y probablemente con datos y lo que queremos es que EF se encargue de generar las clases necesarias y toda la ""fontanería"" interna para trabajar con ella.</p>

                <div class=""about-gallery"">
                    <img src=""img/fondo02.png""");
            BeginWriteAttribute("alt", " alt=\"", 1430, "\"", 1436, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"img/fondo03.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1486, "\"", 1492, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"img/fondo04.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1542, "\"", 1548, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>

                <div class=""about-more""><button>Ver mas</button></div>

            </div>

        </section>

        <!-- Nuevos proyectos -->

        <section class=""out-proyects"">

            <div class=""deg-background""></div>

            <div class=""ejeZproyect"">
                <div class=""container-proyect"">
                    <div class=""proyect-title"">
                        <h2>Nuevas Empresas</h2>
                        <hr>
                    </div>

                    <div class=""proyect-img"">
                        <img src=""img/fondo05.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2169, "\"", 2175, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img src=\"img/fondo06.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2229, "\"", 2235, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img src=\"img/fondo07.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2289, "\"", 2295, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
        </section>

        <!-- Testimonios -->

        <section class=""testimonios"">

            <div class=""testimonio-title"">
                <h2>Empleados</h2>
                <hr>
            </div>

            <div class=""box-testimonio"">

                <div class=""card-testimonio"">

                    <div class=""card-img"">
                        <img src=""img/eduard.jpeg""");
            BeginWriteAttribute("alt", " alt=\"", 2777, "\"", 2783, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>

                    <div class=""testimonio-text"">
                        <h4>Eduard Snowden</h4>
                        <p>Edward Joseph Snowden (born June 21, 1983) is an American whistleblower who copied and leaked highly classified information from the National Security Agency (NSA) in 2013 when he was a Central Intelligence Agency (CIA) employee and subcontractor. His disclosures revealed numerous global surveillance programs, many run by the NSA and the Five Eyes Intelligence Alliance with the cooperation of telecommunication companies and European governments, and prompted a cultural discussion about national security and individual privacy.</p>
                    </div>

                </div>

            </div>

        </section>

    </main>
");
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