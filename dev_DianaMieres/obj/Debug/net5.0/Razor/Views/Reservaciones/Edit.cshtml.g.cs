#pragma checksum "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bdaa07e19f58821ac31d938035aedf49651cdb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservaciones_Edit), @"mvc.1.0.view", @"/Views/Reservaciones/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bdaa07e19f58821ac31d938035aedf49651cdb4", @"/Views/Reservaciones/Edit.cshtml")]
    public class Views_Reservaciones_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dev_DianaMieres.Models.Reservacione>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Reservacione</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""FechaInicio"" class=""control-label""></label>
                <input asp-for=""FechaInicio"" class=""form-control"" />
                <span asp-validation-for=""FechaInicio"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""FechaFin"" class=""control-label""></label>
                <input asp-for=""FechaFin"" class=""form-control"" />
                <span asp-validation-for=""FechaFin"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Entregado"" class=""control-label""></label>
                <input asp-for=""Entregado"" class=""form-control"" />
             ");
            WriteLiteral(@"   <span asp-validation-for=""Entregado"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""IdCliente"" class=""control-label""></label>
                <input asp-for=""IdCliente"" class=""form-control"" />
                <span asp-validation-for=""IdCliente"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""IdSala"" class=""control-label""></label>
                <select asp-for=""IdSala"" class=""form-control"" asp-items=""ViewBag.IdSala""></select>
                <span asp-validation-for=""IdSala"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Fecha"" class=""control-label""></label>
                <input asp-for=""Fecha"" class=""form-control"" />
                <span asp-validation-for=""Fecha"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Ho");
            WriteLiteral(@"raInicio"" class=""control-label""></label>
                <input asp-for=""HoraInicio"" class=""form-control"" />
                <span asp-validation-for=""HoraInicio"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""HoraFin"" class=""control-label""></label>
                <input asp-for=""HoraFin"" class=""form-control"" />
                <span asp-validation-for=""HoraFin"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 68 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dev_DianaMieres.Models.Reservacione> Html { get; private set; }
    }
}
#pragma warning restore 1591