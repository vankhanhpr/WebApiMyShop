#pragma checksum "E:\ASPMVC\MyShopDotNetCore\WebApiMyShop\MyWebShopApplication\Views\Account\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "467323241129f0838db46e771aa917e023e0b6df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Account), @"mvc.1.0.view", @"/Views/Account/Account.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Account.cshtml", typeof(AspNetCore.Views_Account_Account))]
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
#line 1 "E:\ASPMVC\MyShopDotNetCore\WebApiMyShop\MyWebShopApplication\Views\_ViewImports.cshtml"
using MyWebShopApplication;

#line default
#line hidden
#line 2 "E:\ASPMVC\MyShopDotNetCore\WebApiMyShop\MyWebShopApplication\Views\_ViewImports.cshtml"
using MyWebShopApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"467323241129f0838db46e771aa917e023e0b6df", @"/Views/Account/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26017289990d5f8d6e82c48e909d722e961b324f", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/admin_account.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\ASPMVC\MyShopDotNetCore\WebApiMyShop\MyWebShopApplication\Views\Account\Account.cshtml"
  
    ViewData["Title"] = "Account";
    Layout = null;

#line default
#line hidden
            BeginContext(65, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(73, 812, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d0726f86d0f4651bb6c5f070a2fef0d", async() => {
                BeginContext(79, 739, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <title> Website of LV</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">

    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""main.css"" />
    <!--Link Css-->
    <link href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"" rel=""stylesheet"" />
    <link href='https://fonts.googleapis.com/css?family=Titillium+Web:400,200,300,600,700' rel='stylesheet' type='text/css'>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
    ");
                EndContext();
                BeginContext(818, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f292abad89947f3adc2428c8a6ca134", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(874, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(885, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(887, 5564, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9ea0bc35e0a46178eb8b81508849b06", async() => {
                BeginContext(893, 5551, true);
                WriteLiteral(@"
    <div class="" container-fluid"">
        <p class=""col-lg-12 borderbottom""></p>
        <div class=""col-lg-12"" style=""position:relative;"">
            <div class=""col-lg-4"">
                <div class=""w3-sidebar w3-light-grey w3-bar-block"" style=""width:25%"">
                    <h3 class=""w3-bar-item"">Manage User</h3>
                    <a href=""#"" class=""w3-bar-item w3-button"">All User</a>
                    <a href=""#"" class=""w3-bar-item w3-button"">Create User</a>
                    <a href=""#"" class=""w3-bar-item w3-button"">Another</a>
                </div>
            </div>
            <div class=""col-lg-8 tab-all-user"">
                <table class=""table-users table"" border=""0"">
                    <tbody>
                        <tr>
                            <td width=""10"" align=""center"">
                                <i class=""fa fa-2x fa-user fw""></i>
                            </td>
                            <td>John Smith<br><i class=""fa fa-envelope""></i></td>
  ");
                WriteLiteral(@"                          <td>Builder Admin</td>
                            <td align=""center"">
                                Last Login:  6/14/2017<br><small class=""text-muted"">2 days ago</small>
                            </td>
                        </tr>

                        <tr>
                            <td width=""10"">
                                <img class=""pull-left img-circle nav-user-photo"" width=""50"" src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSxhcCYW4QDWMOjOuUTxOd50KcJvK-rop9qE9zRltSbVS_bO-cfWA"" />
                            </td>
                            <td>Herbert Hoover<br><i class=""fa fa-envelope""></i></td>
                            <td>Builder Sales Agent </td>
                            <td align=""center"">
                                Last Login:  6/10/2017<br><small class=""text-muted"">5 days ago</small>
                            </td>
                        </tr>

                        <tr>
                            <td width");
                WriteLiteral(@"=""10"">
                                <img class=""pull-left img-circle nav-user-photo"" width=""50"" src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSxhcCYW4QDWMOjOuUTxOd50KcJvK-rop9qE9zRltSbVS_bO-cfWA"" />
                            </td>
                            <td>Herbert Hoover<br><i class=""fa fa-envelope""></i></td>
                            <td>Builder Sales Agent </td>
                            <td align=""center"">
                                Last Login:  6/10/2017<br><small class=""text-muted"">5 days ago</small>
                            </td>
                        </tr>

                        <tr>
                            <td width=""10"">
                                <img class=""pull-left img-circle nav-user-photo"" width=""50"" src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSxhcCYW4QDWMOjOuUTxOd50KcJvK-rop9qE9zRltSbVS_bO-cfWA"" />
                            </td>
                            <td>Herbert Hoover<br><i class=""fa fa-envelope""></i></td>");
                WriteLiteral(@"
                            <td>Builder Sales Agent </td>
                            <td align=""center"">
                                Last Login:  6/10/2017<br><small class=""text-muted"">5 days ago</small>
                            </td>
                        </tr>

                        <tr>
                            <td width=""10"">
                                <img class=""pull-left img-circle nav-user-photo"" width=""50"" src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSxhcCYW4QDWMOjOuUTxOd50KcJvK-rop9qE9zRltSbVS_bO-cfWA"" />
                            </td>
                            <td>Herbert Hoover<br><i class=""fa fa-envelope""></i></td>
                            <td>Builder Sales Agent </td>
                            <td align=""center"">
                                Last Login:  6/10/2017<br><small class=""text-muted"">5 days ago</small>
                            </td>
                        </tr>

                        <tr>
                           ");
                WriteLiteral(@" <td width=""10"" align=""center"">
                                <i class=""fa fa-2x fa-user fw""></i>
                            </td>
                            <td>John Smith<br><i class=""fa fa-envelope""></i></td>
                            <td>Builder Admin</td>
                            <td align=""center"">
                                Last Login:  6/14/2017<br><small class=""text-muted"">2 days ago</small>
                            </td>
                        </tr>
                        <tr>
                            <td width=""10"" align=""center"">
                                <i class=""fa fa-2x fa-user fw""></i>
                            </td>
                            <td>John Smith<br><i class=""fa fa-envelope""></i></td>
                            <td>Builder Admin</td>
                            <td align=""center"">
                                Last Login:  6/14/2017<br><small class=""text-muted"">2 days ago</small>
                            </td>
                ");
                WriteLiteral(@"        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <div class=""container"">
            <p class="" col-lg-12 borderbottom"" style=""margin-top:2%;"">Add new Account</p>
        </div>
       

    </div>

    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js""></script>
    <script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6451, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
