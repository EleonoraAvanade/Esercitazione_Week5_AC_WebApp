#pragma checksum "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\Piatto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ae34e852fcbf8380ffb50e70dbff64cf1625be8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Piatto_Index), @"mvc.1.0.view", @"/Views/Piatto/Index.cshtml")]
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
#line 1 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\_ViewImports.cshtml"
using WebApplication_Week5_AC_Esercitazione;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\_ViewImports.cshtml"
using Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ae34e852fcbf8380ffb50e70dbff64cf1625be8", @"/Views/Piatto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f23d74e7296799419cbf9c2d61d1099fb7928fb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Piatto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Piatto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\Piatto\Index.cshtml"
   ViewBag.Piatti = Model.Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\Piatto\Index.cshtml"
 if (User.IsInRole("Administrator"))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ae34e852fcbf8380ffb50e70dbff64cf1625be84420", async() => {
                WriteLiteral("Aggiungi un piatto al menù");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\Piatto\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<table class=""table"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Descrizione</th>
            <th>Tipologia</th>
            <th>Prezzo</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\Piatto\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\Piatto\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\Piatto\Index.cshtml"
               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\Piatto\Index.cshtml"
               Write(item.Descrizione);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\Piatto\Index.cshtml"
               Write(item.Tipologia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\Piatto\Index.cshtml"
               Write(item.Prezzo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\Piatto\Index.cshtml"
               Write(Html.ActionLink("Dettagli", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 37 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\Piatto\Index.cshtml"
               Write(Html.ActionLink("Modifica", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 38 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\Piatto\Index.cshtml"
               Write(Html.ActionLink("Rimuovi", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\Piatto\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td># Numero piatti</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\eleonora.lombardo\Desktop\WebApplication_Week5_AC_Esercitazione\WebApplication_Week5_AC_Esercitazione\Views\Piatto\Index.cshtml"
           Write(ViewBag.NumPiatti);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tfoot>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Piatto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
