using cbsStudents.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cbsStudents.ViewModels
{
    public class EventCreateEditVm
    {
        public int Id { get; set; }

        public string Title { get; set; }



        // EVENT START DATO
        [Display(Name = "Event Starts")]
        //[DataType(DataType.DateTime)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime EventStartDate { get; set; }


        // EVENT START TID
        // [DataType(DataType.DateTime)]
        [DataType(DataType.Time)]
        public DateTime EventStartTime { get; set; }



        //// EVENT START 
        //[Display(Name = "Event Starts")]
        //[DataType(DataType.DateTime)]
        //public DateTime EventStartDateTime { get; set; }



        // EVENT SLUT
        [Display(Name = "Event Ends")]
        [DataType(DataType.DateTime)]
        public DateTime EventEndDateTime { get; set; }


        // public string EventType { get; set; }

        [Display(Name = "Online Event?")]
        public bool Online { get; set; }

        public string Adress { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string EventGenre { get; set; }

        public string Description { get; set; }




        [DisplayName("Image Name")]
        public string ImageName { get; set; }


        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile ImageFile { get; set; }




        // Navigation Properties Eventtype SLETTES
        public int EventTypeId { get; set; }
        public EventType EventType { get; set; }



        // Navigation Properties Venue
        public string VenueId { get; set; }
        public Venue Venue { get; set; }



        // Giver ikke mening for databasemodellen, men perfekt mening for vm
        public string chosenVenueId{ get; set; }
        public IEnumerable<SelectListItem> Venues { get; set; }

    }
}
