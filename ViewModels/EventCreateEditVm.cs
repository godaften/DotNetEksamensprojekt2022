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


        // SelectListeItem for dropdown
        public IEnumerable<SelectListItem> Venues { get; set; }
        public string SelectedVenue { get; set; }

    }

}
