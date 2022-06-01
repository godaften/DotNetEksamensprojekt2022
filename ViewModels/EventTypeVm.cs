using cbsStudents.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace cbsStudents.ViewModels
{
    public class EventTypeVm
    {
        public List<Event>? Events { get; set; }
        public SelectList? Types { get; set; }
        public string? EventType { get; set; }
        public string? SearchString { get; set; }
    }
}

// https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/search?view=aspnetcore-6.0