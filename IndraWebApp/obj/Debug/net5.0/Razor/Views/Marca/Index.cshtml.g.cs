#pragma checksum "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Marca\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55c18dff6c0c9887ec3bde5fba4ef0b5df411064"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Marca_Index), @"mvc.1.0.view", @"/Views/Marca/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c18dff6c0c9887ec3bde5fba4ef0b5df411064", @"/Views/Marca/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af6bdea0c285edcc60476a61ef934bc1dff1d39f", @"/Views/_ViewImports.cshtml")]
    public class Views_Marca_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Backend.Marca>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Marca</h1>\r\n\r\n");
#nullable restore
#line 7 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Marca\Index.cshtml"
Write(Html.ActionLink("Cadastrar", "Create", "Marca", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n<table class=\"table table-responsive\">\r\n    <tr>\r\n        <th>Nome</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Marca\Index.cshtml"
     foreach (var marca in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Marca\Index.cshtml"
           Write(marca.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 20 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Marca\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id = marca.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Marca\Index.cshtml"
           Write(Html.ActionLink("Excluir", "Delete", new { id = marca.Id }, new { onclick = "return confirm('Deseja realmente excluir? " +
               "Os carros atrelados a esta marca serão excluidos do Banco de Dados');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Marca\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Backend.Marca>> Html { get; private set; }
    }
}
#pragma warning restore 1591