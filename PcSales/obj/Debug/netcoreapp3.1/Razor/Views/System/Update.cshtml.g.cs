#pragma checksum "/Users/jackdew/Desktop/PcSales/PcSales/Views/System/Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c81b829479559d3368bcedccf7d5e0d67cffaae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_System_Update), @"mvc.1.0.view", @"/Views/System/Update.cshtml")]
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
#line 1 "/Users/jackdew/Desktop/PcSales/PcSales/Views/_ViewImports.cshtml"
using PcSales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jackdew/Desktop/PcSales/PcSales/Views/_ViewImports.cshtml"
using PcSales.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c81b829479559d3368bcedccf7d5e0d67cffaae", @"/Views/System/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0167ccc47b93e45bf29d7d0f7947aaa89242e6f2", @"/Views/_ViewImports.cshtml")]
    public class Views_System_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("simple-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/jackdew/Desktop/PcSales/PcSales/Views/System/Update.cshtml"
  
    ViewData["Title"] = "Update System";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div ng-app=\"PcSalesApp\" ng-controller=\"systemUpdateController as vm\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c81b829479559d3368bcedccf7d5e0d67cffaae3743", async() => {
                WriteLiteral(@"
            <label>System Name: <input type=""text"" ng-model=""vm.system.systemName"" /></label><br />
            <label>Price: <input type=""number"" ng-model=""vm.system.price"" /></label><br />
            <label>Inventory Count: <input type=""number"" ng-model=""vm.system.inventoryCount"" /></label><br />
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <table ng-table=""vm.parts"" class=""table table-condensed table-bordered table-striped"">
            <thead>
                <tr>
                    <th>Part Number</th>
                    <th>Part Name</th>
                    <th>Manufacturer</th>
                    <th>Delete</th>
                </tr>
            </thead>
            <tr ng-repeat=""part in vm.parts"">
                <td class=""text-left"">{{part.partNum}}</td>
                <td class=""text-left"">{{part.partName}}</td>
                <td class=""text-left"">{{part.manufacturer}}</td>
                <td class=""text-left""><input type=""checkbox"" ng-click=""vm.removePart(part.partNum)""/></td>
            </tr>
        </table>
    </div>

<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.2.7/angular.js""></script>
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.2.7/angular-route.js""></script>
<script type=""text/javascript"" src=""https://aja");
            WriteLiteral("x.googleapis.com/ajax/libs/angularjs/1.2.7/angular-resource.js\"></script>\r\n<script type=\"text/javascript\" src=\"js/site.js\"></script>");
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
