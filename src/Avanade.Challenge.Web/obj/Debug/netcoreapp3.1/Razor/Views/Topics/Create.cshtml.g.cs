#pragma checksum "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Topics\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7da8954fcdb70e16bb36a897613c6586e34385e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topics_Create), @"mvc.1.0.view", @"/Views/Topics/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7da8954fcdb70e16bb36a897613c6586e34385e", @"/Views/Topics/Create.cshtml")]
    public class Views_Topics_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Avanade.Challenge.Api.Infra.Database.Domain.Topic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Topics\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Topic</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form action=""/Topics/Create"" method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div> 
            <div class=""form-group"">
                <label asp-for=""Descricao"" class=""control-label"">Descricao</label>
                <input asp-for=""Descricao"" name=""Descricao"" class=""form-control"" />
                <span asp-validation-for=""Descricao"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
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
#line 33 "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Topics\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Avanade.Challenge.Api.Infra.Database.Domain.Topic> Html { get; private set; }
    }
}
#pragma warning restore 1591
