#pragma checksum "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2901eb875f798f3a3524dfb2fac73aa03c60a8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Cusstomer), @"mvc.1.0.view", @"/Views/Customer/Cusstomer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Cusstomer.cshtml", typeof(AspNetCore.Views_Customer_Cusstomer))]
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
#line 1 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\_ViewImports.cshtml"
using MyWebShopApplication;

#line default
#line hidden
#line 2 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\_ViewImports.cshtml"
using MyWebShopApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2901eb875f798f3a3524dfb2fac73aa03c60a8c", @"/Views/Customer/Cusstomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26017289990d5f8d6e82c48e909d722e961b324f", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Cusstomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApiMyShop.Models.Customer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
  
    ViewData["Title"] = "Cusstomer";

#line default
#line hidden
            BeginContext(97, 33, true);
            WriteLiteral("\r\n<h2>Cusstomer</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(130, 37, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbdb1138e72846c0a1bca2fbd182781c", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "598d9b4d979c49e8ab9a186783879b87", async() => {
>>>>>>> e23bac2697026fd5e6c7df038794d98335688787
                BeginContext(153, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(167, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(260, 47, false);
#line 16 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
           Write(Html.DisplayNameFor(model => model.customer_ID));

#line default
#line hidden
            EndContext();
            BeginContext(307, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(363, 48, false);
#line 19 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
           Write(Html.DisplayNameFor(model => model.nameCustomer));

#line default
#line hidden
            EndContext();
            BeginContext(411, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(467, 47, false);
#line 22 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
           Write(Html.DisplayNameFor(model => model.phoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(514, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(570, 43, false);
#line 25 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
           Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(613, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(669, 41, false);
#line 28 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(710, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(828, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(877, 46, false);
#line 37 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.customer_ID));

#line default
#line hidden
            EndContext();
            BeginContext(923, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(979, 47, false);
#line 40 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.nameCustomer));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1082, 46, false);
#line 43 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.phoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1184, 42, false);
#line 46 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.address));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1282, 40, false);
#line 49 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
           Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1378, 65, false);
#line 52 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1464, 71, false);
#line 53 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1535, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1556, 69, false);
#line 54 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "D:\Atun\WebApiMyShop\MyWebShopApplication\Views\Customer\Cusstomer.cshtml"
}

#line default
#line hidden
            BeginContext(1664, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApiMyShop.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
