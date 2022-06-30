#pragma checksum "/app/Avanade.Challenge.Web/Views/Phrases/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce3f99eb6dc1362beb9a0a89874906c48a208865"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phrases_Create), @"mvc.1.0.view", @"/Views/Phrases/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce3f99eb6dc1362beb9a0a89874906c48a208865", @"/Views/Phrases/Create.cshtml")]
    public class Views_Phrases_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Avanade.Challenge.Api.Infra.Database.Domain.Phrase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/app/Avanade.Challenge.Web/Views/Phrases/Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Phrase</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form action=""/Phrases/Create"" method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div> 
            <div class=""form-group"">
                <label asp-for=""Expression"" class=""control-label"">Phrase</label>
                <input asp-for=""Expression"" name=""Expression"" class=""form-control"" />
                <span asp-validation-for=""Expression"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""TopicId"" class=""control-label"">Topic</label> 
                ");
#nullable restore
#line 23 "/app/Avanade.Challenge.Web/Views/Phrases/Create.cshtml"
           Write(Html.DropDownList("TopicId", (List<SelectListItem>)ViewBag.listTopics, new { @class="form-control" } ));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      
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
#line 37 "/app/Avanade.Challenge.Web/Views/Phrases/Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Avanade.Challenge.Api.Infra.Database.Domain.Phrase> Html { get; private set; }
    }
}
#pragma warning restore 1591
