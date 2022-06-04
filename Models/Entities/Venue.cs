using System.ComponentModel.DataAnnotations;

namespace cbsStudents.Models.Entities
{
    public class Venue  
    {
        //public int Id { get; set; }

        [Key]
        public string VenueId { get; set; }

        public string Name { get; set; }

        public int NumberOfSeats { get; set; }

        // Navigation Properties
        public List<Event> Events { get; set; }
    }
}


