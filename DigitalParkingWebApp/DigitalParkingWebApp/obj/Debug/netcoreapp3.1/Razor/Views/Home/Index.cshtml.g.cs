#pragma checksum "C:\Users\Mileide Gomes\source\repos\DigitalParkingWebApp\DigitalParkingWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cc666d3636739288703370993ae6596c1d84cce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Mileide Gomes\source\repos\DigitalParkingWebApp\DigitalParkingWebApp\Views\_ViewImports.cshtml"
using DigitalParkingWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mileide Gomes\source\repos\DigitalParkingWebApp\DigitalParkingWebApp\Views\_ViewImports.cshtml"
using DigitalParkingWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cc666d3636739288703370993ae6596c1d84cce", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42bf18a0152636a55193cbe06b57f576f20a1f8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DigitalParkingWebApp.Models.MaterialUsage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- ");
#nullable restore
#line 1 "C:\Users\Mileide Gomes\source\repos\DigitalParkingWebApp\DigitalParkingWebApp\Views\Home\Index.cshtml"
       
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div> -->\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Mileide Gomes\source\repos\DigitalParkingWebApp\DigitalParkingWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
    <div class=""text-center"">
        <h1 class=""display-4"">Bem-Vindo/a ao Digital Parking</h1>

        <div class=""row"">
            <div class=""col-md-12"">
                <h2>Estacionamento</h2>
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th>Lugar A-1</th>
                            <th>Lugar A-2</th>
                            <th>Lugar A-3</th>
                            <th>Lugar A-4</th>
                            <th>Carros não Estacionados</th>
                            <th>Time</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 34 "C:\Users\Mileide Gomes\source\repos\DigitalParkingWebApp\DigitalParkingWebApp\Views\Home\Index.cshtml"
                         if (Model.Value != null)
                        {
                            foreach (var item in Model.Value)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 40 "C:\Users\Mileide Gomes\source\repos\DigitalParkingWebApp\DigitalParkingWebApp\Views\Home\Index.cshtml"
                                   Write(item.A_1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 41 "C:\Users\Mileide Gomes\source\repos\DigitalParkingWebApp\DigitalParkingWebApp\Views\Home\Index.cshtml"
                                   Write(item.A_2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 42 "C:\Users\Mileide Gomes\source\repos\DigitalParkingWebApp\DigitalParkingWebApp\Views\Home\Index.cshtml"
                                   Write(item.A_3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 43 "C:\Users\Mileide Gomes\source\repos\DigitalParkingWebApp\DigitalParkingWebApp\Views\Home\Index.cshtml"
                                   Write(item.A_4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 44 "C:\Users\Mileide Gomes\source\repos\DigitalParkingWebApp\DigitalParkingWebApp\Views\Home\Index.cshtml"
                                   Write(item.FORA);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 45 "C:\Users\Mileide Gomes\source\repos\DigitalParkingWebApp\DigitalParkingWebApp\Views\Home\Index.cshtml"
                                   Write(item.Timestamp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 48 "C:\Users\Mileide Gomes\source\repos\DigitalParkingWebApp\DigitalParkingWebApp\Views\Home\Index.cshtml"
                                break;
                            }
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>No Data</td>\r\n                            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Mileide Gomes\source\repos\DigitalParkingWebApp\DigitalParkingWebApp\Views\Home\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n        \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DigitalParkingWebApp.Models.MaterialUsage> Html { get; private set; }
    }
}
#pragma warning restore 1591