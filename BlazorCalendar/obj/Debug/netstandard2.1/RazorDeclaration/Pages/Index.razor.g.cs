#pragma checksum "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11e6ef9af427e3868b7b6f5a71896fc1af6d4c97"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCalendar.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\_Imports.razor"
using BlazorCalendar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\_Imports.razor"
using BlazorCalendar.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\_Imports.razor"
using BlazorCalendar.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\_Imports.razor"
using BlazorCalendar.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\_Imports.razor"
using BlazorCalendar.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\Pages\Index.razor"
 
        private CalendarDay selectedDay = new CalendarDay
        {
            Date = DateTime.Now
        };

        protected override void OnInitialized()
        {
            AddEvent.OnEventAdded += () =>
            {
                StateHasChanged();
            };
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591