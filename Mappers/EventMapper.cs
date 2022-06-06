﻿using cbsStudents.Models.Entities;
using cbsStudents.ViewModels;

namespace cbsStudents.Mappers
{
    public class EventMapper
    {

        // MAPPE FRA VM TIL DM
        public Event mapFromViewToEvent(EventCreateEditVm vm)
        {

            // Dato og tid adskilt er godt eks på hvor mapper er smart
            // VARS TIL AT MAPPE DATO OG TID OPDELT I VM TIL EN DATETIME I DATABASEMODEL
            var startDateTime = new DateTime(vm.EventStartDate.Year, vm.EventStartDate.Month, vm.EventStartDate.Day,
                vm.EventStartTime.Hour, vm.EventStartTime.Minute, 0);

            var endDateTime = new DateTime(vm.EventEndDate.Year, vm.EventEndDate.Month, vm.EventEndDate.Day,
              vm.EventEndTime.Hour, vm.EventEndTime.Minute, 0);

            return new Event // HVORFOR SKAL RETUR VÆRE HER OG IKKE LÆNGERE NEDE?
            {
                // MAPPER DATO OG TID OPDELT I VM TIL EN DATETIME I DATABASEMODEL
                EventStartDateTime = startDateTime,
                EventEndDateTime = endDateTime,

                Id = vm.Id,
                Title = vm.Title,
                EventGenre = vm.EventGenre,
                Online = vm.Online,
                Adress = vm.Adress,
                City = vm.City,
                Country = vm.Country,
                Description = vm.Description,
                ImageName = vm.ImageName,
                ImageFile = vm.ImageFile,
                VenueId = vm.VenueId,
                Venue = vm.Venue,   // NOGET SÆRLIGT MED VENUE?

            };

        }


        // MAPPE FRA DM TIL VM
        public EventCreateEditVm mapFromEventToView(Event @event)
        {

            // VAR TIL AT MAPPE DATETIME FRA DATABASEMODEL TIL DATO OG TID OPDELT I VM
            var startDate = new DateTime(@event.EventStartDateTime.Year, @event.EventStartDateTime.Month, @event.EventStartDateTime.Day);
            var startTime = new DateTime(1970, 1, 1, @event.EventStartDateTime.Hour, @event.EventStartDateTime.Minute, @event.EventStartDateTime.Second);

            var endDate = new DateTime(@event.EventStartDateTime.Year, @event.EventStartDateTime.Month, @event.EventStartDateTime.Day);
            var endTime = new DateTime(1970, 1, 1, @event.EventStartDateTime.Hour, @event.EventStartDateTime.Minute, @event.EventStartDateTime.Second);

            return new EventCreateEditVm
            {

                // MAPPER DATETIME FRA DATABASEMODEL TIL DATO OG TID OPDELT I VM
                EventStartDate = startDate,
                EventStartTime = startTime,
                EventEndDate = endDate,
                EventEndTime = endTime,

                Id = @event.Id,
                Title = @event.Title,
                EventGenre = @event.EventGenre,
                Online = @event.Online,
                Adress = @event.Adress,
                City = @event.City,
                Country = @event.Country,
                Description = @event.Description,
                ImageName = @event.ImageName,
                ImageFile = @event.ImageFile,
                VenueId = @event.VenueId,
                Venue = @event.Venue,   // NOGET SÆRLIGT MED VENUE

            };
        }
    }
}

