using IntroToDependencyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToDependencyInjection.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseData { get; set; }

        public string Director { get; set; }

        public string Description { get; set; }
    }
}
