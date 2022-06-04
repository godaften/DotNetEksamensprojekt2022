namespace cbsStudents.Models.Entities
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation Properties
        public List<Event> Events { get; set; }
    }
}


