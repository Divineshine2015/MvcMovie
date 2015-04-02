﻿using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {

        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name="Release Date")]   
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy}", ApplyFormatInEditMode=true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

       
        

        public String ImagePath
        {
            get
            {
                return "~/img/Compress_2.jpg";
            }
        }
    }
    
}