#pragma checksum "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Agenda\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8183de981ecb7dfb365535a540585c4c0f7097f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agenda_Index), @"mvc.1.0.view", @"/Views/Agenda/Index.cshtml")]
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
#line 1 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\_ViewImports.cshtml"
using IndraWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\_ViewImports.cshtml"
using IndraWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8183de981ecb7dfb365535a540585c4c0f7097f6", @"/Views/Agenda/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af6bdea0c285edcc60476a61ef934bc1dff1d39f", @"/Views/_ViewImports.cshtml")]
    public class Views_Agenda_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Backend.AgendaManutencao>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Agenda de Manutenções</h1>\r\n");
#nullable restore
#line 5 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Agenda\Index.cshtml"
Write(Html.ActionLink("Agendar Manutenção", "Create", "Agenda", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<br />\r\n<br />\r\n<table class=\"table table-responsive\">\r\n    <tr>\r\n        <th>Veículo</th>\r\n        <th>Cor</th>\r\n        <th>Placa</th>\r\n        <th>Tipo de Manutenção</th>\r\n        <th>Data</th>\r\n\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 22 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Agenda\Index.cshtml"
     foreach (var agenda in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Agenda\Index.cshtml"
         if (agenda.Data >= DateTime.Today)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 27 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Agenda\Index.cshtml"
           Write(agenda.Carro.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Agenda\Index.cshtml"
           Write(agenda.Carro.Cor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Agenda\Index.cshtml"
           Write(agenda.Carro.Placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Agenda\Index.cshtml"
           Write(agenda.Manutencao.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Agenda\Index.cshtml"
           Write(agenda.Data.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Agenda\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Agenda\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<table>\r\n    <tr>\r\n");
#nullable restore
#line 39 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Agenda\Index.cshtml"
         using (Html.BeginForm("FilterIndex", "Agenda", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><input type=\"submit\" value=\"Filtrar por Placa\" class=\"btn btn-primary\" /></td>\r\n            <td>");
#nullable restore
#line 42 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Agenda\Index.cshtml"
           Write(Html.DropDownList("IdCarro", ViewBag.selectCarros, "selecione", new { @class = "form-control", @required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 43 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Agenda\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n    <tr>  \r\n        <td> {");
#nullable restore
#line 47 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Agenda\Index.cshtml"
         Write(Html.ActionLink("Todos Agendamentos Próximos", "FilterIndex", "Agenda", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Backend.AgendaManutencao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
