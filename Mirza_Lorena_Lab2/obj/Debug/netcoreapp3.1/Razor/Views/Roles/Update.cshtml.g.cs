#pragma checksum "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad0e76bf83bbc9f5227e4a9eb29ff434ad1ea78c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Update), @"mvc.1.0.view", @"/Views/Roles/Update.cshtml")]
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
#line 1 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\_ViewImports.cshtml"
using LibraryModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\_ViewImports.cshtml"
using Mirza_Lorena_Lab2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\_ViewImports.cshtml"
using LibraryModel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad0e76bf83bbc9f5227e4a9eb29ff434ad1ea78c", @"/Views/Roles/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70da3054e6cb2b57a8c25213573bff7acdf8ce50", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mirza_Lorena_Lab2.Models.RoleEdit>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1 class=\"bg-info text-white\">Update Role</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad0e76bf83bbc9f5227e4a9eb29ff434ad1ea78c5215", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad0e76bf83bbc9f5227e4a9eb29ff434ad1ea78c6451", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 4 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad0e76bf83bbc9f5227e4a9eb29ff434ad1ea78c8086", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"roleName\"");
                BeginWriteAttribute("value", " value=\"", 273, "\"", 297, 1);
#nullable restore
#line 6 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
WriteAttributeValue("", 281, Model.Role.Name, 281, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"roleId\"");
                BeginWriteAttribute("value", " value=\"", 341, "\"", 363, 1);
#nullable restore
#line 7 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
WriteAttributeValue("", 349, Model.Role.Id, 349, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <h2 class=\"bg-info p-1 text-white\">Add To ");
#nullable restore
#line 8 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
                                         Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n    <table class=\"table table-bordered table-sm\">\r\n");
#nullable restore
#line 10 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
         if (Model.NonMembers.Count() == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr><td colspan=\"2\">All Users Are Members</td></tr>\r\n");
#nullable restore
#line 13 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
             foreach (var user in Model.NonMembers)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
                   Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"AddIds\"");
                BeginWriteAttribute("value", "\r\n                               value=\"", 867, "\"", 915, 1);
#nullable restore
#line 22 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
WriteAttributeValue("", 907, user.Id, 907, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n    <h2 class=\"bg-info p-1 text-white\">Remove From ");
#nullable restore
#line 28 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
                                              Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n    <table class=\"table table-bordered table-sm\">\r\n");
#nullable restore
#line 30 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
         if (Model.Members.Count() == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr><td colspan=\"2\">No Users Are Members</td></tr>\r\n");
#nullable restore
#line 33 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
             foreach (var user in Model.Members)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
                   Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"DeleteIds\"");
                BeginWriteAttribute("value", "\r\n                               value=\"", 1508, "\"", 1556, 1);
#nullable restore
#line 42 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
WriteAttributeValue("", 1548, user.Id, 1548, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 45 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab6\Mirza_Lorena_Lab2\Views\Roles\Update.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mirza_Lorena_Lab2.Models.RoleEdit> Html { get; private set; }
    }
}
#pragma warning restore 1591
