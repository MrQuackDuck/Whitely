#pragma checksum "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8124e5494f34344e9b304234982a9420f829d1d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Offers), @"mvc.1.0.view", @"/Views/Home/Offers.cshtml")]
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
#line 1 "C:\Users\mrquackduckk\source\repos\Whitely\Views\_ViewImports.cshtml"
using Whitely;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mrquackduckk\source\repos\Whitely\Views\_ViewImports.cshtml"
using Whitely.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
using Whitely.Domain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8124e5494f34344e9b304234982a9420f829d1d3", @"/Views/Home/Offers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfa71cfcf5adbbf9f4fb77f128f91d831637f2e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Offers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RealProperty>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style/offers-style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Offers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Find", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
  
    Layout = null;

    double TotalPages = ViewBag.TotalPages;
    int id = ViewBag.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8124e5494f34344e9b304234982a9420f829d1d36965", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8124e5494f34344e9b304234982a9420f829d1d37227", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8124e5494f34344e9b304234982a9420f829d1d38406", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=0.7 user-scalable=no\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8124e5494f34344e9b304234982a9420f829d1d39781", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>Whitely - All offers</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8124e5494f34344e9b304234982a9420f829d1d311707", async() => {
                WriteLiteral(@"
    <header class=""header__wrapper"">
        <div class=""header"">
            <span class=""logo""><a href=""/"">Whitely</a></span>
            <nav class=""navbar"">
                <div class=""item""><a href=""/"">Home</a></div>
                <div class=""item""><a href=""#"">Privacy</a></div>
                <div class=""item""><a href=""#"">About Us</a></div>
                <div class=""item"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8124e5494f34344e9b304234982a9420f829d1d312381", async() => {
                    WriteLiteral("Search");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</div>
            </nav>
        </div>
    </header>
    <div class=""banner__wrapper"">
        <div class=""banner"">
            <div class=""main-title"">
                All offers
            </div>
            <div class=""sub-title"">
                Whitely.com will help you to choose  perfect real estate. We can offer large warehouses,
                beautiful offices and more!..
            </div>
        </div>
    </div>
    <main>
        <section class=""offers-section"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8124e5494f34344e9b304234982a9420f829d1d314122", async() => {
                    WriteLiteral(@"
                <div class=""search-title"">Search</div>
                <div class=""input-section"">
                    <input class=""input"" type=""text"" name=""searchString"" placeholder=""Write your request..."">
                    <input class=""search-btn"" type=""submit"" value=""🔎"">
                </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <hr class=\"underline\">\r\n            <div class=\"article-container\">\r\n");
#nullable restore
#line 56 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
                 for (int i = 0; i < Model.Count; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <article>\r\n                        <a class=\"article-img\"");
                BeginWriteAttribute("style", " style=\"", 2145, "\"", 2202, 4);
                WriteAttributeValue("", 2153, "background-image:", 2153, 17, true);
                WriteAttributeValue(" ", 2170, "url(\'/img/", 2171, 11, true);
#nullable restore
#line 59 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
WriteAttributeValue("", 2181, Model[i].Id, 2181, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2195, ".jpg\');", 2195, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 2203, "\"", 2234, 2);
                WriteAttributeValue("", 2210, "/Home/Offer/", 2210, 12, true);
#nullable restore
#line 59 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
WriteAttributeValue("", 2222, Model[i].Id, 2222, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                        <div class=\"article-wrapper\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 2327, "\"", 2358, 2);
                WriteAttributeValue("", 2334, "/Home/Offer/", 2334, 12, true);
#nullable restore
#line 61 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
WriteAttributeValue("", 2346, Model[i].Id, 2346, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"article-title\">");
#nullable restore
#line 61 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
                                                                                Write(Model[i].Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                            <div class=\"article-date\">Date: ");
#nullable restore
#line 62 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
                                                       Write(Model[i].DateAdded);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            <div class=\"article-text\">");
#nullable restore
#line 63 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
                                                  Write(Model[i].Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("...</div>\r\n                            <div class=\"details\">\r\n                                <div class=\"article-price\">\r\n                                    Rent: ");
#nullable restore
#line 66 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
                                     Write(Model[i].RentPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" USD / m² <br>\r\n                                    Buy: ");
#nullable restore
#line 67 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
                                    Write(Model[i].BuyPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" USD / m²\r\n                                </div>\r\n                                <div class=\"type-and-id\">\r\n                                    <div class=\"article-type\">Type: ");
#nullable restore
#line 70 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
                                                               Write(Model[i].Type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                    <div class=\"article-id\">ID: #");
#nullable restore
#line 71 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
                                                            Write(Model[i].Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                    <div class=\"article-type\">Area: ");
#nullable restore
#line 72 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
                                                               Write(Model[i].Area);

#line default
#line hidden
#nullable disable
                WriteLiteral(" m²</div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </article>\r\n");
#nullable restore
#line 77 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n\r\n            <div class=\"page-buttons\">\r\n");
#nullable restore
#line 81 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
                 for (int i = 1; i <= TotalPages; ++i)
                {
                    if (i == id)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 3576, "\"", 3598, 2);
                WriteAttributeValue("", 3583, "/Home/Offers/", 3583, 13, true);
#nullable restore
#line 85 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
WriteAttributeValue("", 3596, i, 3596, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn page-btn active\">");
#nullable restore
#line 85 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
                                                                         Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 86 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 3734, "\"", 3756, 2);
                WriteAttributeValue("", 3741, "/Home/Offers/", 3741, 13, true);
#nullable restore
#line 89 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
WriteAttributeValue("", 3754, i, 3754, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn page-btn\">");
#nullable restore
#line 89 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
                                                                  Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 90 "C:\Users\mrquackduckk\source\repos\Whitely\Views\Home\Offers.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>
        </section>
    </main>

    <footer class=""footer__wrapper"">
        <div class=""footer"">
            <div class=""logo""><a href=""/"">Whitely</a></div>
            <div class=""copyright"">Copyright Whitely © 2007-2022. All rights reserved</div>
        </div>
    </footer>

    <script src=""https://kit.fontawesome.com/c11c9940be.js"" crossorigin=""anonymous""></script>
");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RealProperty>> Html { get; private set; }
    }
}
#pragma warning restore 1591