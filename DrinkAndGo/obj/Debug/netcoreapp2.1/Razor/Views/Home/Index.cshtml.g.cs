#pragma checksum "C:\Users\User\source\repos\DrinkAndGo\DrinkAndGo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47d7116e5d77ab239fa08e3732ef2f9db31222f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\User\source\repos\DrinkAndGo\DrinkAndGo\Views\_ViewImports.cshtml"
using DrinkAndGo.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\DrinkAndGo\DrinkAndGo\Views\_ViewImports.cshtml"
using DrinkAndGo.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47d7116e5d77ab239fa08e3732ef2f9db31222f2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9a0ab34ffee6c183db717432ac165eec8c9124", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(25, 35, false);
#line 3 "C:\Users\User\source\repos\DrinkAndGo\DrinkAndGo\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("Carousel"));

#line default
#line hidden
            EndContext();
            BeginContext(60, 109, true);
            WriteLiteral("\r\n\r\n<h2>Preffered drinks of the week</h2>\r\n<h4>Clients prefernces - just for you!</h4>\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 9 "C:\Users\User\source\repos\DrinkAndGo\DrinkAndGo\Views\Home\Index.cshtml"
     foreach (var drink in Model.PrefferedDrinks)
	{
		

#line default
#line hidden
            BeginContext(224, 35, false);
#line 11 "C:\Users\User\source\repos\DrinkAndGo\DrinkAndGo\Views\Home\Index.cshtml"
   Write(Html.Partial("DrinkSummary", drink));

#line default
#line hidden
            EndContext();
#line 11 "C:\Users\User\source\repos\DrinkAndGo\DrinkAndGo\Views\Home\Index.cshtml"
                                            
	}

#line default
#line hidden
            BeginContext(265, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
