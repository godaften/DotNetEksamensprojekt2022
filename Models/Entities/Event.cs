using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.AspNetCore.Identity;

using System.Collections.Generic;
using System.ComponentModel;


namespace cbsStudents.Models.Entities

{
    public class Event
    {
        public int Id { get; set; }

        public string Title { get; set; }
             

        [DataType(DataType.DateTime)] // SKAL DEN VÆRE HER ELLER I VM? TEST
        public DateTime EventStartDateTime { get; set; }


        [DataType(DataType.DateTime)] // SKAL DEN VÆRE HER ELLER I VM? TEST
        public DateTime EventEndDateTime { get; set; }

        public string EventGenre { get; set; }

        public bool Online { get; set; }

        public string Adress { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Description { get; set; }


        // IMAGE UPLOAD
        public string ImageName { get; set; }

        [NotMapped] // SKAL DEN VÆRE HER ELLER I VM OG I MAPPER?    TEST
        public IFormFile ImageFile { get; set; }


        // Navigation Properties Venue  HVAD OG HVORFOR?
        public string VenueId { get; set; }
        public Venue Venue { get; set; }



        //// Navigation Properties Eventtype SKAL FUCKES!
        //public int? EventTypeId { get; set; }
        //public EventType EventType { get; set; }

    }

}