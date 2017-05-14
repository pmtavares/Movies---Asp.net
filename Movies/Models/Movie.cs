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

        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        public int NumberInStock { get; set; }

        public DateTime? DataAdd { get; set; }

        public MoviesGenre MovieGenre { get; set; }

        public byte MovieGenreId { get; set; }

        
    }
}