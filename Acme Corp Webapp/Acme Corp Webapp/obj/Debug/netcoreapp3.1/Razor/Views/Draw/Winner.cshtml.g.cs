#pragma checksum "C:\Users\rasmu\Desktop\Umbraco hjemmeopgave\Acme Corp Webapp\Acme Corp Webapp\Acme Corp Webapp\Views\Draw\Winner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eef2a3269aa8a6f2aca40444a4bd9ab67d0f4b59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Draw_Winner), @"mvc.1.0.view", @"/Views/Draw/Winner.cshtml")]
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
#line 1 "C:\Users\rasmu\Desktop\Umbraco hjemmeopgave\Acme Corp Webapp\Acme Corp Webapp\Acme Corp Webapp\Views\_ViewImports.cshtml"
using Acme_Corp_Webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rasmu\Desktop\Umbraco hjemmeopgave\Acme Corp Webapp\Acme Corp Webapp\Acme Corp Webapp\Views\_ViewImports.cshtml"
using Acme_Corp_Webapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eef2a3269aa8a6f2aca40444a4bd9ab67d0f4b59", @"/Views/Draw/Winner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15ef1d31554828a2f846e73ac8532d8872f3edb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Draw_Winner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Acme_Corp_Webapp.Models.DrawSubmission>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\rasmu\Desktop\Umbraco hjemmeopgave\Acme Corp Webapp\Acme Corp Webapp\Acme Corp Webapp\Views\Draw\Winner.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>CONGRATULATIONS YOU\'VE WON!</h1>\r\n\r\n<p>As a winner of the Grand Acme Corp Webapp Serialnumber Draw (working title) <br />You get a lifetime supply of nothing!! </p>\r\n\r\n<img src=\"/images/Fireworks-of-various-colo-009.jpg\" alt=\"Pretty Fireworks\" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Acme_Corp_Webapp.Models.DrawSubmission>> Html { get; private set; }
    }
}
#pragma warning restore 1591
