using cbsStudents.Models.Entities;
using cbsStudents.ViewModels;

namespace cbsStudents.Mappers
{
    public class VenueMapper
    {

        // MAPPE FRA VM TIL DM
        public Venue mapFromVmToDm(VenueVm vm)
        {

            return new Venue // HVORFOR SKAL RETUR VÆRE HER OG IKKE LÆNGERE NEDE?
            {

                VenueId = vm.VenueId,
                Name = vm.Name,
                NumberOfSeats = vm.NumberOfSeats
            };

        }

        // MAPPE FRA DM TIL VM
        public VenueVm mapFromDbToVm(Venue venue)
        {

            return new VenueVm
            {
                VenueId = venue.VenueId,
                Name = venue.Name,
                NumberOfSeats = venue.NumberOfSeats

            };
        }
    }
}


