#pragma checksum "C:\Users\Tyler\Documents\GitHub\PCSales\PcSales\Views\CpuSpec\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4c72da6123a9c29b934105a7e39854c001bee67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CpuSpec_Index), @"mvc.1.0.view", @"/Views/CpuSpec/Index.cshtml")]
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
#line 1 "C:\Users\Tyler\Documents\GitHub\PCSales\PcSales\Views\_ViewImports.cshtml"
using PcSales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tyler\Documents\GitHub\PCSales\PcSales\Views\_ViewImports.cshtml"
using PcSales.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c72da6123a9c29b934105a7e39854c001bee67", @"/Views/CpuSpec/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"601a4c681c9fd51a618385a9951dbdaf50fbf521", @"/Views/_ViewImports.cshtml")]
    public class Views_CpuSpec_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Tyler\Documents\GitHub\PCSales\PcSales\Views\CpuSpec\Index.cshtml"
  
     ViewData["Title"] = "Cpu Spec Listing";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div ng-app=""PcSalesApp"" ng-controller=""cpuSpecListController as vm"">
     <div class=""text-center"">
          <table ng-table=""vm.cpuSpecs"" class=""table table-condensed table-bordered table-striped"">
               <thead>
                    <tr>
                         <th>Part Number</th>
                         <th>Part Name</th>
                         <th>Manufacturer</th>
                         <th>Cores Count</th>
                         <th>TDP</th>
                         <th>Socket</th>
                         <th>Clock Speed</th>
                    </tr>
               </thead>
               <tr ng-repeat=""spec in vm.cpuSpecs"">
                    <td class=""text-left"">{{spec.partNum}}</td>
                    <td class=""text-left"">{{spec.partName}}</td>
                    <td class=""text-left"">{{spec.manufacturer}}</td>
                    <td class=""text-left"">{{spec.coresCount}}</td>
                    <td class=""text-left"">{{spec.tdp}}</td>
                  ");
            WriteLiteral(@"  <td class=""text-left"">{{spec.socket}}</td>
                    <td class=""text-left"">{{spec.clockSpeed}}</td>
               </tr>
          </table>
     </div>
</div>

<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.2.7/angular.js""></script>
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.2.7/angular-route.js""></script>
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.2.7/angular-resource.js""></script>
<script type=""text/javascript"" src=""js/site.js""></script>");
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
