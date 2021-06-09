using IntroToDependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToDependencyInjection.Services
{
    public class FilmService : IMovieService
    {
        private readonly IGenreService _service;

        public FilmService(IGenreService service)
        {
            _service = service;
        }

        List<Movie> movies = new List<Movie>();
        public List<Movie> GetMovies()
        {
            movies = new List<Movie>
            {
                new Movie{Id= 1, GenreId = 1, Title= "Oh brother, Where art thou?", ReleaseData=  new DateTime(2010,4,20), Director =  "Cristopher Nolan",  Description = "sleepy times"},
                new Movie{Id= 2, GenreId = 4, Title= "Tron", ReleaseData=  new DateTime(2014,11,5), Director =  "Christopher Nolan",  Description = "Trol 2.0"},
                new Movie{Id= 3, GenreId = 5, Title= "Monty Python", ReleaseData=  new DateTime(1998,11,5), Director =  "Coen Brothers",  Description = "The dude abides"},
            };

            foreach (Movie movie in movies)
            {
                movie.Genre = _service.GetGenre(movie.GenreId);
            }

            return movies;
        }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public void DeleteMovie(Movie movie)
        {
            movies.Remove(movie);
        }
    }
}
