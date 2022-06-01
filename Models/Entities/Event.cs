using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.AspNetCore.Identity;

using System.Collections.Generic;

namespace cbsStudents.Models.Entities

{
    public class Event
    {
        //public Event(int id, string title)
        //{
        //    Id = id;
        //    Title = title;
        //}

        public int Id { get; set; }

        public string Title { get; set; }

     

        [Display(Name = "Event Starts")]
        [DataType(DataType.DateTime)]
        public DateTime EventStartDateTime { get; set; }


        [Display(Name = "Event Ends")]
        [DataType(DataType.DateTime)]
        public DateTime EventEndDateTime { get; set; }

        // public string EventType { get; set; }

        [Display(Name = "Online Event?")]
        public bool Online { get; set; }

        public string Adress { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string EventType { get; set; }

        public string Description { get; set; }




        //[Display(Name = "Event Startdate")]
        //[DataType(DataType.Date)]
        //public DateTime Date { get; set; }

        //[Display(Name = "Event Starttime")]
        //[DataType(DataType.Time)]
        //public DateTime Time { get; set; }


        //// Price
        //// [Range(1, 100)]
        //[DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18, 2)")]
        //public decimal Price { get; set; }

    }

}
//// VIEWMODEL LAVE ? 
//    public class EventViewModel
//    {
//        public List<Event>? Events { get; set; }
//        public SelectList? Titles { get; set; }
//        public string? MovieGenre { get; set; }
//        public string? SearchString { get; set; }
//    }