#pragma checksum "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03cc92d221f6f6ec730d1c010471b1c92c15ab67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carro_Index), @"mvc.1.0.view", @"/Views/Carro/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03cc92d221f6f6ec730d1c010471b1c92c15ab67", @"/Views/Carro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af6bdea0c285edcc60476a61ef934bc1dff1d39f", @"/Views/_ViewImports.cshtml")]
    public class Views_Carro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Backend.Carro>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Carros</h1>\r\n\r\n");
#nullable restore
#line 5 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
Write(Html.ActionLink("Cadastrar", "Create", "Carro", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
Write(Html.ActionLink("Resetar Filtros", "Index", "Carro", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n<table class=\"table table-responsive\">\r\n    <tr>\r\n        <th>Nome</th>\r\n        <th>Modelo</th>\r\n        <th>Fabricacao</th>\r\n        <th>Cor</th>\r\n        <th>Placa</th>\r\n        <th>Marca</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
     foreach (var carro in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
           Write(carro.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
           Write(carro.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
           Write(carro.Ano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
           Write(carro.Cor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
           Write(carro.Placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
           Write(carro.Marca.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
           Write(Html.ActionLink("Registro", "Details", "Registro", new { id = carro.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 31 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
           Write(Html.ActionLink("Agendamentos", "Details", "Agenda", new { id = carro.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 32 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id = carro.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 33 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
           Write(Html.ActionLink("Excluir", "Delete", new { id = carro.Id }, new { onclick = "return confirm('Deseja realmente excluir?');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tr>\r\n");
#nullable restore
#line 35 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<table>\r\n    <tr>\r\n");
#nullable restore
#line 40 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
         using (Html.BeginForm("FilterIndex", "Carro", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><input type=\"submit\" value=\"Filtrar por Placa \" class=\"btn btn-primary\" /></td>\r\n            <td>");
#nullable restore
#line 43 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
           Write(Html.TextBox("Placa", null, new { @class = "form-control", @required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 44 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n    <tr>\r\n");
#nullable restore
#line 47 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
         using (Html.BeginForm("FilterIndex", "Carro", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><input type=\"submit\" value=\"Filtrar por Marca\" class=\"btn btn-primary\" /></td>\r\n            <td> ");
#nullable restore
#line 50 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
            Write(Html.DropDownList("Marca", ViewBag.selectMarcas, "selecione", new { @class = "form-control", @required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 51 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n</table>\r\n");
#nullable restore
#line 54 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Carro\Index.cshtml"
Write(Html.ActionLink("Voltar", "Index", "Home", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Backend.Carro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
