#pragma checksum "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69c2149896bea8b1aef3be63cc35b8b96f1dd320"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Company_Views_Clients_Index), @"mvc.1.0.view", @"/Areas/Company/Views/Clients/Index.cshtml")]
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
#line 1 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\_ViewImports.cshtml"
using Clock.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\_ViewImports.cshtml"
using Clock.Presentation.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69c2149896bea8b1aef3be63cc35b8b96f1dd320", @"/Areas/Company/Views/Clients/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3389a00ad765b1a5a6538de3271e3c6a4762c3b", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Company_Views_Clients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Clock.Presentation.ViewModels.ClientViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/css/dataTables.material.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("application/x-www-form-urlencoded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/plugins/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/datatables/js/dataTables.material.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69c2149896bea8b1aef3be63cc35b8b96f1dd3206400", async() => {
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
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c2149896bea8b1aef3be63cc35b8b96f1dd3207522", async() => {
                WriteLiteral(@"
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header card-header-primary"">
                        <h4 class=""card-title "">My Employees</h4>
                        <p class=""card-category""> Here is a subtitle for this table</p>
                    </div>
                    <div class=""card-body"">
");
                WriteLiteral("                        <div");
                BeginWriteAttribute("class", " class=\"", 901, "\"", 909, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 27 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
                             if (Model == null || Model.Count() == 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <table class=""table"">
                                    <thead class=""text-primary"">
                                        There are no Employees Registered!
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                        </tr>
                                    <");
                WriteLiteral("/tbody>\r\n                                </table>\r\n");
#nullable restore
#line 50 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <table class=""table"" id=""clients"">
                                    <thead class="" text-primary"">
                                        <tr>
                                            <th>
                                                Name
                                            </th>
                                            <th>
                                                Surname
                                            </th>
                                            <th>
                                                Telephone
                                            </th>
                                            <th>
                                                E-mail
                                            </th>
                                            <th>
                                                Address
                                            </th>
                                            <th>

   ");
                WriteLiteral("                                         </th>\r\n                                        </tr>\r\n                                    </thead>\r\n");
#nullable restore
#line 76 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
                                     foreach (var client in Model)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tbody>\r\n                                            <tr>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 81 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
                                               Write(client.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 84 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
                                               Write(client.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 87 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
                                               Write(client.Telephone);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 90 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
                                               Write(client.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 93 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
                                               Write(client.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 96 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
                                               Write(Html.ActionLink("Edit", "Edit", new { id = client.IdClient }, new { @class = "btn btn-sm btn-primary" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    ");
#nullable restore
#line 97 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
                                               Write(Html.ActionLink("Details", "Details", new { id = client.IdClient }, new { @class = "btn btn-sm btn-primary" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    ");
#nullable restore
#line 98 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
                                               Write(Html.ActionLink("Inactivate", "Inactivate", new { id = client.IdClient }, new { @class = "btn btn-sm btn-primary" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </td>\r\n                                            </tr>\r\n                                        </tbody>\r\n");
#nullable restore
#line 102 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </table>\r\n");
#nullable restore
#line 104 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <button type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5310, "\"", 5388, 3);
                WriteAttributeValue("", 5320, "location.href=\'", 5320, 15, true);
#nullable restore
#line 105 "C:\Users\Asus\Documents\Workspace\Worked_Hours\Clock_System\Clock.Presentation\Areas\Company\Views\Clients\Index.cshtml"
WriteAttributeValue("", 5335, Url.Action("Create", "Clients").Replace("%2F", "/"), 5335, 52, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5387, "\'", 5387, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-primary pull-right"">Add New</button>
                            <button type=""button"" onclick=""Back()"" class=""btn btn-dark"">Back</button>
                            <div class=""clearfix""></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c2149896bea8b1aef3be63cc35b8b96f1dd32018538", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c2149896bea8b1aef3be63cc35b8b96f1dd32019578", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c2149896bea8b1aef3be63cc35b8b96f1dd32020618", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script>\r\n\r\n    $(document).ready(function () {\r\n        $(\'#clients\').DataTable({\r\n        });\r\n    });\r\n\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Clock.Presentation.ViewModels.ClientViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
