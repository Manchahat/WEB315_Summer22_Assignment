#pragma checksum "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/Pages/Photographylists.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "074555b602c15d1855c4b79ccd6f42949c37ce99"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPhotographyApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/_Imports.razor"
using BlazorPhotographyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/_Imports.razor"
using BlazorPhotographyApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Photographylists")]
    public partial class Photographylists : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<p> Displaying array list on the page  </p>\n");
            __builder.AddMarkupContent(1, "<button @bind photography> Click me </button>");
#nullable restore
#line 5 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/Pages/Photographylists.razor"
 foreach(var types in PhotographyType){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, 
#nullable restore
#line 6 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/Pages/Photographylists.razor"
         types

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/Pages/Photographylists.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "number");
            __builder.AddAttribute(6, "value", "5");
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/Pages/Photographylists.razor"
                                              p => newPhotos(Int32.Parse(p.Value.ToString()))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "<button>Input Values</button>");
#nullable restore
#line 9 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/Pages/Photographylists.razor"
 for(int a = 0 ; a < photos ; a++){
    if (a >= 0 && a < 5 ) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, 
#nullable restore
#line 11 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/Pages/Photographylists.razor"
             PhotographyType[a]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/Pages/Photographylists.razor"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "/Users/admin/Documents/GitHub/WEB315_Summer22_Assignment/BlazorPhotographyApp/Pages/Photographylists.razor"
      
    string[] PhotographyType = new string[] {
        "Landscape","Potrait","Car","Sunshine","Snow"
        };
    private int photos = 0 ;
    private void newPhotos(int newPhoto){
        photos = newPhoto ;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
