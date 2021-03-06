#pragma checksum "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\Components\Calendar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f08b8551aeb156f5e04b47b4f16de8c134be4c81"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCalendar.Components
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
    public partial class Calendar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Administrator\source\repos\BlazorCalendar\BlazorCalendar\Components\Calendar.razor"
 

    [Parameter]
    public RenderFragment<CalendarDay> DayTemplate { get; set; }

    private int year = 2020;
    private int month = 07;
    private List<CalendarDay> days = new List<CalendarDay>();
    private int rowsCount = 0;

    async Task SelectYear(ChangeEventArgs e)
    {
        year = Convert.ToInt32(e.Value.ToString());
        // Render Calendar
        UpdateCalendar();

        await SyncEventsFromExternalProviderToCalendar();
    }

    async Task SelectMonth(ChangeEventArgs e)
    {
        month = Convert.ToInt32(e.Value.ToString());
        // Render Calendar
        UpdateCalendar();

        await SyncEventsFromExternalProviderToCalendar();
    }

    void UpdateCalendar()
    {
        days = new List<CalendarDay>();

        // Calculate the number of empty days
        var firstDayDate = new DateTime(year, month, 1);
        int weekDayNumber = (int)firstDayDate.DayOfWeek;
        int numberOfEmptyDays = 0;
        if (weekDayNumber == 7)
        {
            numberOfEmptyDays = 0;
        }
        else
        {
            numberOfEmptyDays = weekDayNumber;
        }

        // Add the empty days
        for (int i = 0; i < numberOfEmptyDays; i++)
        {
            days.Add(new CalendarDay
            {
                DayNumber = 0,
                IsEmpty = true
            });
        }

        // Add the month days
        int numberOfDaysInMonth = DateTime.DaysInMonth(year, month);

        for (int i = 0; i < numberOfDaysInMonth; i++)
        {
            days.Add(new CalendarDay
            {
                DayNumber = i + 1,
                IsEmpty = false,
                Date = new DateTime(year, month, i + 1),
                Events = new List<CalendarEvent>()
            });
        }

        // Calculate the number of rows
        int remaning = days.Count % 7;
        if (remaning == 0)
            rowsCount = days.Count / 7;
        else
            rowsCount = Convert.ToInt32(days.Count / 7) + 1;

        Console.WriteLine($"Total Rows: {rowsCount} | Number of Empty Days {numberOfEmptyDays} | Month Days {numberOfDaysInMonth}");
    }

    async Task SyncEventsFromExternalProviderToCalendar()
    {
        //fetch the events for the month
        var events = await eventsProvider.GetEventsInMonthAsync(year, month);

        if (events == null || events.Count() == 0)
            return;

        foreach(var day in days)
        {
            if (day.IsEmpty)
                continue;

            var eventsInDay = events.Where(e => e.StartDate.Date <= day.Date && e.EndDate.Date >= day.Date);
            if (eventsInDay.Any())
            {
                day.Events.AddRange(eventsInDay);
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICalendarEventsProvider eventsProvider { get; set; }
    }
}
#pragma warning restore 1591
