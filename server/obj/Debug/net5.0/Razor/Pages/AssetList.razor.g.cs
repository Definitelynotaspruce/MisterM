#pragma checksum "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\AssetList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dd7837b7bdbee827f3982564c789aa202646e60"
// <auto-generated/>
#pragma warning disable 1591
namespace MisterM.Pages
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
#line 5 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\AssetList.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\AssetList.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\AssetList.razor"
using MisterM.Models.MsMisterM;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/asset-list")]
    public partial class AssetList : MisterM.Pages.AssetListComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H3");
                __builder2.AddAttribute(5, "style", "height: 52px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(7);
                __builder2.AddAttribute(8, "Size", "H1");
                __builder2.AddAttribute(9, "style", "height: 68px");
                __builder2.AddAttribute(10, "Text", "All assets");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n    <div class=\"col-md-12\"></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
