#pragma checksum "D:\Mywork\myecommercehelper\FileUploader2-master\FileUploader2-master\FileUploader2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7837bfa59bbe3bc227b937c3d559bb5fb1389a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Mywork\myecommercehelper\FileUploader2-master\FileUploader2-master\FileUploader2\Views\_ViewImports.cshtml"
using FileUploader2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Mywork\myecommercehelper\FileUploader2-master\FileUploader2-master\FileUploader2\Views\_ViewImports.cshtml"
using FileUploader2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7837bfa59bbe3bc227b937c3d559bb5fb1389a5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49a29448f06282f862ea411ddfb28b2f520f8bde", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("message-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Savetext", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Savetext2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<script type=""text/javascript"">

function clear2(){
    
document.getElementById(""textarea2"").innerText="""";
document.getElementById(""textarea2"").value="""";
}



function clear3(){
    
document.getElementById(""textarea"").innerText="""";
document.getElementById(""textarea"").value="""";
}

</script>

<div class=""row"">
    <div class=""col"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7837bfa59bbe3bc227b937c3d559bb5fb1389a55885", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <div class=""col-md-10"">
                    <p>Upload one or more files using this form:</p>
                    <input type=""file"" id=""files"" name=""files"" multiple/>
                </div>
            </div>
            <div class=""form-group"">
                <div class=""col-md-10"">
                    <input type=""submit"" value=""Upload""/>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n\n    <div class=\"col\">\n        <p>Push Message</p>\n        <div class=\"signalr-demo\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7837bfa59bbe3bc227b937c3d559bb5fb1389a58382", async() => {
                WriteLiteral("\n                <input type=\"text\" id=\"message-box\"/>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <hr/>\n            <ul id=\"messages\"></ul>\n        </div>\n    </div>\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7837bfa59bbe3bc227b937c3d559bb5fb1389a59857", async() => {
                WriteLiteral("\n    <div class=\"form-group\">\n        <div class=\"col-md-10\">\n            <p>Save string</p>\n            <textarea class=\"form-control\" name=\"textarea\" id=\"textarea\" rows=\"3\"");
                BeginWriteAttribute("value", " value=\"", 2087, "\"", 2111, 1);
#nullable restore
#line 72 "D:\Mywork\myecommercehelper\FileUploader2-master\FileUploader2-master\FileUploader2\Views\Home\Index.cshtml"
WriteAttributeValue("", 2095, ViewData["url"], 2095, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 72 "D:\Mywork\myecommercehelper\FileUploader2-master\FileUploader2-master\FileUploader2\Views\Home\Index.cshtml"
                                                                                                      Write(ViewData["url"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n        </div>\n    </div>\n    <div class=\"form-group\">\n        <div class=\"col-md-10\">\n            <input type=\"submit\" value=\"save\"/>\n        </div>\n    </div>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("<div class=\"form-group\">\n    <div class=\"col-md-10\">\n        <input type=\"submit\" onclick=\"clear3()\" id=\"cl\" class=\"btn btn-primary\" value=\"Clear\"/>\n    </div>\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7837bfa59bbe3bc227b937c3d559bb5fb1389a513128", async() => {
                WriteLiteral("\n    <div class=\"form-group\">\n        <div class=\"col-md-10\">\n            <p>Save string</p>\n            <textarea class=\"form-control\" name=\"textarea2\"  id=\"textarea2\" rows=\"3\"");
                BeginWriteAttribute("value", " value=\"", 2838, "\"", 2863, 1);
#nullable restore
#line 95 "D:\Mywork\myecommercehelper\FileUploader2-master\FileUploader2-master\FileUploader2\Views\Home\Index.cshtml"
WriteAttributeValue("", 2846, ViewData["url2"], 2846, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 95 "D:\Mywork\myecommercehelper\FileUploader2-master\FileUploader2-master\FileUploader2\Views\Home\Index.cshtml"
                                                                                                          Write(ViewData["url2"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n        </div>\n    </div>\n    <div class=\"form-group\">\n        <div class=\"col-md-10\">\n            <input type=\"submit\" value=\"save\"/>\n        </div>\n    </div>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral(@"<div class=""form-group"">
    <div class=""col-md-10"">
        <input type=""submit"" onclick=""clear2()"" class=""btn btn-primary"" value=""Clear""/>
    </div>
</div>

<center>
    <a href=""/Files"">
        <button class=""btn btn-primary"">Show Uploads</button>
    </a>
</center>


<script");
            BeginWriteAttribute("src", " src=\"", 3418, "\"", 3499, 3);
            WriteAttributeValue("", 3424, "https://unpkg.com/", 3424, 18, true);
            WriteLiteral("@");
            WriteAttributeValue("", 3444, "aspnet/signalr", 3444, 14, true);
            WriteLiteral("@");
            WriteAttributeValue("", 3460, "1.0.0-rc1-final/dist/browser/signalr.js", 3460, 39, true);
            EndWriteAttribute();
            WriteLiteral(@"></script>

<script type=""text/javascript"">
    const messageForm =  document.getElementById('message-form');
    const messageBox = document.getElementById('message-box');
    const messages = document.getElementById('messages');
    
    const connection = new signalR.HubConnectionBuilder()
        .withUrl(""/chat"")
        .configureLogging(signalR.LogLevel.Information)
        .build();
        
    connection.on('newMessage', (sender, messageText) => {
        console.log(`${sender}:${messageText}`);
        
        const newMessage = document.createElement('li');
        newMessage.appendChild(document.createTextNode(`${sender}:${messageText}`));
         
          let htmlElement = newMessage.appendChild(document.createElement('Button'));
                 htmlElement.click=myFunction(messageText)
                 htmlElement.innerText=""Copy text"";
        messages.appendChild(newMessage);
    }); 
    connection.on('newMessage2', (sender, messageText) => {
        console.log(`${sender}:${messageText");
            WriteLiteral(@"}`);
        
        const newMessage = document.createElement('li');
        newMessage.appendChild(document.createTextNode(`${sender}:${messageText}`));
        let htmlElement = newMessage.appendChild(document.createElement('Button'));
        htmlElement.click=myFunction(messageText);
        htmlElement.innerText=""Copy text"";
        messages.appendChild(newMessage);
    });
    
    connection.start()
        .then(() => console.log('connected!'))
        .catch(console.error);
        
    messageForm.addEventListener('submit', ev => {
        ev.preventDefault();
        const message = messageBox.value;
        connection.invoke('SendMessage', message);
        messageBox.value = '';
    });
    
    function myFunction(value) {

      navigator.clipboard.writeText(value);
    
      /* Alert the copied text */
      // alert(""Copied the text: "" + value);
    }
</script>");
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
