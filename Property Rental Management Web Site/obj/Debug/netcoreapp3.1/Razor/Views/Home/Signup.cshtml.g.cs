#pragma checksum "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e067bcbb28a53b9feade2d6aae808ead08edff6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Signup), @"mvc.1.0.view", @"/Views/Home/Signup.cshtml")]
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
#line 1 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\_ViewImports.cshtml"
using Property_Rental_Management_Web_Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\_ViewImports.cshtml"
using Property_Rental_Management_Web_Site.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e067bcbb28a53b9feade2d6aae808ead08edff6", @"/Views/Home/Signup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93d05b3722d890af28332d67297ee223aab6c86e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Signup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Property_Rental_Management_Web_Site.Models.Users1>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
  
    ViewBag.Title = "Signup";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Signup</h2>\r\n");
#nullable restore
#line 7 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
#nullable restore
#line 13 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 15 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
       Write(Html.LabelFor(model => model.UserId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 17 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
           Write(Html.TextBoxFor(model => model.UserId, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 18 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
           Write(Html.ValidationMessageFor(model => model.UserId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 22 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
       Write(Html.LabelFor(model => model.Username, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 24 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
           Write(Html.TextBoxFor(model => model.Username, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 25 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
           Write(Html.ValidationMessageFor(model => model.Username, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 29 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
       Write(Html.LabelFor(model => model.Tenants1.FirstName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 31 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
           Write(Html.TextBoxFor(model => model.Tenants1.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 32 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
           Write(Html.ValidationMessageFor(model => model.Tenants1.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 36 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
       Write(Html.LabelFor(model => model.Tenants1.LastName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 38 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
           Write(Html.TextBoxFor(model => model.Tenants1.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 39 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
           Write(Html.ValidationMessageFor(model => model.Tenants1.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 43 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
       Write(Html.LabelFor(model => model.Tenants1.PhoneNumber, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 45 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
           Write(Html.TextBoxFor(model => model.Tenants1.PhoneNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 46 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
           Write(Html.ValidationMessageFor(model => model.Tenants1.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 50 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
       Write(Html.LabelFor(model => model.Tenants1.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 52 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
           Write(Html.TextBoxFor(model => model.Tenants1.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 53 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
           Write(Html.ValidationMessageFor(model => model.Tenants1.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 57 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
       Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 59 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
           Write(Html.TextBoxFor(model => model.Password, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 60 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
           Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>

       

        


        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Signup"" class=""btn btn-primary"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 75 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 77 "E:\College LaSalle\FALL22\Web Server 2\Project\Property Rental Management Web Site\Property Rental Management Web Site\Views\Home\Signup.cshtml"
Write(Html.ActionLink("Click here to Login", "Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Property_Rental_Management_Web_Site.Models.Users1> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591