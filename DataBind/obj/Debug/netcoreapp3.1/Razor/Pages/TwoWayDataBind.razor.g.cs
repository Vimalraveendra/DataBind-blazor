#pragma checksum "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/Pages/TwoWayDataBind.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08050c49554a8d062f64c7514009d2271bec6cf1"
// <auto-generated/>
#pragma warning disable 1591
namespace DataBind.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/_Imports.razor"
using DataBind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/_Imports.razor"
using DataBind.Shared;

#line default
#line hidden
#nullable disable
    public partial class TwoWayDataBind : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<label>Frameworks:</label>\n    ");
            __builder.OpenElement(4, "select");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 3 "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/Pages/TwoWayDataBind.razor"
                                        Frameworks

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Frameworks = __value, Frameworks));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(8, "\n        ");
            __builder.OpenElement(9, "option");
            __builder.AddAttribute(10, "value", "Select");
            __builder.AddContent(11, "Select");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "option");
            __builder.AddContent(14, "Blazor");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n        ");
            __builder.OpenElement(16, "option");
            __builder.AddContent(17, "ASP.NET Core");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n        ");
            __builder.OpenElement(19, "option");
            __builder.AddContent(20, "React");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "p-2 mb-2");
            __builder.AddContent(26, "Framework\'s Value: ");
            __builder.AddContent(27, 
#nullable restore
#line 10 "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/Pages/TwoWayDataBind.razor"
                                          Frameworks

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/Pages/TwoWayDataBind.razor"
       
    private string Frameworks { get; set; } = "ASP.NET Core";
    //private void UpdateFramework(ChangeEventArgs e)
    //{
    //    Frameworks = e.Value as string;
    //}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
