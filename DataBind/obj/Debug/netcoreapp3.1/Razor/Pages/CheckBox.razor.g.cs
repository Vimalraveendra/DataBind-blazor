#pragma checksum "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/Pages/CheckBox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c4ec50909107440411e71d7a168922329d4b9ac"
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
    public partial class CheckBox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "class", "bg-secondary text-white");
            __builder.AddContent(2, 
#nullable restore
#line 1 "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/Pages/CheckBox.razor"
                                     AgreeValue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group");
            __builder.AddMarkupContent(6, "\n    ");
            __builder.AddMarkupContent(7, "<label>Agree to terms:</label>\n    ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "checkbox");
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 5 "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/Pages/CheckBox.razor"
                                      Agree

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "/Users/vimalraveendran/Desktop/blazor/DataBind/DataBind/Pages/CheckBox.razor"
       
    public bool AgreeValue { get; set; }

    private void Agree(ChangeEventArgs e)
    {
        AgreeValue = Convert.ToBoolean(e.Value);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
