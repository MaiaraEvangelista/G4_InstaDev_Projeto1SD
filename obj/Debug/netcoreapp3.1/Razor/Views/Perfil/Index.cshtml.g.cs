#pragma checksum "C:\Users\fic\Desktop\G4_InstaDev_Projeto1SD\Views\Perfil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab0dcd0c1aa64f9bf6a002babd95557d2a72ba08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfil_Index), @"mvc.1.0.view", @"/Views/Perfil/Index.cshtml")]
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
#line 1 "C:\Users\fic\Desktop\G4_InstaDev_Projeto1SD\Views\_ViewImports.cshtml"
using G4_InstaDev_Projeto1SD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fic\Desktop\G4_InstaDev_Projeto1SD\Views\_ViewImports.cshtml"
using G4_InstaDev_Projeto1SD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab0dcd0c1aa64f9bf6a002babd95557d2a72ba08", @"/Views/Perfil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d792a540240e9e730745d7aca43c2c7c3e091190", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Perfil>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Perfil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\fic\Desktop\G4_InstaDev_Projeto1SD\Views\Perfil\Index.cshtml"
  
    ViewData["Title"] = "Perfil";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <main class=""corpo"">
        
        <section class=""perfil"">

            <div class=""pp"">

                <div class=""foto-perfil"">
                    <div class=""circulo"">
                        <img style=""border-radius: 100%;"" src=""img/padrao.png"" alt=""foto de perfil"">
                    </div>
                </div>

                <div class=""inf"">
                    <div class=""nome"">
                        <p>yes_baby</p>
                    </div>

                    <div class=""nume"">
                        <p class=""est"">1 Publicações</p>
                        <p class=""est"">128 seguindo</p>
                        <p class=""est"">214 seguidores</p>
                    </div>

                    <div class=""nume"">
                        <p class=""est"">Marcus Jeeves</p>
                        <a href=""#"">Sair</a>
                        <a href=""#"">Editar Perfil</a>
                    </div>

                </div>

            </div>

        </se");
            WriteLiteral("ction>\r\n        \r\n        <div class=\"linha\"></div>\r\n\r\n        <div class=\"pub\">\r\n            <div class=\"pub-img\">\r\n                <img src=\"img/image 1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1242, "\"", 1248, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <p>Publicações</p>
            </div>
        </div>

        <br></br>
       
        <section class=""publicacao"">

            <div class=""publi"">

                <div class=""publi-pub"">
                    <img src=""img/padrao.png""");
            BeginWriteAttribute("alt", " alt=\"", 1515, "\"", 1521, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>

                <div class=""inf-pub"">
                    
                    <div class=""inf-pub-img"">

                        <div class=""ball"">
                            <div class=""boll"">
                                <img style=""border-radius: 100%;"" src=""img/padrao.png""");
            BeginWriteAttribute("alt", " alt=\"", 1839, "\"", 1845, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>

                        <div class=""meio"">
                            <div class=""meio-1"">
                                <h4>Marcus Jeeves</h2>
                            </div>
                            <div class=""meio-2"">
                                <h5>Rio de Janeiro</h5>
                            </div>
                        </div>
                    </div>
                        

                    <div class=""botao"">
                            <div class=""content-txt"">
                                    <div class=""content-heart"">
                                        <i onclick=""Toggle()"" id=""btn"" class=""far fa-heart""></i>
                                    </div>
                                    <span class=""numb""></span>
                                    <span class=""text"">Curtidas</span>
                                </div>
                            </div>

");
#nullable restore
#line 92 "C:\Users\fic\Desktop\G4_InstaDev_Projeto1SD\Views\Perfil\Index.cshtml"
                         foreach (Perfil x in ViewBag.Perfil)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"coments\">\r\n                        <div class=\"title\">\r\n                            <h6>nome</h6>\r\n                        </div>\r\n                        <div class=\"txt\">\r\n                        <p>");
#nullable restore
#line 100 "C:\Users\fic\Desktop\G4_InstaDev_Projeto1SD\Views\Perfil\Index.cshtml"
                      Write(x.Coments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"delet\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab0dcd0c1aa64f9bf6a002babd95557d2a72ba088932", async() => {
                WriteLiteral("<img class=\"delete-img\" src=\"img/lixo.png\">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\Users\fic\Desktop\G4_InstaDev_Projeto1SD\Views\Perfil\Index.cshtml"
                                                                                                          WriteLiteral(x.IdComentarios);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 104 "C:\Users\fic\Desktop\G4_InstaDev_Projeto1SD\Views\Perfil\Index.cshtml"
                    
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"coments2\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab0dcd0c1aa64f9bf6a002babd95557d2a72ba0811853", async() => {
                WriteLiteral("\r\n                            <input name=\"comentario\" class=\"comentario\" placeholder=\"Digite aqui\" type=\"text\">\r\n                            <button type=\"submit\" class=\"bbtn\">Comentar...</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 108 "C:\Users\fic\Desktop\G4_InstaDev_Projeto1SD\Views\Perfil\Index.cshtml"
AddHtmlAttributeValue("", 3590, Url.Action("Comentar"), 3590, 23, false);

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
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n                \r\n            </div>\r\n\r\n        </section>\r\n\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Perfil> Html { get; private set; }
    }
}
#pragma warning restore 1591
