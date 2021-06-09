using IntroToDependencyInjection.Models;
using IntroToDependencyInjection.Services;
using IntroToDependencyInjection.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToDependencyInjection.Controllers
{
    public class MovieController: Controller
    {
        private readonly IMovieService _service;

        public MovieController(IMovieService movieService)
        {
            _service = movieService;
        }


        public IActionResult Index()
        {
            MovieIndexViewModel vm = new MovieIndexViewModel();
            vm.Movies = _service.GetMovies();

            return View(vm);
        }

        public IActionResult Create()
        {
            var movie = new Movie
            {
                Id = 4,
                Title = "Terminator",
                GenreId = 1,
                Director = "James Cameron",
                Description = "pew pew"
            };

            _service.AddMovie(movie);

            return View();
        }

        public IActionResult Delete()
        {
            var movie = new Movie { Id = 1 };
            _service.DeleteMovie(movie);

            return View();
        }
    }
}
