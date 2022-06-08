using cbsStudents.Models.Entities;
using cbsStudents.ViewModels;

namespace cbsStudents.Mappers
{
    public class EventMapper
    {

        // MAPPE FRA VM TIL DM
        public Event mapFromViewToEvent(EventCreateEditVm vm)
        {

            // VARIABLER TIL AT MAPPE DATO OG TID OPDELT I VM TIL EN DATETIME I DATABASEMODEL
            var startDateTime = new DateTime(vm.EventStartDate.Year, vm.EventStartDate.Month, vm.EventStartDate.Day,
                vm.EventStartTime.Hour, vm.EventStartTime.Minute, 0);

            var endDateTime = new DateTime(vm.EventEndDate.Year, vm.EventEndDate.Month, vm.EventEndDate.Day,
                vm.EventEndTime.Hour, vm.EventEndTime.Minute, 0);

            return new Event

            {
                EventStartDateTime = startDateTime,
                EventEndDateTime = endDateTime,
                Id = vm.Id,
                Title = vm.Title,
                EventGenre = vm.EventGenre,
                Adress = vm.Adress,
                City = vm.City,
                Country = vm.Country,
                Description = vm.Description,
                ImageName = vm.ImageName,
                ImageFile = vm.ImageFile,
                VenueId = vm.SelectedVenue

            };

        }


        // MAPPE FRA DM TIL VM
        public EventCreateEditVm mapFromEventToView(Event @event)
        {

            var startDate = new DateTime(@event.EventStartDateTime.Year, @event.EventStartDateTime.Month, @event.EventStartDateTime.Day);
            var startTime = new DateTime(1970, 1, 1, @event.EventStartDateTime.Hour, @event.EventStartDateTime.Minute, @event.EventStartDateTime.Second);

            var endDate = new DateTime(@event.EventStartDateTime.Year, @event.EventStartDateTime.Month, @event.EventStartDateTime.Day);
            var endTime = new DateTime(1970, 1, 1, @event.EventStartDateTime.Hour, @event.EventStartDateTime.Minute, @event.EventStartDateTime.Second);

            return new EventCreateEditVm

            {
                EventStartDate = startDate,
                EventStartTime = startTime,
                EventEndDate = endDate,
                EventEndTime = endTime,
                Id = @event.Id,
                Title = @event.Title,
                EventGenre = @event.EventGenre,
                Adress = @event.Adress,
                City = @event.City,
                Country = @event.Country,
                Description = @event.Description,
                ImageName = @event.ImageName,
                ImageFile = @event.ImageFile,
                SelectedVenue = @event.VenueId,

            };
        }
    }
}


