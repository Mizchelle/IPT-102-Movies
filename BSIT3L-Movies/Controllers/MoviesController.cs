using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers
{
    public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;

        public MoviesController()
        {
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
                new MovieViewModel { Id = 1, Name = "BIRD BOX", Rating = "1", Image = "css/images/MOV.1.jpeg", Details = "https://en.wikipedia.org/wiki/Heart_of_Stone_(2023_film)", Description = "sfafarfwfrw" }
            };
        }

        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }

        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);
        }
    }
}
