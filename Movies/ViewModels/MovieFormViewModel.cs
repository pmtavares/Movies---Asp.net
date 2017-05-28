using Movies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<MoviesGenre> Genres { get; set; }
        //public Movie Movie { get; set; }
         public int? Id { get; set; }
 
         [Required]
         [StringLength(255)]
         public string Name { get; set; }
 
         [Display(Name = "Genre")]
         [Required]
         public byte? MovieGenreId { get; set; }
 
         [Display(Name = "Release Date")]
         [Required]
         public DateTime? ReleaseDate { get; set; }
 
         [Display(Name = "Number in Stock")]
         [Range(1, 20)]
         [Required]
         public int? NumberInStock { get; set; }

        public MovieFormViewModel()
         {
             Id = 0;
         }
 
         public MovieFormViewModel(Movie movie)
         {
             Id = movie.Id;
             Name = movie.Name;
             ReleaseDate = movie.ReleaseDate;
             NumberInStock = movie.NumberInStock;
             MovieGenreId = movie.MovieGenreId;
         }
        
        public string Title
        {
            get
            {
                //if(Movie != null && Movie.Id != 0)
               // {
                   // return "Edit Movie";
                //}
                //return "New Movie";
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }
    }
}