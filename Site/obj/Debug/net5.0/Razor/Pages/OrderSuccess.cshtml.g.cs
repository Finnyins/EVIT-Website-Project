#pragma checksum "C:\Users\matao\Documents\Github\Site\Pages\OrderSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af17a84fa28f4f9e61942fcec43c4e5f6ea62e9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Website.Pages.Pages_OrderSuccess), @"mvc.1.0.razor-page", @"/Pages/OrderSuccess.cshtml")]
namespace Website.Pages
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
#line 1 "C:\Users\matao\Documents\Github\Site\Pages\_ViewImports.cshtml"
using Website;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af17a84fa28f4f9e61942fcec43c4e5f6ea62e9a", @"/Pages/OrderSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"459ff182d5c873ea1cf5eb7fbdf003d162ca66d3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_OrderSuccess : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<ol id=""orderProcess"">
    <li><span class=""step-number"">1</span>Choose Item</li>
    <li><span class=""step-number"">2</span>Details &amp; Submit</li>
    <li class=""current""><span class=""step-number"">3</span>Receipt</li>
</ol>
<h1>Order Confirmed</h1>
<p>Not like you've actually bought anything though</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Website.Pages.OrderSuccessModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Website.Pages.OrderSuccessModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Website.Pages.OrderSuccessModel>)PageContext?.ViewData;
        public Website.Pages.OrderSuccessModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
