#pragma checksum "C:\Estudos Programação\entityFramework\identity\webApp.identity\Views\Home\Sucess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cd7a07f21d67f2890d005bf8c7a5a20f28fcc20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Sucess), @"mvc.1.0.view", @"/Views/Home/Sucess.cshtml")]
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
#line 1 "C:\Estudos Programação\entityFramework\identity\webApp.identity\Views\_ViewImports.cshtml"
using webApp.identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Estudos Programação\entityFramework\identity\webApp.identity\Views\_ViewImports.cshtml"
using webApp.identity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cd7a07f21d67f2890d005bf8c7a5a20f28fcc20", @"/Views/Home/Sucess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f722f8571f48b6b95df23c9d9ea80c174270bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Sucess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Sucess</h1>\r\n\r\n\r\n<h2></h2>\r\n<ul>\r\n");
#nullable restore
#line 6 "C:\Estudos Programação\entityFramework\identity\webApp.identity\Views\Home\Sucess.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <b>\r\n                ");
#nullable restore
#line 10 "C:\Estudos Programação\entityFramework\identity\webApp.identity\Views\Home\Sucess.cshtml"
           Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </b>\r\n               ");
#nullable restore
#line 12 "C:\Estudos Programação\entityFramework\identity\webApp.identity\Views\Home\Sucess.cshtml"
          Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </li>\r\n");
#nullable restore
#line 15 "C:\Estudos Programação\entityFramework\identity\webApp.identity\Views\Home\Sucess.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591