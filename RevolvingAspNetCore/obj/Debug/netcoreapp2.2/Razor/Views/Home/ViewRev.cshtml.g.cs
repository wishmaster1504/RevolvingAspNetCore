#pragma checksum "F:\GitHub\RevolvingAspNetCore\RevolvingAspNetCore\Views\Home\ViewRev.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "429b81bf19b9d2f26a570da92521463edab374cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewRev), @"mvc.1.0.view", @"/Views/Home/ViewRev.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewRev.cshtml", typeof(AspNetCore.Views_Home_ViewRev))]
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
#line 1 "F:\GitHub\RevolvingAspNetCore\RevolvingAspNetCore\Views\_ViewImports.cshtml"
using RevolvingAspNetCore;

#line default
#line hidden
#line 2 "F:\GitHub\RevolvingAspNetCore\RevolvingAspNetCore\Views\_ViewImports.cshtml"
using RevolvingAspNetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"429b81bf19b9d2f26a570da92521463edab374cc", @"/Views/Home/ViewRev.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"470865dd860b7766f332514ee9982e0f0959ffd6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewRev : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ew0pf>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\GitHub\RevolvingAspNetCore\RevolvingAspNetCore\Views\Home\ViewRev.cshtml"
  
    ViewData["Title"] = "Список договоров";  

#line default
#line hidden
            BeginContext(74, 304, true);
            WriteLiteral(@"

<h1>Договора страхования</h1>
 

<table class=""table"">
    <thead>
        <tr>
            <th>
                Номер договора страхования
            </th>
            <th>
                Статус договора
            </th>
        </tr>
    </thead>

    <tbody>
      
       

");
            EndContext();
#line 26 "F:\GitHub\RevolvingAspNetCore\RevolvingAspNetCore\Views\Home\ViewRev.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(426, 70, true);
            WriteLiteral("        <tr>\r\n            <td style=\"width:300px\">  \r\n                ");
            EndContext();
            BeginContext(497, 87, false);
#line 30 "F:\GitHub\RevolvingAspNetCore\RevolvingAspNetCore\Views\Home\ViewRev.cshtml"
           Write(Html.ActionLink(@item.Anr, "Details", "Home", new { anr = @item.Anr, ncd = @item.Ncd }));

#line default
#line hidden
            EndContext();
            BeginContext(584, 77, true);
            WriteLiteral("\r\n\r\n            </td>\r\n            <td style=\"width:100px\">\r\n                ");
            EndContext();
            BeginContext(662, 8, false);
#line 34 "F:\GitHub\RevolvingAspNetCore\RevolvingAspNetCore\Views\Home\ViewRev.cshtml"
           Write(item.Sts);

#line default
#line hidden
            EndContext();
            BeginContext(670, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 37 "F:\GitHub\RevolvingAspNetCore\RevolvingAspNetCore\Views\Home\ViewRev.cshtml"
        }

#line default
#line hidden
            BeginContext(717, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ew0pf>> Html { get; private set; }
    }
}
#pragma warning restore 1591
