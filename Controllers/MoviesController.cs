using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModel;

namespace Vidly.Models
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Movie()
        {
            var movies = new List<MovieModel>
            {
                new MovieModel { movieName = "Shrek", movieId = 1},
                new MovieModel { movieName = "Wall-e", movieId = 2}
            };

            var movieModel = new MoviesViewModel
            {
                Movie = movies
            };

            return View(movieModel);
        }
    }
}