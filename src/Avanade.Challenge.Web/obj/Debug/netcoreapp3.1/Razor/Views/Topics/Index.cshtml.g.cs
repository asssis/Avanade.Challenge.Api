#pragma checksum "C:\Users\asjus\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Topics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93b6304c66dc97ac7fe7fe348f808eb91dadbddf"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93b6304c66dc97ac7fe7fe348f808eb91dadbddf", @"/Views/Topics/Index.cshtml")]
    public class Views_Topics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Avanade.Challenge.Api.Infra.Database.Domain.Topic>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\asjus\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Topics\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\asjus\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Topics\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\asjus\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Topics\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "C:\Users\asjus\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Topics\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 651, "\"", 674, 1);
#nullable restore
#line 29 "C:\Users\asjus\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Topics\Index.cshtml"
WriteAttributeValue("", 666, item.Id, 666, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 727, "\"", 750, 1);
#nullable restore
#line 30 "C:\Users\asjus\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Topics\Index.cshtml"
WriteAttributeValue("", 742, item.Id, 742, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 805, "\"", 828, 1);
#nullable restore
#line 31 "C:\Users\asjus\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Topics\Index.cshtml"
WriteAttributeValue("", 820, item.Id, 820, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\asjus\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Topics\Index.cshtml"
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
