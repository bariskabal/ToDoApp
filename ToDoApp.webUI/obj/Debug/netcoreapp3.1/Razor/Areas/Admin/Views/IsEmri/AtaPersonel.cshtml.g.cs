#pragma checksum "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b294031b061db3789d4305bd120a55f471bb4ce4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_IsEmri_AtaPersonel), @"mvc.1.0.view", @"/Areas/Admin/Views/IsEmri/AtaPersonel.cshtml")]
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
#line 4 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\_ViewImports.cshtml"
using ToDoApp.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\_ViewImports.cshtml"
using ToDoApp.DTO.DTOs.AciliyetDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\_ViewImports.cshtml"
using ToDoApp.DTO.DTOs.BildirimDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\_ViewImports.cshtml"
using ToDoApp.DTO.DTOs.GorevDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\_ViewImports.cshtml"
using ToDoApp.DTO.DTOs.AppUserDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b294031b061db3789d4305bd120a55f471bb4ce4", @"/Areas/Admin/Views/IsEmri/AtaPersonel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b47b0639e8bdaff3360ff31f53f29091ae6bb87", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_IsEmri_AtaPersonel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GorevListDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtaPersonel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:10rem!important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GorevlendirPersonel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark btn-sm  float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::ToDoApp.webUI.TagHelpers.GorevAppUserIdTagHelper __ToDoApp_webUI_TagHelpers_GorevAppUserIdTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
  
    Layout="~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    string s = (string)ViewBag.Aranan;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-md-12 mb-2\">\r\n\r\n");
#nullable restore
#line 12 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
         if (!string.IsNullOrWhiteSpace(s))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"border border-dark p-3 mb-2\">\r\n                <strong>\r\n                    ");
#nullable restore
#line 16 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
               Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </strong> kelimesi için sonuclar\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b294031b061db3789d4305bd120a55f471bb4ce48614", async() => {
                WriteLiteral("Filtreyi kaldır");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                              WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 20 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b294031b061db3789d4305bd120a55f471bb4ce411160", async() => {
                WriteLiteral("\r\n            <input type=\"text\" name=\"s\" class=\"form-control-sm border-primary border-top-0 border-left-0 border-right-0\">\r\n            <button type=\"submit\" class=\"btn btn-primary btn-sm\">Ara</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" 
    </div>
    <div class=""col-md-4"">
        <div class=""card  "">
            <div class=""card-header"">
                <h4 class=""text-center lead pt-2"">Görev Bilgileri</h4>
            </div>
                    
            <div class=""card-body"">
                <h5 class=""card-title"">");
#nullable restore
#line 36 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                  Write(Model.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 37 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                Write(Model.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">\r\n                    <strong>Aciliyet Durumu : </strong><span class=\"badge badge-primary\">");
#nullable restore
#line 39 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                    Write(Model.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>         \r\n                </p>\r\n                <p class=\"card-text\">\r\n                    <small>\r\n                        ");
#nullable restore
#line 43 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                   Write(Model.OlusturulmaTarih.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </small>\r\n                </p>\r\n                \r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-8\">\r\n\r\n        \r\n\r\n\r\n");
#nullable restore
#line 55 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
         foreach (var item in (List<AppUserListDto>)ViewBag.Personeller)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card  mb-3 p-2\">\r\n                <div class=\"row no-gutters\">\r\n                    <div class=\"col-md-4\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b294031b061db3789d4305bd120a55f471bb4ce415562", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1954, "~/img/", 1954, 6, true);
#nullable restore
#line 60 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
AddHtmlAttributeValue("", 1960, item.Picture, 1960, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 60 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
AddHtmlAttributeValue("", 2030, item.Name, 2030, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-8\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 64 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 64 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                         Write(item.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getirGorevAppUserId", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b294031b061db3789d4305bd120a55f471bb4ce418578", async() => {
            }
            );
            __ToDoApp_webUI_TagHelpers_GorevAppUserIdTagHelper = CreateTagHelper<global::ToDoApp.webUI.TagHelpers.GorevAppUserIdTagHelper>();
            __tagHelperExecutionContext.Add(__ToDoApp_webUI_TagHelpers_GorevAppUserIdTagHelper);
#nullable restore
#line 66 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
__ToDoApp_webUI_TagHelpers_GorevAppUserIdTagHelper.AppUserId = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("app-user-id", __ToDoApp_webUI_TagHelpers_GorevAppUserIdTagHelper.AppUserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </p>\r\n                            <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 68 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                      Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b294031b061db3789d4305bd120a55f471bb4ce420448", async() => {
                WriteLiteral("Görevlendir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-PersonelId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PersonelId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PersonelId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PersonelId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["GorevId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-GorevId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["GorevId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 75 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <nav aria-label=\"Page navigation example\">\r\n                <ul class=\"pagination\">\r\n");
#nullable restore
#line 78 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                     if (!string.IsNullOrWhiteSpace(s))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                         for (int i = 1; i <= ViewBag.ToplamSayfa; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("class", " class=\"", 3169, "\"", 3223, 2);
            WriteAttributeValue("", 3177, "page-item", 3177, 9, true);
#nullable restore
#line 82 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
WriteAttributeValue(" ", 3186, ViewBag.AktifSayfa==i?"active":"", 3187, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b294031b061db3789d4305bd120a55f471bb4ce425229", async() => {
#nullable restore
#line 83 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                                                                        Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                                            WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sayfa"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sayfa", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sayfa"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                                                             WriteLiteral(s);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["s"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-s", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["s"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 85 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                           
                    }
                    else{
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                         for (int i = 1; i <= ViewBag.ToplamSayfa; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("class", " class=\"", 3621, "\"", 3675, 2);
            WriteAttributeValue("", 3629, "page-item", 3629, 9, true);
#nullable restore
#line 90 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
WriteAttributeValue(" ", 3638, ViewBag.AktifSayfa==i?"active":"", 3639, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b294031b061db3789d4305bd120a55f471bb4ce430833", async() => {
#nullable restore
#line 91 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                                            WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sayfa"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sayfa", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sayfa"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 93 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\baris\OneDrive\Masaüstü\AspNet\ToDoApp\ToDoApp.webUI\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                           
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                </ul>\r\n            </nav>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GorevListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
