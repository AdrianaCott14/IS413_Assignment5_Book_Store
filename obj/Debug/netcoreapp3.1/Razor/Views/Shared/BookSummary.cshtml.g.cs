#pragma checksum "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a949e8efac475309877b3ae450e3077f729687df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BookSummary), @"mvc.1.0.view", @"/Views/Shared/BookSummary.cshtml")]
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
#line 1 "C:\Users\adria\source\repos\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adria\source\repos\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a949e8efac475309877b3ae450e3077f729687df", @"/Views/Shared/BookSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BookSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card card-outline-primary p-4 bg-light mb-5\" style=\"margin: 5px;\">\r\n    <h4>\r\n        <span class=\"card-title float-left\">");
#nullable restore
#line 10 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
                                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span class=\"badge badge-light float-right text-secondary\">\r\n            ");
#nullable restore
#line 12 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
       Write(Model.AuthorFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
                              Write(Model.AuthorMiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
                                                      Write(Model.AuthorLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n    </h4>\r\n    <div class=\"text-info\">\r\n        <p><strong>");
#nullable restore
#line 16 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
              Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n        <p>");
#nullable restore
#line 17 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
      Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 18 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
      Write(Model.Classificaton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 19 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
      Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>$");
#nullable restore
#line 20 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 21 "C:\Users\adria\source\repos\BookStore\Views\Shared\BookSummary.cshtml"
      Write(Model.Pages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591