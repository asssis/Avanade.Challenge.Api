#pragma checksum "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Home\Activity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be3c97f8e264b4987ab7e31163fcc36cad784800"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Activity), @"mvc.1.0.view", @"/Views/Home/Activity.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be3c97f8e264b4987ab7e31163fcc36cad784800", @"/Views/Home/Activity.cshtml")]
    public class Views_Home_Activity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Avanade.Challenge.Api.Infra.Database.Domain.Phrase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Home\Activity.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Question</h1>\r\n\r\n<script src=\'https://code.responsivevoice.org/responsivevoice.js\'></script>\r\n<div class=\"form-group\"> \r\n    <input");
            BeginWriteAttribute("onclick", " onclick=\"", 286, "\"", 339, 3);
            WriteAttributeValue("", 296, "responsiveVoice.speak(\'", 296, 23, true);
#nullable restore
#line 12 "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Home\Activity.cshtml"
WriteAttributeValue("", 319, Model.Expression, 319, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 336, "\');", 336, 3, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"" type='button' value='🔊 Play' />
</div>

<div class=""form-group"">
    <label asp-for=""Expression"" class=""control-label"">Answer</label>
    <input asp-for=""Expression"" name=""Expression"" class=""form-control"" />
     <input class=""btn btn-primary"" type='button' value='Verificar' />
</div>


<script>
    responsiveVoice.speak('");
#nullable restore
#line 23 "C:\Users\assis.siebra.barbosa\projetos\Avanade.Challenge.Api\src\Avanade.Challenge.Web\Views\Home\Activity.cshtml"
                      Write(Model.Expression);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n</script>");
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
