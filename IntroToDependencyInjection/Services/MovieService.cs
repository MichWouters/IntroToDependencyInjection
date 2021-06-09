using IntroToDependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToDependencyInjection.Services
{
    public class MovieService : IMovieService
    {
        List<Movie> movies;

        public MovieService()
        {

        }

        public List<Movie> GetMovies()
        {
            movies = new List<Movie>
            {
                new Movie{Id= 1, Title= "Inception", ReleaseData=  new DateTime(2010,4,20), Director =  "Cristopher Nolan",  Description = "sleepy times"},
                new Movie{Id= 2, Title= "Interstellar", ReleaseData=  new DateTime(2014,11,5), Director =  "Cristopher Nolan",  Description = "Spaaaaaaaace travel"},
                new Movie{Id= 3, Title= "The big lebowski", ReleaseData=  new DateTime(1998,11,5), Director =  "Coehn Brothers",  Description = "The dude abides"},
            };

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
