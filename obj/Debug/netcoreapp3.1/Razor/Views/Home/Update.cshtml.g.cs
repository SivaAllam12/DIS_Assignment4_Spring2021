#pragma checksum "C:\Users\Siva Allam\source\repos\DIS_Assignment4_Spring2021\Views\Home\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e70bebcdd652249f17dd638983ec7b59afdf29fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Update), @"mvc.1.0.view", @"/Views/Home/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70bebcdd652249f17dd638983ec7b59afdf29fc", @"/Views/Home/Update.cshtml")]
    public class Views_Home_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DIS_Assignment4_Spring2021.Models.Covid_Condition>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e70bebcdd652249f17dd638983ec7b59afdf29fc2809", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Update</title>
    <link rel=""shortcut icon"" type=""image/png"" href=""/img/covid-19_logo.jpg"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/styles.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/styles_Aakash.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl"" crossorigin=""anonymous"">
    <script>
$(function(){
        $(""#nav-bar"").load(""/BootNav.html"");
        // $(""#includedCarousel"").load(""carousel.html"");
        $(""#footer"").load(""/footer.html"");
      });</script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e70bebcdd652249f17dd638983ec7b59afdf29fc4749", async() => {
                WriteLiteral(@"
    <div id=""nav-bar""></div>
    <!-- Option 1: Bootstrap Bundle with Popper -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-b5kHyXgcpbZJO/tY9Ul7kGkf1S0CWuKcCD38l8YkeH8z8QjE0GmW1gYU5S9FOnJ0"" crossorigin=""anonymous""></script>
    <script src=""https://kit.fontawesome.com/f4cc93c88a.js"" crossorigin=""anonymous""></script>
    <div id=""includedContent""></div>
    <div class=""center"">
        <!-- <img class=""d-block w-100"" src=""img/blue-covid-banner.jpg"" alt=""First slide""> -->
        <h1></h1>
        <!-- <table style=""width:100%"" class=""center""> -->
        <table class=""styled-table"">
            <thead>
                <tr>
                    <th colspan=""5"">Update Record</th>
                </tr>
            </thead>
            <tr>
            <tr>
                <td>
                    <form>
                        <label>Condition Group<br></label><br>
                        <input type=""text"" name=""Cond");
                WriteLiteral("ition Group\" readonly");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2090, "\"", 2126, 1);
#nullable restore
#line 44 "C:\Users\Siva Allam\source\repos\DIS_Assignment4_Spring2021\Views\Home\Update.cshtml"
WriteAttributeValue("", 2104, Model.condition_group, 2104, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""background-color:#d8d8d8;""><br>
                    </form>
                </td>
                <td>
                    <form>
                        <label>Condition<br></label><br>
                        <input type=""text"" name=""Condition"" readonly");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2396, "\"", 2426, 1);
#nullable restore
#line 50 "C:\Users\Siva Allam\source\repos\DIS_Assignment4_Spring2021\Views\Home\Update.cshtml"
WriteAttributeValue("", 2410, Model.condition, 2410, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"background-color:#d8d8d8;\"><br>\r\n                    </form>\r\n                </td>\r\n\r\n                <td>\r\n\r\n");
#nullable restore
#line 56 "C:\Users\Siva Allam\source\repos\DIS_Assignment4_Spring2021\Views\Home\Update.cshtml"
                     using (Html.BeginForm("UpdateRecord", "Home", new { cond = Model.condition }))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Siva Allam\source\repos\DIS_Assignment4_Spring2021\Views\Home\Update.cshtml"
                   Write(Html.HiddenFor(m => m.CaseId));

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <label for=\"fname\">Total Covid deaths<br> <br></label><br>\r\n                        <input type=\"text\" id=\"fname\" name=\"covid_19_deaths\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2886, "\"", 2922, 1);
#nullable restore
#line 60 "C:\Users\Siva Allam\source\repos\DIS_Assignment4_Spring2021\Views\Home\Update.cshtml"
WriteAttributeValue("", 2900, Model.covid_19_deaths, 2900, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><br><br />\r\n                        <input class=\"tablink\" type=\"submit\" value=\"Update\" style=\"background-color:darkslategray\"\r\n                               onclick=\"return postMessage(\'Updated Succesfully\');\"/>\r\n");
#nullable restore
#line 63 "C:\Users\Siva Allam\source\repos\DIS_Assignment4_Spring2021\Views\Home\Update.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                   </td>

                </tr>
        </table>
        <!-- <img src=""usf-logo-png-2.png"" alt=""university logo""> -->
        <h5 class=""styled-table"" style=""color:white;background-color:darkslategray"">Explore the underlying conditions of people who are dying from Covid-19 in the United States. We in no way through our Website imply that these condistions can aggravate conditions of people suffering from Covid-19 .Through our statistics we can showcase only relations and no causation.</h5>
    </div>
    <div id=""includedCarousel""></div>
    <!-- <button class=""tablink"" onclick="""">2020</button>&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp; -->
    <!-- <button class=""tablink"" onclick="""">2021</button> -->
    <!-- Load footer -->
    <div id=""footer""></div>
    <!--  -->
    <!-- Option 1: Bootstrap Bundle with Popper -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-b5kHyXgcpbZJO/tY9Ul7kGkf1S0CWuKcCD38l8Y");
                WriteLiteral("keH8z8QjE0GmW1gYU5S9FOnJ0\" crossorigin=\"anonymous\"></script>\r\n    <script src=\"https://kit.fontawesome.com/f4cc93c88a.js\" crossorigin=\"anonymous\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DIS_Assignment4_Spring2021.Models.Covid_Condition> Html { get; private set; }
    }
}
#pragma warning restore 1591
