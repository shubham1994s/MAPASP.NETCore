#pragma checksum "D:\Rohit\MaharashtraMapProject\Views\Home\welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed1eb8a195c6c6452068aaa9f2ef8c0936a4f722"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_welcome), @"mvc.1.0.view", @"/Views/Home/welcome.cshtml")]
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
#line 1 "D:\Rohit\MaharashtraMapProject\Views\_ViewImports.cshtml"
using MAPWEBAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rohit\MaharashtraMapProject\Views\_ViewImports.cshtml"
using MAPWEBAPP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed1eb8a195c6c6452068aaa9f2ef8c0936a4f722", @"/Views/Home/welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e1f6972b5cad2d391b9717ba715955e7d9a4322", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/wstyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Rohit\MaharashtraMapProject\Views\Home\welcome.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed1eb8a195c6c6452068aaa9f2ef8c0936a4f7224942", async() => {
                WriteLiteral("\r\n    <title>Maharashtra Map</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ed1eb8a195c6c6452068aaa9f2ef8c0936a4f7225242", async() => {
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
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ed1eb8a195c6c6452068aaa9f2ef8c0936a4f7226647", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
    <style>
        .modal {
            display: block !important
        }

        #ribbon {
            z-index: 999;
            display: block;
            position: absolute;
            top: 50%;
            left: 0;
            width: 100vw;
            transform: translateY(-50%);
            background: pink;
            float: left;
            cursor: pointer;
        }

            #ribbon .bow {
                z-index: 999;
                left: 50%;
                top: 50%;
                position: absolute;
                width: 20rem;
                height: 10rem;
                background-image: url(https://pics.clipartpng.com/midle/Beautiful_Red_Bow_PNG_Clipart-518.png);
                background-repeat: no-repeat;
                background-size: contain;
                background-position: center;
                transform: translate(-50%, -50%);
         ");
                WriteLiteral(@"       z-index: 10;
            }

                #ribbon .bow.hide {
                    z-index: 0;
                    transition: transform 2s ease-in-out, opacity .1s ease 2s;
                    transform: translateY(-2000rem) rotate(360deg);
                    opacity: 0;
                    transform-origin: top left;
                }

            #ribbon .ribbon--r,
            #ribbon .ribbon--l {
                z-index: 0;
                position: absolute;
                background-color: #a7002c;
                width: 50vw;
                height: 1.5rem;
            }

            #ribbon .ribbon--r {
                z-index: 0;
                right: 0;
            }

                #ribbon .ribbon--r.hide {
                    z-index: 0;
                    transition: transform 5s ease-in-out;
                    transform: translateX(1000rem) rotate(90deg);
                    transform-origin: botttom right;
                }

            #ribbon .ri");
                WriteLiteral(@"bbon--l {
                z-index: 0;
                left: 0;
            }

                #ribbon .ribbon--l.hide {
                    z-index: 0;
                    transition: transform 5s ease-in-out;
                    transform: translateX(-1000rem) rotate(-90deg);
                    transform-origin: bottom left;
                }

        #imgFollow {
            z-index: 999;
            transform: rotate(0deg);
            width: 5rem;
        }
    </style>
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed1eb8a195c6c6452068aaa9f2ef8c0936a4f72211238", async() => {
                WriteLiteral("\r\n\r\n    <!-- particles.js container -->\r\n    <!--<div id=\"particles-js\"></div>\r\n    <a href=\"");
#nullable restore
#line 104 "D:\Rohit\MaharashtraMapProject\Views\Home\welcome.cshtml"
        Write(Url.Action("Maharashtra", "MAP"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""">-->
    <!-- The Modal -->
    <!--<div class=""modal"" id=""overlay"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">-->
    <!-- Modal body -->
    <!--<div class=""modal-body"">
                        <img class=""popupimg1"" src=""/Images/linkImages/abhnandanl.png"" /><br>
                        <img class=""popupimg2"" src=""/Images/linkImages/Gadchiroli-Tahsil.png"" />
                    </div>



                </div>
            </div>
        </div>
    </a>-->
    <!-- scripts -->
    <!--<script src=""~/js/particles.js""></script>
    <script src=""~/js/app.js""></script>-->
    <!-- stats.js -->
    <!--<script src=""~/js/stats.js""></script>-->


    <div id=""ribbon"">
        <div class=""ribbon bow""></div>
        <div class=""ribbon ribbon--l""></div>
        <div class=""ribbon ribbon--r""></div>
    </div>

    <img id=""imgFollow"" style=""position: relative;"" class=""imgFollow"" src=""https://upload.wikimedia.org/wikipedia/commons/7/74/Scissors_icon_black.sv");
                WriteLiteral(@"g"" />

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"" integrity=""sha512-894YE6QWD5I59HgZOGReFYm4dnWc1Qt5NtvYSaNcOP+u1T9qYdvdihz0PPSiiqn/+/3e7Jo4EaG7TubfWGUrMQ=="" crossorigin=""anonymous""></script>

    <script>
        $(document).ready(function () {
            if (localStorage.getItem('ribbonCut') != 'cut') {
                $('.ribbon').delay(2000).fadeIn();
                $('#imgFollow').delay(2000).fadeIn();
            };

            $("".ribbon"").click(function () {
                $("".ribbon--l"").addClass(""hide"");
                $("".ribbon--r"").addClass(""hide"");
                $("".bow"").addClass(""hide"");
                $(""#imgFollow"").hide();
                window.location.href = ""/MAP/Maharashtra"";
                localStorage.setItem('ribbonCut', 'cut')

            });
        });
       
        $(document).mousemove(function (e) {
            $('#imgFollow').offset({
                left: e.pageX + 30,
                top: e.pageY ");
                WriteLiteral("- 20\r\n            });\r\n            $(\'#imgFollow\').css(\'z-index\', \'1000\');\r\n        });\r\n    </script>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
