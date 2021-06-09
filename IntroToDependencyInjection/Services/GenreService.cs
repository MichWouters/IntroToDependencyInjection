using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToDependencyInjection.Services
{
    public class GenreService : IGenreService
    {
        public Genre GetGenre(int id)
        {
            return (Genre)id;
        }
    }

    public enum Genre
    {
        Unknown = 0,
        Comedy = 1,
        Horror = 2,
        Thriller = 3,
        Drama = 4,
        Erotic = 5,
        ScienceFiction = 6,
    }
}
