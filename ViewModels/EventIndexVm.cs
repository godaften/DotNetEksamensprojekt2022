//namespace cbsStudents.Models.Entities;
using cbsStudents.Models.Entities;

namespace cbsStudents.ViewModels;


public class EventIndexVm
{
    public IEnumerable<Event> Events { get; set; }
    public string SearchString { get; set; }
}