﻿using System.ComponentModel.DataAnnotations;


namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Genre { get; set; }
    }
}
