

using cbsStudents.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace cbsStudents.ViewModels
{
    public class EventCreateVm
    {
        public Event Event { get; set; }
        public IEnumerable<SelectListItem> Venue { get; set; }

    }
}
