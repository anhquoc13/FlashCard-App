#pragma checksum "C:\Users\ASUS\Desktop\FlashCard-App\CleanArch\FlashCard\Views\Shared\Modal\_createFolderModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4ea05550b9472f6781222bfde3e7b5e3717ae26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Modal__createFolderModal), @"mvc.1.0.view", @"/Views/Shared/Modal/_createFolderModal.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\FlashCard-App\CleanArch\FlashCard\Views\_ViewImports.cshtml"
using FlashCard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\FlashCard-App\CleanArch\FlashCard\Views\_ViewImports.cshtml"
using FlashCard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4ea05550b9472f6781222bfde3e7b5e3717ae26", @"/Views/Shared/Modal/_createFolderModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53f6db93bf1d1dbc4055aae4225aca24f9a9a471", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Modal__createFolderModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Create Folder Modal Start -->
<div class=""modal fade"" id=""createFolderModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header modal-header-primary"">
                <h1 class=""modal-title"" id=""exampleModalLabel"">
                    Tạo thư mục mới
                </h1>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <i class=""fas fa-window-close""></i>
                </button>

            </div>
            <div class=""modal-body"">
                <!-- Input Form -->
                <div class=""form-group form-floating-label mt-2"">
                    <input id=""TitleFolderLabel"" type=""text"" class=""form-control input-border-bottom form-control-lg""");
            BeginWriteAttribute("required", " required=\"", 907, "\"", 918, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <label for=""TitleFolderLabel"" class=""placeholder"">
                        <h4><b>Tiêu đề</b></h4>
                    </label>
                </div>
                
                <div class=""form-group form-floating-label mt-5 mb-5"">
                    <input id=""DescribeFolderLabel"" type=""text"" class=""form-control input-border-bottom form-control-lg""");
            BeginWriteAttribute("required", " required=\"", 1307, "\"", 1318, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <label for=\"DescribeFolderLabel\" class=\"placeholder\">\r\n                        <h4><b>Mô tả</b></h4>\r\n                    </label>\r\n                </div>\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1518, "\"", 1525, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""col"" style=""text-decoration: none;"">
                    <div class=""card _cardbtn card-stats card-round"" style=""border: 2px solid #716aca;"">
                        <div class=""card-body text-center text-dark"" style=""font-size: 2em;"">
                            <b>Tạo thư mục</b>
                        </div>
                    </div>
                </a>

            </div>
        </div>
    </div>
</div>
<!-- Create Folder Modal End -->");
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
