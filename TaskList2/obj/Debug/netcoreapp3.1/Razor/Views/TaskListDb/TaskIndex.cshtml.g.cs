#pragma checksum "C:\Grandcircus\TaskList2\TaskList2\Views\TaskListDb\TaskIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "258e98a7203e72a50c419808c88b8840ab1d0c7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaskListDb_TaskIndex), @"mvc.1.0.view", @"/Views/TaskListDb/TaskIndex.cshtml")]
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
#line 1 "C:\Grandcircus\TaskList2\TaskList2\Views\_ViewImports.cshtml"
using TaskList2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Grandcircus\TaskList2\TaskList2\Views\_ViewImports.cshtml"
using TaskList2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"258e98a7203e72a50c419808c88b8840ab1d0c7f", @"/Views/TaskListDb/TaskIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13efa9007e9e8cd37a24636fa95bb15aead1853e", @"/Views/_ViewImports.cshtml")]
    public class Views_TaskListDb_TaskIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tasks>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TaskListDb", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TaskIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Grandcircus\TaskList2\TaskList2\Views\TaskListDb\TaskIndex.cshtml"
  
    ViewData["Title"] = "TaskIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Task Index</h1><br>\r\n<h3> To sort the list by Due Date or Completion status, click on the column heading!</h3><br>\r\n<h3>To search the description for key words user the search box!</h3><br>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "258e98a7203e72a50c419808c88b8840ab1d0c7f4541", async() => {
                WriteLiteral("\r\n    <p>\r\n        Task Description: <input type=\"text\" name=\"searchString\">\r\n        <input type=\"submit\" value=\"Search\" />\r\n    </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<table style=""width:100%"">
   
    <tr>
            <th>Task Description</th>
            <th><a href=""/TaskListDb?sort=DueDate"" style=""color:black"">Due Date</a></th>
            <th><a href=""/TaskListDb?sort=Completion"" style=""color:black"">Completion Status</a></th>
        </tr>
 
");
#nullable restore
#line 25 "C:\Grandcircus\TaskList2\TaskList2\Views\TaskListDb\TaskIndex.cshtml"
         foreach (var task in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "C:\Grandcircus\TaskList2\TaskList2\Views\TaskListDb\TaskIndex.cshtml"
               Write(task.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Grandcircus\TaskList2\TaskList2\Views\TaskListDb\TaskIndex.cshtml"
               Write(task.DueDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Grandcircus\TaskList2\TaskList2\Views\TaskListDb\TaskIndex.cshtml"
               Write(task.Completion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1037, "\"", 1103, 5);
            WriteAttributeValue("", 1047, "document.location", 1047, 17, true);
            WriteAttributeValue(" ", 1064, "=", 1065, 2, true);
            WriteAttributeValue(" ", 1066, "\'/TaskListDb/UpdateTask?id=", 1067, 28, true);
#nullable restore
#line 32 "C:\Grandcircus\TaskList2\TaskList2\Views\TaskListDb\TaskIndex.cshtml"
WriteAttributeValue("", 1094, task.Id, 1094, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1102, "\'", 1102, 1, true);
            EndWriteAttribute();
            WriteLiteral("> Edit this task</button>\r\n                </td>\r\n                <td>\r\n                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1203, "\"", 1269, 5);
            WriteAttributeValue("", 1213, "document.location", 1213, 17, true);
            WriteAttributeValue(" ", 1230, "=", 1231, 2, true);
            WriteAttributeValue(" ", 1232, "\'/TaskListDb/DeleteTask?id=", 1233, 28, true);
#nullable restore
#line 35 "C:\Grandcircus\TaskList2\TaskList2\Views\TaskListDb\TaskIndex.cshtml"
WriteAttributeValue("", 1260, task.Id, 1260, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1268, "\'", 1268, 1, true);
            EndWriteAttribute();
            WriteLiteral("> Remove this task</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Grandcircus\TaskList2\TaskList2\Views\TaskListDb\TaskIndex.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n\r\n</table>\r\n<h3><a href=\"/TaskListDb/AddTask\">Add new task</a></h3>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tasks>> Html { get; private set; }
    }
}
#pragma warning restore 1591
