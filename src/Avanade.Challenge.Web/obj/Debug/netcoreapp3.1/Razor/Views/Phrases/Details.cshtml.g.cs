#pragma checksum "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Phrases\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d96bfe37f5b3d55a7af2fac0d1e03b06c7ec2d0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phrases_Details), @"mvc.1.0.view", @"/Views/Phrases/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d96bfe37f5b3d55a7af2fac0d1e03b06c7ec2d0d", @"/Views/Phrases/Details.cshtml")]
    public class Views_Phrases_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Avanade.Challenge.Api.Infra.Database.Domain.Phrase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Phrases\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Phrase</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Phrases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Phrases\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Phrases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Expression));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Phrases\Details.cshtml"
       Write(Html.DisplayFor(model => model.Expression));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Phrases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Topic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Phrases\Details.cshtml"
       Write(Html.DisplayFor(model => model.Topic.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a href=\"/Phrases/Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 917, "\"", 941, 1);
#nullable restore
#line 35 "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Phrases\Details.cshtml"
WriteAttributeValue("", 932, Model.Id, 932, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a href=\"/Phrases\">Back to List</a>\r\n</div>\r\n");
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
