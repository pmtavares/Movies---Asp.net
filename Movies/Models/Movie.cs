using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Release date")]
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in stock")]
        public int NumberInStock { get; set; }

        public DateTime? DataAdd { get; set; }

        [Display(Name = "Genre")]
        public MoviesGenre MovieGenre { get; set; }

        public byte MovieGenreId { get; set; }

        
    }
}