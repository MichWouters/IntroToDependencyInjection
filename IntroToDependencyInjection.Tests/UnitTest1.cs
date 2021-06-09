using IntroToDependencyInjection.Services;
using Moq;
using NUnit.Framework;

namespace IntroToDependencyInjection.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MovieService_WhenCallingGetMovies_3MoviesAreReturned()
        {
            // ARRANGE 
            var service = new MovieService();

            // ACT
            var movies = service.GetMovies();

            // ASSERT
            Assert.AreEqual(3, movies.Count);
        }

        [Test]
        public void FilmService_WhenCallingGetMovies_3MoviesAreReturnedAndGenreIsFilledIn()
        {
            // ARRANGE 
            var mockGenreService = new Mock<IGenreService>();

            mockGenreService.Setup(x => x.GetGenre(It.IsAny<int>())).Returns(Genre.Erotic);

            var service = new FilmService(mockGenreService.Object);

            // ACT
            var movies = service.GetMovies();

            // ASSERT
            Assert.AreEqual(3, movies.Count);

            foreach (var movie in movies)
            {
                Assert.AreNotEqual(Genre.Unknown, movie.Genre);
            }
        }
    }
}