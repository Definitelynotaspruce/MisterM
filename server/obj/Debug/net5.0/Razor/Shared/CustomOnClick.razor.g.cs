#pragma checksum "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Shared\CustomOnClick.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad17daa26c303228ca36632f3068e20ea7f56e4a"
// <auto-generated/>
#pragma warning disable 1591
namespace MisterM.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\_Imports.razor"
using MisterM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
    public partial class CustomOnClick : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "type", "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Shared\CustomOnClick.razor"
                                  (args) => OnClick(args)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 2 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Shared\CustomOnClick.razor"
     if (!string.IsNullOrEmpty(Title))
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "span");
            __builder.AddAttribute(4, "class", "ui-button-text");
            __builder.AddContent(5, 
#nullable restore
#line 4 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Shared\CustomOnClick.razor"
                                      Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 5 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Shared\CustomOnClick.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Shared\CustomOnClick.razor"
       
    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> Click { get; set; }

    void OnClick(MouseEventArgs args)
    {
        Click.InvokeAsync(args);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591