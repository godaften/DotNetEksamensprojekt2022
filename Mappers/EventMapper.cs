using cbsStudents.Models.Entities;
using cbsStudents.ViewModels;

namespace cbsStudents.Mappers
{
    public class EventMapper 
    {

        public Event mapFromViewToEvent(EventCreateEditVm vm)
        {

            var startDateTime = new DateTime(vm.EventStartDate.Year, vm.EventStartDate.Month, vm.EventStartDate.Day, 
                vm.EventStartTime.Hour, vm.EventStartTime.Minute, 0);
            return new Event

            {
                Id = vm.Id,
                Title = vm.Title,
                EventStartDateTime = startDateTime,
                EventEndDateTime = vm.EventEndDateTime,
            };

        }

        // Dato og tid adskilt er godt eks på hvor mapper er smart
        public EventCreateEditVm mapFromEventToView(Event @event)
        {
            var startDate = new DateTime(@event.EventStartDateTime.Year, @event.EventStartDateTime.Month, @event.EventStartDateTime.Day);
            var startTime = new DateTime(1970,1,1, @event.EventStartDateTime.Hour, @event.EventStartDateTime.Minute, @event.EventStartDateTime.Second);

            return new EventCreateEditVm
            {
                Id = @event.Id,
                Title = @event.Title,
                EventStartDate = startDate,
                EventStartTime = startTime,                

                EventEndDateTime = @event.EventEndDateTime,





            };
        }
    }
}
    

