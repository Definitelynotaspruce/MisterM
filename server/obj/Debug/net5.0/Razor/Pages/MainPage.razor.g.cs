#pragma checksum "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\MainPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccee2efec11e1d51f348f2b230fd9c02cb6c7490"
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
#line 6 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\MainPage.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\MainPage.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\MainPage.razor"
using MisterM.Models.MsMisterM;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/main-page")]
    public partial class MainPage : MisterM.Pages.MainPageComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(3);
                __builder2.AddAttribute(4, "style", "height: 42px; width: 229.40625px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(6);
                __builder2.AddAttribute(7, "Size", "H1");
                __builder2.AddAttribute(8, "style", "height: 76px");
                __builder2.AddAttribute(9, "Text", "Mister Monitor");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(11);
                __builder2.AddAttribute(12, "style", "border-radius: 10px; font-size: 21px; height: 55px; text-align: right; width: 860.390625px");
                __builder2.AddAttribute(13, "Text", "Welcome to the best computer monitoring software solution! Get real-time updates and enjoy! ");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "row");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-lg-6 col-xl-2   col-md-2 col-sm-2 col-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(19);
                __builder2.AddAttribute(20, "style", "background-color: #e6ecef; margin-bottom: 16px");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "row");
                    __builder3.OpenElement(24, "div");
                    __builder3.AddAttribute(25, "class", "col-xl-4  col-lg-4");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenIcon>(26);
                    __builder3.AddAttribute(27, "Icon", "devices");
                    __builder3.AddAttribute(28, "style", "height: 64px; width: 64px");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(29, "\n              ");
                    __builder3.OpenElement(30, "div");
                    __builder3.AddAttribute(31, "class", "col-6");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHeading>(32);
                    __builder3.AddAttribute(33, "Size", "H4");
                    __builder3.AddAttribute(34, "style", "margin-bottom: 0px; text-align: center");
                    __builder3.AddAttribute(35, "Text", "Total devices");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHeading>(37);
                    __builder3.AddAttribute(38, "Size", "H4");
                    __builder3.AddAttribute(39, "style", "border-radius: ; color: #cb6992; font-weight: bold; margin-bottom: 0px; text-align: center");
                    __builder3.AddAttribute(40, "Text", "0");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\n      ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-lg-6 col-xl-2   col-md-2 col-sm-2 col-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(44);
                __builder2.AddAttribute(45, "style", "background-color: #e6ecef; margin-bottom: 16px");
                __builder2.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "row");
                    __builder3.OpenElement(49, "div");
                    __builder3.AddAttribute(50, "class", "col-xl-4  col-lg-4");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenIcon>(51);
                    __builder3.AddAttribute(52, "Icon", "track_changes");
                    __builder3.AddAttribute(53, "style", "height: 64px; width: 64px");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\n              ");
                    __builder3.OpenElement(55, "div");
                    __builder3.AddAttribute(56, "class", "col-6");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHeading>(57);
                    __builder3.AddAttribute(58, "Size", "H4");
                    __builder3.AddAttribute(59, "style", "margin-bottom: 0px; text-align: center");
                    __builder3.AddAttribute(60, "Text", "Active now");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHeading>(62);
                    __builder3.AddAttribute(63, "Size", "H4");
                    __builder3.AddAttribute(64, "style", "border-radius: ; color: #cb6992; font-weight: bold; margin-bottom: 0px; text-align: center");
                    __builder3.AddAttribute(65, "Text", "0");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\n      ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "col-lg-6 col-xl-2   col-md-2 col-sm-2 col-2");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(69);
                __builder2.AddAttribute(70, "style", "background-color: #e6ecef; margin-bottom: 16px");
                __builder2.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "class", "row");
                    __builder3.OpenElement(74, "div");
                    __builder3.AddAttribute(75, "class", "col-xl-4  col-lg-4");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenIcon>(76);
                    __builder3.AddAttribute(77, "Icon", "ac_unit");
                    __builder3.AddAttribute(78, "style", "height: 64px; width: 64px");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(79, "\n              ");
                    __builder3.OpenElement(80, "div");
                    __builder3.AddAttribute(81, "class", "col-6");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHeading>(82);
                    __builder3.AddAttribute(83, "Size", "H4");
                    __builder3.AddAttribute(84, "style", "margin-bottom: 0px; text-align: center");
                    __builder3.AddAttribute(85, "Text", "Average temperature");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(86, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenHeading>(87);
                    __builder3.AddAttribute(88, "Size", "H4");
                    __builder3.AddAttribute(89, "style", "border-radius: ; color: #cb6992; font-weight: bold; margin-bottom: 0px; text-align: center");
                    __builder3.AddAttribute(90, "Text", "0");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenFieldset>(92);
                __builder2.AddAttribute(93, "AllowCollapse", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 73 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\MainPage.razor"
                                   false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "style", "height: 296.140625px; margin-left: 10px; width: 50%");
                __builder2.AddAttribute(95, "Text", "Last active devices");
                __builder2.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGrid<MisterM.Models.MsMisterM.Computer>>(97);
                    __builder3.AddAttribute(98, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 75 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\MainPage.razor"
                                                         true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(99, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 75 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\MainPage.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(100, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 75 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\MainPage.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(101, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<MisterM.Models.MsMisterM.Computer>>(
#nullable restore
#line 75 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\MainPage.razor"
                                                                                                             getComputersResult

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(102, "PageSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 75 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\MainPage.razor"
                                                                                                                                                                                     10

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(103, "style", "height: 231px");
                    __builder3.AddAttribute(104, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<MisterM.Models.MsMisterM.Computer>>(105);
                        __builder4.AddAttribute(106, "Property", "mac");
                        __builder4.AddAttribute(107, "Title", "Mac");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(108, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<MisterM.Models.MsMisterM.Computer>>(109);
                        __builder4.AddAttribute(110, "Property", "name");
                        __builder4.AddAttribute(111, "Title", "Name");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(112, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<MisterM.Models.MsMisterM.Computer>>(113);
                        __builder4.AddAttribute(114, "Property", "model");
                        __builder4.AddAttribute(115, "Title", "Model");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(116, "\n            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<MisterM.Models.MsMisterM.Computer>>(117);
                        __builder4.AddAttribute(118, "Property", "temperature");
                        __builder4.AddAttribute(119, "Title", "Temperature");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddComponentReferenceCapture(120, (__value) => {
#nullable restore
#line 75 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\MainPage.razor"
                              datagrid0 = (Radzen.Blazor.RadzenDataGrid<MisterM.Models.MsMisterM.Computer>)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtml>(122);
                __builder2.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MisterM.Shared.CustomOnClick>(124);
                    __builder3.AddAttribute(125, "Title", "Test");
                    __builder3.AddAttribute(126, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "C:\Users\jkosiakaite\OneDrive - 1ClickFactory\UNI\.net\MisterM\server\Pages\MainPage.razor"
                                          CustomComponentClick

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
