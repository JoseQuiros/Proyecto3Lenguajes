#pragma checksum "C:\Users\jqm25\OneDrive\Documentos\GitHub\Proyecto3Lenguajes\EjemploMVC\Views\Producto\RegistrarGym.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6366d584968fcb39940f8964c8de2f639c11c83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_RegistrarGym), @"mvc.1.0.view", @"/Views/Producto/RegistrarGym.cshtml")]
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
#line 1 "C:\Users\jqm25\OneDrive\Documentos\GitHub\Proyecto3Lenguajes\EjemploMVC\Views\_ViewImports.cshtml"
using EjemploMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jqm25\OneDrive\Documentos\GitHub\Proyecto3Lenguajes\EjemploMVC\Views\_ViewImports.cshtml"
using EjemploMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6366d584968fcb39940f8964c8de2f639c11c83", @"/Views/Producto/RegistrarGym.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a95f43b4bd5f52233104f97e714d3c5fed198f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_RegistrarGym : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Producto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegistrarGym", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\jqm25\OneDrive\Documentos\GitHub\Proyecto3Lenguajes\EjemploMVC\Views\Producto\RegistrarGym.cshtml"
  
    ViewData["Title"] = "RegistrarGym";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Registrar nuevo gym</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6366d584968fcb39940f8964c8de2f639c11c834528", async() => {
                WriteLiteral(@"
    <div id=""recup"" class=""col-12"">
        <div>
            <label for=""nombre"">Nombre del gym</label>
            <input type=""text"" id=""nombre"" name=""nombre"" required />
        </div>
        <div>
            <label for=""pass"">contraseña</label>
            <input type=""password"" id=""pass"" name=""pass"" required />
        </div>
        <div>
            <label for=""descripcion"">descripcion</label>
            <input type=""text"" id=""descripcion"" name=""descripcion"" required />
        </div>
        <div>
            <label for=""direccion"">direccion</label>
            <input type=""text"" id=""direccion"" name=""direccion"" required />
        </div>
        <div>
            <label for=""telefono"">telefono</label>
            <input type=""text"" id=""telefono"" name=""telefono"" required />
        </div>
        <div>
            <label for=""correo"">correo</label>
            <input type=""email"" id=""correo"" name=""correo"" required />
        </div>
        <div>
            <label for=""h");
                WriteLiteral(@"orarioA"">horario de apertura</label>
            <input type=""time"" id=""horarioA"" name=""horarioA"" required />
        </div>
        <div>
            <label for=""horarioC"">horario de cerrado</label>
            <input type=""time"" id=""horarioC"" name=""v"" required />
        </div>
        <div>
            <label for=""capacidad_maxima"">capacidad maxima</label>
            <input type=""number"" id=""capacidad_maxima"" name=""capacidad_maxima"" required />
        </div>
        <div>
            <label for=""porcentaje_permitido"">porcentaje permitido</label>
            <input type=""number"" id=""porcentaje_permitido"" name=""porcentaje_permitido"" required />
        </div>
        <div>
            <input type=""submit"" id=""registrar"" name=""registrar"" value=""Registrar"" />
        </div>
    </div>
");
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