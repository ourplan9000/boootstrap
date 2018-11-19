#pragma checksum "E:\gitSource\bootstrapdemo\Bootstrap4-Net-Core-Starter\boootstrap\Views\Manage\ShowRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1306c61349fd008448930c4d5bd7cfbcf2fd2ddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ShowRecoveryCodes), @"mvc.1.0.view", @"/Views/Manage/ShowRecoveryCodes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/ShowRecoveryCodes.cshtml", typeof(AspNetCore.Views_Manage_ShowRecoveryCodes))]
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
#line 1 "E:\gitSource\bootstrapdemo\Bootstrap4-Net-Core-Starter\boootstrap\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\gitSource\bootstrapdemo\Bootstrap4-Net-Core-Starter\boootstrap\Views\_ViewImports.cshtml"
using Bootstrap4_Net_Core_Starter;

#line default
#line hidden
#line 3 "E:\gitSource\bootstrapdemo\Bootstrap4-Net-Core-Starter\boootstrap\Views\_ViewImports.cshtml"
using Bootstrap4_Net_Core_Starter.Models;

#line default
#line hidden
#line 4 "E:\gitSource\bootstrapdemo\Bootstrap4-Net-Core-Starter\boootstrap\Views\_ViewImports.cshtml"
using Bootstrap4_Net_Core_Starter.Models.AccountViewModels;

#line default
#line hidden
#line 5 "E:\gitSource\bootstrapdemo\Bootstrap4-Net-Core-Starter\boootstrap\Views\_ViewImports.cshtml"
using Bootstrap4_Net_Core_Starter.Models.ManageViewModels;

#line default
#line hidden
#line 1 "E:\gitSource\bootstrapdemo\Bootstrap4-Net-Core-Starter\boootstrap\Views\Manage\_ViewImports.cshtml"
using Bootstrap4_Net_Core_Starter.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1306c61349fd008448930c4d5bd7cfbcf2fd2ddf", @"/Views/Manage/ShowRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31e7ef33f541aad3087d3c14006769ba1caa2e40", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"671239f182ab848bd631643a3d19ca3ba13996bb", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_ShowRecoveryCodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShowRecoveryCodesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\gitSource\bootstrapdemo\Bootstrap4-Net-Core-Starter\boootstrap\Views\Manage\ShowRecoveryCodes.cshtml"
  
    ViewData["Title"] = "Recovery codes";
    ViewData.AddActivePage(ManageNavPages.TwoFactorAuthentication);

#line default
#line hidden
            BeginContext(154, 6, true);
            WriteLiteral("\r\n<h4>");
            EndContext();
            BeginContext(161, 17, false);
#line 7 "E:\gitSource\bootstrapdemo\Bootstrap4-Net-Core-Starter\boootstrap\Views\Manage\ShowRecoveryCodes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(178, 377, true);
            WriteLiteral(@"</h4>
<div class=""alert alert-warning"" role=""alert"">
    <p>
        <span class=""glyphicon glyphicon-warning-sign""></span>
        <strong>Put these codes in a safe place.</strong>
    </p>
    <p>
        If you lose your device and don't have the recovery codes you will lose access to your account.
    </p>
</div>
<div class=""row"">
    <div class=""col-md-12"">
");
            EndContext();
#line 19 "E:\gitSource\bootstrapdemo\Bootstrap4-Net-Core-Starter\boootstrap\Views\Manage\ShowRecoveryCodes.cshtml"
         for (var row = 0; row < Model.RecoveryCodes.Length; row += 2)
        {

#line default
#line hidden
            BeginContext(638, 18, true);
            WriteLiteral("            <code>");
            EndContext();
            BeginContext(657, 24, false);
#line 21 "E:\gitSource\bootstrapdemo\Bootstrap4-Net-Core-Starter\boootstrap\Views\Manage\ShowRecoveryCodes.cshtml"
             Write(Model.RecoveryCodes[row]);

#line default
#line hidden
            EndContext();
            BeginContext(681, 7, true);
            WriteLiteral("</code>");
            EndContext();
            BeginContext(694, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(707, 6, true);
            WriteLiteral("<code>");
            EndContext();
            BeginContext(714, 28, false);
#line 21 "E:\gitSource\bootstrapdemo\Bootstrap4-Net-Core-Starter\boootstrap\Views\Manage\ShowRecoveryCodes.cshtml"
                                                                      Write(Model.RecoveryCodes[row + 1]);

#line default
#line hidden
            EndContext();
            BeginContext(742, 15, true);
            WriteLiteral("</code><br />\r\n");
            EndContext();
#line 22 "E:\gitSource\bootstrapdemo\Bootstrap4-Net-Core-Starter\boootstrap\Views\Manage\ShowRecoveryCodes.cshtml"
        }

#line default
#line hidden
            BeginContext(768, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShowRecoveryCodesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
