#pragma checksum "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f7af2c7463b1a36f575db0e1a33794674872df8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreatePriceQuotation), @"mvc.1.0.view", @"/Views/Home/CreatePriceQuotation.cshtml")]
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
#line 1 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\_ViewImports.cshtml"
using PriceQuotationOfficeGuy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\_ViewImports.cshtml"
using PriceQuotationOfficeGuy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f7af2c7463b1a36f575db0e1a33794674872df8", @"/Views/Home/CreatePriceQuotation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d1f338c4cdd86d66129a716730d9adc0b5a22a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreatePriceQuotation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PriceQuotationCreationDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml"
  
    ViewData["Title"] = "CreatePriceQuotation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml"
  
    ViewBag.Title = "Create Price Quotation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create Price Quotation</h1>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml"
 using (Html.BeginForm("CreatePriceQuotation", "Home"))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n   \r\n    <hr />\r\n    ");
#nullable restore
#line 23 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 27 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml"
   Write(Html.LabelFor(model => model.CustomerName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml"
       Write(Html.EditorFor(model => model.CustomerName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 30 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml"
       Write(Html.ValidationMessageFor(model => model.CustomerName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 35 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml"
   Write(Html.LabelFor(model => model.Amount, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml"
       Write(Html.EditorFor(model => model.Amount, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 38 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml"
       Write(Html.ValidationMessageFor(model => model.Amount, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 43 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml"
   Write(Html.LabelFor(model => model.ProductName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 45 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml"
       Write(Html.EditorFor(model => model.ProductName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 46 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml"
       Write(Html.ValidationMessageFor(model => model.ProductName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <button class=\"btn btn-primary\" type=\"submit\">Create</button>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 56 "C:\Users\roeeb\source\repos\PriceQuotationOfficeGuy\PriceQuotationOfficeGuy\Views\Home\CreatePriceQuotation.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PriceQuotationCreationDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
