#pragma checksum "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Views\Shared\_NavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e733531e5ee12f348df4d9640fac49510ae70cc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NavBar), @"mvc.1.0.view", @"/Views/Shared/_NavBar.cshtml")]
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
#line 1 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Views\_ViewImports.cshtml"
using Clock.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Views\_ViewImports.cshtml"
using Clock.Presentation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e733531e5ee12f348df4d9640fac49510ae70cc6", @"/Views/Shared/_NavBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72162ca576c3a301e42e1ce997f2066006b0965", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__NavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<nav class=\"navbar navbar-expand-lg navbar-transparent navbar-absolute fixed-top\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"navbar-wrapper\">\r\n            <p class=\"navbar-brand\" href=\"javascript:;\"><b>Welcome ");
#nullable restore
#line 4 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Views\Shared\_NavBar.cshtml"
                                                              Write(User.Identity.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></p>
        </div>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" aria-controls=""navigation-index"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""sr-only"">Toggle navigation</span>
            <span class=""navbar-toggler-icon icon-bar""></span>
            <span class=""navbar-toggler-icon icon-bar""></span>
            <span class=""navbar-toggler-icon icon-bar""></span>
        </button>
        <div class=""collapse navbar-collapse justify-content-end"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e733531e5ee12f348df4d9640fac49510ae70cc64791", async() => {
                WriteLiteral("\r\n                <div class=\"input-group no-border\">\r\n                    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 913, "\"", 921, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" placeholder=""Search..."">
                    <button type=""submit"" class=""btn btn-white btn-round btn-just-icon"">
                        <i class=""material-icons"">search</i>
                        <div class=""ripple-container""></div>
                    </button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <ul class=""navbar-nav"">
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""javascript:;"">
                        <i class=""material-icons"">dashboard</i>
                        <p class=""d-lg-none d-md-block"">
                            Stats
                        </p>
                    </a>
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-link"" href=""http://example.com"" id=""navbarDropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""material-icons"">notifications</i>
                        <span class=""notification"">5</span>
                        <p class=""d-lg-none d-md-block"">
                            Some Actions
                        </p>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownMenuLink"">
                        <a class=""dropdow");
            WriteLiteral(@"n-item"" href=""#"">Mike John responded to your email</a>
                        <a class=""dropdown-item"" href=""#"">You have 5 new tasks</a>
                        <a class=""dropdown-item"" href=""#"">You're now friend with Andrew</a>
                        <a class=""dropdown-item"" href=""#"">Another Notification</a>
                        <a class=""dropdown-item"" href=""#"">Another One</a>
                    </div>
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-link"" href=""javascript:;"" id=""navbarDropdownProfile"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""material-icons"">person</i>
                        <p class=""d-lg-none d-md-block"">
                            Account
                        </p>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownProfile"">
                        <a class=""dropdown-item"" href=""#");
            WriteLiteral(@""">Profile</a>
                        <a class=""dropdown-item"" href=""#"">Settings</a>
                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""/Logout"">Log out</a>
                    </div>
                </li>
            </ul>
        </div>
    </div>
</nav>");
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
