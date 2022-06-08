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
        public string VenueId { get; set; } 
                                            

        [Display(Name = "Name of venue")]
        public string Name { get; set; }


        [Display(Name = "Number of seats")]
        public int NumberOfSeats { get; set; }

       
        //public List<Event> Events { get; set; }


    }
}
