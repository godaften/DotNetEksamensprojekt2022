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

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        // EVENT START DATO
        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        public DateTime EventStartDate { get; set; }

        // EVENT START TID
        [Display(Name = "Event Time")]
        [DataType(DataType.Time)]
        public DateTime EventStartTime { get; set; }

        // EVENT END DATO
        [Display(Name = "Event Ends")]
        [DataType(DataType.Date)]
        public DateTime EventEndDate { get; set; }

        // EVENT END TID
        [DataType(DataType.Time)]
        public DateTime EventEndTime { get; set; }


        [Display(Name = "Online Event?")]
        public bool Online { get; set; }

        public string Adress { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        [DisplayName("Type of event")]
        public string EventGenre { get; set; }

        public string Description { get; set; }


        // IMAGE UPLOAD
        [DisplayName("Image Name")]
        public string ImageName { get; set; }

        //[NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile ImageFile { get; set; }



        // SKAL DE BEGGE BRUGES?
        // Navigation Properties Venue
        public string VenueId { get; set; }
        public Venue Venue { get; set; }



        // HVORDAN FORKLARER MAN DET?
        // Giver ikke mening for databasemodellen, men perfekt mening for vm
        // SelectListeItem type list creating Dropdown 
        public IEnumerable<SelectListItem> Venues { get; set; }

        // for first dropdown selected value
        public string SelectedVenue { get; set; }

    }


}
