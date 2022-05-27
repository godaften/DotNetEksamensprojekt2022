using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic.CompilerServices;

// using System.Collections.Generic;

namespace cbsStudents.Models.Entities

{
    public class Event
    {
        public int Id { get; set; }

        // Title
        public string Title { get; set; }

        // Description
        public string Description { get; set; }


        //// Event Start
        //// [Display(Name = "Event Date")]
        //[DataType(DataType.DateTime)]
        ////[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", 
        ////    ApplyFormatInEditMode = true)]
        //public DateTime EventStartDateTime { get; set; }


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