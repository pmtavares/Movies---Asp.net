using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.Dtos
{
    public class MovieDto
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Release date")]

        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in stock")]
        [Required]
        [Range(1, 20, ErrorMessage = "The number must be between 1 and 20")]
        public int NumberInStock { get; set; }

        //public DateTime? DataAdd { get; set; }

        [Display(Name = "Genre")]
         
        [Required]
        public byte MovieGenreId { get; set; }
    }
}