#pragma checksum "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41644c687094df89143bd8b51e0b365f76cb0ddd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_feedFooders_Index), @"mvc.1.0.view", @"/Views/feedFooders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/feedFooders/Index.cshtml", typeof(AspNetCore.Views_feedFooders_Index))]
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
#line 1 "D:\Projects\Animal\Animal\Views\_ViewImports.cshtml"
using Animal;

#line default
#line hidden
#line 2 "D:\Projects\Animal\Animal\Views\_ViewImports.cshtml"
using Animal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41644c687094df89143bd8b51e0b365f76cb0ddd", @"/Views/feedFooders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"167c7fc57bf0c2e18f0176f8673fb8dfdfb2988f", @"/Views/_ViewImports.cshtml")]
    public class Views_feedFooders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Animal.Models.feedFooder>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(118, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "599b5d5fb1e342d88c344f5d8eb34d95", async() => {
                BeginContext(141, 10, true);
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
            BeginContext(155, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(248, 49, false);
#line 16 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fooderNameNep));

#line default
#line hidden
            EndContext();
            BeginContext(297, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(353, 49, false);
#line 19 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fooderNameEng));

#line default
#line hidden
            EndContext();
            BeginContext(402, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(458, 43, false);
#line 22 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(501, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(557, 48, false);
#line 25 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.municipility));

#line default
#line hidden
            EndContext();
            BeginContext(605, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(661, 44, false);
#line 28 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.district));

#line default
#line hidden
            EndContext();
            BeginContext(705, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(761, 41, false);
#line 31 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.state));

#line default
#line hidden
            EndContext();
            BeginContext(802, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(858, 45, false);
#line 34 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.shortNote));

#line default
#line hidden
            EndContext();
            BeginContext(903, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(959, 47, false);
#line 37 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cultivation));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1062, 49, false);
#line 40 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.seedingMethod));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1167, 57, false);
#line 43 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.seedHarvestingStorage));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1280, 48, false);
#line 46 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.grassProduct));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1384, 38, false);
#line 49 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.dm));

#line default
#line hidden
            EndContext();
            BeginContext(1422, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1478, 38, false);
#line 52 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cp));

#line default
#line hidden
            EndContext();
            BeginContext(1516, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1572, 39, false);
#line 55 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.tdn));

#line default
#line hidden
            EndContext();
            BeginContext(1611, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1667, 39, false);
#line 58 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ndf));

#line default
#line hidden
            EndContext();
            BeginContext(1706, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1762, 37, false);
#line 61 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.c));

#line default
#line hidden
            EndContext();
            BeginContext(1799, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1855, 37, false);
#line 64 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.p));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1948, 38, false);
#line 67 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.df));

#line default
#line hidden
            EndContext();
            BeginContext(1986, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2042, 39, false);
#line 70 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.adl));

#line default
#line hidden
            EndContext();
            BeginContext(2081, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2137, 41, false);
#line 73 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.tanni));

#line default
#line hidden
            EndContext();
            BeginContext(2178, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2234, 48, false);
#line 76 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nitrateScore));

#line default
#line hidden
            EndContext();
            BeginContext(2282, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2338, 43, false);
#line 79 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.remarks));

#line default
#line hidden
            EndContext();
            BeginContext(2381, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2437, 41, false);
#line 82 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
            EndContext();
            BeginContext(2478, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 88 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2596, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2645, 48, false);
#line 91 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.fooderNameNep));

#line default
#line hidden
            EndContext();
            BeginContext(2693, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2749, 48, false);
#line 94 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.fooderNameEng));

#line default
#line hidden
            EndContext();
            BeginContext(2797, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2853, 42, false);
#line 97 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.address));

#line default
#line hidden
            EndContext();
            BeginContext(2895, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2951, 47, false);
#line 100 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.municipility));

#line default
#line hidden
            EndContext();
            BeginContext(2998, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3054, 43, false);
#line 103 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.district));

#line default
#line hidden
            EndContext();
            BeginContext(3097, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3153, 40, false);
#line 106 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.state));

#line default
#line hidden
            EndContext();
            BeginContext(3193, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3249, 44, false);
#line 109 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.shortNote));

#line default
#line hidden
            EndContext();
            BeginContext(3293, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3349, 46, false);
#line 112 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.cultivation));

#line default
#line hidden
            EndContext();
            BeginContext(3395, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3451, 48, false);
#line 115 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.seedingMethod));

#line default
#line hidden
            EndContext();
            BeginContext(3499, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3555, 56, false);
#line 118 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.seedHarvestingStorage));

#line default
#line hidden
            EndContext();
            BeginContext(3611, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3667, 47, false);
#line 121 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.grassProduct));

#line default
#line hidden
            EndContext();
            BeginContext(3714, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3770, 37, false);
#line 124 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.dm));

#line default
#line hidden
            EndContext();
            BeginContext(3807, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3863, 37, false);
#line 127 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.cp));

#line default
#line hidden
            EndContext();
            BeginContext(3900, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3956, 38, false);
#line 130 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.tdn));

#line default
#line hidden
            EndContext();
            BeginContext(3994, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4050, 38, false);
#line 133 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ndf));

#line default
#line hidden
            EndContext();
            BeginContext(4088, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4144, 36, false);
#line 136 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.c));

#line default
#line hidden
            EndContext();
            BeginContext(4180, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4236, 36, false);
#line 139 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.p));

#line default
#line hidden
            EndContext();
            BeginContext(4272, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4328, 37, false);
#line 142 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.df));

#line default
#line hidden
            EndContext();
            BeginContext(4365, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4421, 38, false);
#line 145 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.adl));

#line default
#line hidden
            EndContext();
            BeginContext(4459, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4515, 40, false);
#line 148 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.tanni));

#line default
#line hidden
            EndContext();
            BeginContext(4555, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4611, 47, false);
#line 151 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.nitrateScore));

#line default
#line hidden
            EndContext();
            BeginContext(4658, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4714, 42, false);
#line 154 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.remarks));

#line default
#line hidden
            EndContext();
            BeginContext(4756, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4812, 40, false);
#line 157 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
            EndContext();
            BeginContext(4852, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4907, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "888369443b924483ad8ea674f6d84d42", async() => {
                BeginContext(4952, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 160 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
                                       WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4960, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4980, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b69690af16bf4656bf93054082d5daa6", async() => {
                BeginContext(5028, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 161 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
                                          WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5039, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(5059, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d835e8162fa475fb276650ffd68e35d", async() => {
                BeginContext(5106, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 162 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
                                         WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5116, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 165 "D:\Projects\Animal\Animal\Views\feedFooders\Index.cshtml"
}

#line default
#line hidden
            BeginContext(5155, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Animal.Models.feedFooder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
