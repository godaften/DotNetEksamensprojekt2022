using cbsStudents.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cbsStudents.ViewModels
{
    public class VenueVm
    {
        [Required]
        [Display(Name = "Give your venue a nice one-word name....")]
        public string VenueId { get; set; } // SKAL VÆRE EN STREG PGA....
                                            // SÆTTES TIL AT VÆRE LIGE NAME?

        [Display(Name = "Name of venue")]
        public string Name { get; set; }


        [Display(Name = "Number of seats")]
        public int NumberOfSeats { get; set; }

        // Navigation Properties BRUGES HVIS JEG SKAL LISTE EVENTS UNDER VENUE - ALLE EVENTS DER HØRER TIL EN VENUE
        public List<Event> Events { get; set; }


    }
}
