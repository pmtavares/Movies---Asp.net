using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies.ViewModels
{
    public class RandomMovieViewModel
    {

        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}