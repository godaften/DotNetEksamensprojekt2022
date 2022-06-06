using cbsStudents.Models.Entities;

namespace cbsStudents.ViewModels
{
    public class VenueVm
    {
        public string VenueId { get; set; } // SKAL VÆRE EN STREG PGA....

        public string Name { get; set; }

        public int NumberOfSeats { get; set; }

        // Navigation Properties BRUGES HVIS JEG SKAL LISTE EVENTS UNDER VENUE - ALLE EVENTS DER HØRER TIL EN VENUE
        public List<Event> Events { get; set; }


    }
}
