#pragma checksum "/app/Avanade.Challenge.Web/Views/Topics/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af24bdf6b72221ae7d567616c61a0538509ccde2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topics_Index), @"mvc.1.0.view", @"/Views/Topics/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af24bdf6b72221ae7d567616c61a0538509ccde2", @"/Views/Topics/Index.cshtml")]
    public class Views_Topics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Avanade.Challenge.Api.Infra.Database.Domain.Topic>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/app/Avanade.Challenge.Web/Views/Topics/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\" href=\"/Topics/Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "/app/Avanade.Challenge.Web/Views/Topics/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "/app/Avanade.Challenge.Web/Views/Topics/Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "/app/Avanade.Challenge.Web/Views/Topics/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 673, "\"", 696, 1);
#nullable restore
#line 29 "/app/Avanade.Challenge.Web/Views/Topics/Index.cshtml"
WriteAttributeValue("", 688, item.Id, 688, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 697, "\"", 725, 2);
            WriteAttributeValue("", 704, "/Topics/Edit/", 704, 13, true);
#nullable restore
#line 29 "/app/Avanade.Challenge.Web/Views/Topics/Index.cshtml"
WriteAttributeValue("", 717, item.Id, 717, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 778, "\"", 801, 1);
#nullable restore
#line 30 "/app/Avanade.Challenge.Web/Views/Topics/Index.cshtml"
WriteAttributeValue("", 793, item.Id, 793, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 802, "\"", 833, 2);
            WriteAttributeValue("", 809, "/Topics/Details/", 809, 16, true);
#nullable restore
#line 30 "/app/Avanade.Challenge.Web/Views/Topics/Index.cshtml"
WriteAttributeValue("", 825, item.Id, 825, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 888, "\"", 911, 1);
#nullable restore
#line 31 "/app/Avanade.Challenge.Web/Views/Topics/Index.cshtml"
WriteAttributeValue("", 903, item.Id, 903, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 912, "\"", 942, 2);
            WriteAttributeValue("", 919, "/Topics/Delete/", 919, 15, true);
#nullable restore
#line 31 "/app/Avanade.Challenge.Web/Views/Topics/Index.cshtml"
WriteAttributeValue("", 934, item.Id, 934, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "/app/Avanade.Challenge.Web/Views/Topics/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Avanade.Challenge.Api.Infra.Database.Domain.Topic>> Html { get; private set; }
    }
}
#pragma warning restore 1591
