#pragma checksum "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Manutencao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "864673931e789556a72e9c0d3bd47d718888a089"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manutencao_Index), @"mvc.1.0.view", @"/Views/Manutencao/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"864673931e789556a72e9c0d3bd47d718888a089", @"/Views/Manutencao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af6bdea0c285edcc60476a61ef934bc1dff1d39f", @"/Views/_ViewImports.cshtml")]
    public class Views_Manutencao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Backend.Manutencao>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Serviços de Manutenção</h1>\r\n\r\n");
#nullable restore
#line 5 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Manutencao\Index.cshtml"
Write(Html.ActionLink("Cadastrar", "Create", "Manutencao", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n<table class=\"table table-responsive\">\r\n    <tr>\r\n        <th>Nome</th>\r\n        <th>Próxima Manutenção (Km)</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Manutencao\Index.cshtml"
     foreach (var manutencao in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Manutencao\Index.cshtml"
           Write(manutencao.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Manutencao\Index.cshtml"
           Write(manutencao.ProximaManutencao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 20 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Manutencao\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id = manutencao.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Manutencao\Index.cshtml"
           Write(Html.ActionLink("Excluir", "Delete", new { id = manutencao.Id }, new { onclick = "return confirm('Deseja realmente excluir?');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Manutencao\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 26 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Manutencao\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Backend.Manutencao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
