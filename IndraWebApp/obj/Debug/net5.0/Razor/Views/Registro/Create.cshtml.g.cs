#pragma checksum "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Registro\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e76b6229753b606ec20622156bf80118d0e8c349"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registro_Create), @"mvc.1.0.view", @"/Views/Registro/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e76b6229753b606ec20622156bf80118d0e8c349", @"/Views/Registro/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af6bdea0c285edcc60476a61ef934bc1dff1d39f", @"/Views/_ViewImports.cshtml")]
    public class Views_Registro_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Backend.RegistroManutencao>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Adicionar Registro</h1>\r\n\r\n");
#nullable restore
#line 4 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Registro\Create.cshtml"
 using (Html.BeginForm("Create", "Registro", FormMethod.Post))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-3\">\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 9 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Registro\Create.cshtml"
       Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 10 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Registro\Create.cshtml"
       Write(Html.Label("Placa"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 11 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Registro\Create.cshtml"
       Write(Html.DropDownList("IdCarro", ViewBag.selectCarros, "selecione", new { @class = "form-control", @required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 14 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Registro\Create.cshtml"
       Write(Html.Label("Tipo de Manutenção"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 15 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Registro\Create.cshtml"
       Write(Html.DropDownList("IdManutencao", ViewBag.selectManutencoes, "selecione", new { @class = "form-control", @required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 18 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Registro\Create.cshtml"
       Write(Html.Label("Quilometragem"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 19 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Registro\Create.cshtml"
       Write(Html.TextBoxFor(x => x.Quilometragem, new { @class = "form-control", @required = true, @type = "number", @min = "0" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n\r\n    <input type=\"submit\" value=\"Salvar\" class=\"btn btn-primary\" />\r\n    ");
#nullable restore
#line 25 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Registro\Create.cshtml"
Write(Html.ActionLink("Voltar", "Index", "Home", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
#nullable restore
#line 28 "E:\Downloads\Bootcamps\Indra dotnet\Projeto Indra\IndraWebApp\Views\Registro\Create.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Backend.RegistroManutencao> Html { get; private set; }
    }
}
#pragma warning restore 1591
