namespace cbsStudents.Models.Entities
{
    public class EventType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation Properties
        public List<Event> Events { get; set; }
    }
}
