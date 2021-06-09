using IntroToDependencyInjection.Models;
using System.Collections.Generic;

namespace IntroToDependencyInjection.Services
{
    public interface IMovieService
    {
        void AddMovie(Movie movie);
        void DeleteMovie(Movie movie);
        List<Movie> GetMovies();
    }
}