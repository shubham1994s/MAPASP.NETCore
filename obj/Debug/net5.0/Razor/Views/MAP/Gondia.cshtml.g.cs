#pragma checksum "D:\Rohit\MaharashtraMapProject\Views\MAP\Gondia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c7c79f75e7fb1a470816423836a2cf4d4c77d83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MAP_Gondia), @"mvc.1.0.view", @"/Views/MAP/Gondia.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c7c79f75e7fb1a470816423836a2cf4d4c77d83", @"/Views/MAP/Gondia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e1f6972b5cad2d391b9717ba715955e7d9a4322", @"/Views/_ViewImports.cshtml")]
    public class Views_MAP_Gondia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MAPWEBAPP.Models.AdminMapULBDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.maphilight.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/tooltip.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c7c79f75e7fb1a470816423836a2cf4d4c77d835179", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css""
          integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css""
          integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <title>SWM</title>
    <script src=""https://code.jquery.com/jquery-3.3.1.min.js"" integrity=""sha384-tsQFqpEReu7ZLhBV2VZlAu7zcOV+rXbYlF2cqB8txI/8aZajjp4Bqd+V6D5IgvKT"" crossorigin=""anonymous""></script>
    <script src=""https://code.jquery.com/jquery-migrate-3.0.0.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c7c79f75e7fb1a470816423836a2cf4d4c77d836447", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c7c79f75e7fb1a470816423836a2cf4d4c77d837633", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link href=\"https://code.jquery.com/ui/1.10.4/themes/ui-lightness/jquery-ui.css\"\r\n          rel=\"stylesheet\">\r\n    <script src=\"https://code.jquery.com/ui/1.10.4/jquery-ui.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5c7c79f75e7fb1a470816423836a2cf4d4c77d838935", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral(@"

    </script>
    <script type=""text/javascript"">
        $(function () {
            $('.map').maphilight();
        });
        $(function () {


            $('area[title]').click(function () {
                var $this = $(this);
                $this.blur();
                setTimeout(function () {
                    $this.show()
                }, 1);
            });

        });
    </script>
    <style type=""text/css"">
        .border-dark1 {
            border-color: #c2c2c2;
        }

        .head-color {
            background: #065d96;
            color: white;
        }

        .list-group-item {
            padding: .5rem 1.25rem;
        }

        .count-color {
            background: #e8e8e8;
        }

        body {
            background: #fff;
            ;
        }

        .bg-footer {
            background: #0d3845;
        }

        .bg-black {
            background: #000
        }

        .popover-header {
            fo");
                WriteLiteral(@"nt-size: 75%;
        }

        .bg-1 {
            background: url(/Images/BG1.png);
            /* height: 323px; */
            background-position: bottom;
            background-size: cover;
            /* background-repeat: round;*/
        }
        /*  .sec td{line-height:8px !important}*/
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c7c79f75e7fb1a470816423836a2cf4d4c77d8312246", async() => {
                WriteLiteral(@"

    <header>
        <div class=""d-flex justify-content-between py-2 bg-1"" style=""padding-left:5%;padding-right:5%"">
            <img src=""/Images/Final Azadi Ka Amrit Mahotsav_Logo.png"" style=""height:55px;"" />
            <img src=""/Images/Embelem.png"" style=""height:55px;"" />
            <img src=""/Images/linkImages/EK-Kdam-Logo.png"" style=""height:55px;"" />
        </div>
    </header>
    <div class=""d-flex"">
        <!-- Count List -->
");
                WriteLiteral(@"        <!-- ImageMap Start -->
        <div class=""border border-dark rounded"">
            <h4 class=""text-center mx-0 bg-danger text-white mb-0""> Map of Gondia</h4>
            <img src=""/Images/GadchiroliMap/Gondia-tehsil-map.jpg"" usemap=""#image-map"" id=""img_ID"" class=""map"" style=""width: 100%;"">

            <map name=""image-map"" id=""map_ID"">
                <area target=""new"" alt=""Goregaon"" id=""3105""");
                BeginWriteAttribute("title", " title=\"", 5750, "\"", 5758, 0);
                EndWriteAttribute();
                WriteLiteral(@" href=""https://ictsbm.com/?returnUrl=goregaonwaste@ulb.com&Type=W"" coords=""295,277,302,269,309,261,305,256,310,251,310,244,312,234,314,223,319,215,312,203,319,197,333,197,338,189,335,178,342,175,350,176,362,181,369,186,377,181,384,179,390,183,394,189,405,184,414,192,419,197,425,192,432,189,436,196,435,205,443,211,439,221,438,227,449,223,455,226,463,229,459,237,456,243,453,248,458,255,463,251,468,253,475,261,484,254,492,250,490,258,486,263,480,267,480,274,478,282,472,278,471,284,472,290,479,288,484,293,489,299,487,304,487,313,496,315,498,322,496,331,500,338,493,340,486,342,491,352,484,354,476,353,478,362,471,366,471,373,459,378,449,376,444,367,437,367,431,367,431,358,440,358,449,354,452,346,453,335,450,328,441,328,434,327,428,326,421,325,413,319,408,325,400,328,394,324,392,316,396,309,387,306,378,306,377,297,370,295,364,305,360,297,354,293,349,291,342,291,332,287,324,280,307,278"" shape=""poly"">

            </map>

        </div>


");
                WriteLiteral("    </div>\r\n\r\n\r\n");
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
            WriteLiteral(@"

</html>


<script type=""text/javascript"">
   

    window.onload = function () {
        var ImageMap = function (map, img) {
            var n,
                areas = map.getElementsByTagName('area'),
                len = areas.length,
                coords = [],
                previousWidth = 800;
            for (n = 0; n < len; n++) {
                coords[n] = areas[n].coords.split(',');
            }
            this.resize = function () {
                var n, m, clen,
                    x = img.offsetWidth / previousWidth;
                for (n = 0; n < len; n++) {
                    clen = coords[n].length;
                    for (m = 0; m < clen; m++) {
                        coords[n][m] *= x;
                    }
                    areas[n].coords = coords[n].join(',');
                }
                previousWidth = img.offsetWidth;
                return true;
            };
            window.onresize = this.resize;
        },
            imageM");
            WriteLiteral("ap = new ImageMap(document.getElementById(\'map_ID\'), document.getElementById(\'img_ID\'));\r\n        imageMap.resize();\r\n        return;\r\n    }\r\n\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MAPWEBAPP.Models.AdminMapULBDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
