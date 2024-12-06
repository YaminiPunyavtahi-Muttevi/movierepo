using Xunit;
using MovieStudio;
using MovieStudio.Staff.Team;
using MovieStudio.Staff;
using MovieStudio.Movie;
using MovieStudio.Thirdparty;
using MovieStudio.Thirdparty.Exceptions;
using MovieStudio.Interfaces;
using Moq;
using System.Collections.Generic;
using System;

namespace MovieStudioTest
{
  
    public class MovieStudioTests
    {
        private readonly Mock<IProductionService> _mockProductionService;
        private readonly MovieStudio.MovieStudio _movieStudio;

        public MovieStudioTests()
        {
            _mockProductionService = new Mock<IProductionService>();
            _movieStudio = new MovieStudio.MovieStudio(_mockProductionService.Object);
        }
        [Fact]
        public void LoadMovies_WithMoviesInDatabase_PrintsNumberOfMovies()
        {
            // Example lists of actors and cameramen
            List<Actor> actors = [new Actor("actor1",true), new Actor("actor2",false)];
            List<CameraMan> cameraMen = [new CameraMan("cameraman1"), new CameraMan("cameraman2")];

            StudioStaff studioStaffOne = new StudioStaff(actors,cameraMen);
            StudioStaff studioStaffTwo = new StudioStaff(actors, cameraMen);

            var movies = new List<Movie>
    {
        new Movie("Movie 1", Genre.DRAMA,studioStaffOne),// Make sure to pass all required parameters
        new Movie("Movie 2", Genre.COMEDY,studioStaffTwo)  // Make sure to pass all required parameters
    };

            // Set up the mock to return the list of movies when LoadMovieDatabase is called
            _mockProductionService.Setup(service => service.LoadMovieDatabase(It.IsAny<string>())).Returns(movies);

            // Capture console output
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);

                // Act: Call LoadMovies method
                _movieStudio.LoadMovies();

                // Assert: Check that the output contains the expected message
                var output = sw.ToString().Trim();
                Assert.Contains("2 movies loaded.", output); // Assert that the output contains the correct number of movies

                // Debugging output to confirm the behavior
                Console.WriteLine($"Output captured: {output}");
            }
        }



        [Fact]
        public void LoadMovies_WhenNoMoviesInDatabase_PrintsNoMoviesLoaded()
        {
            // Arrange
            var movies = new List<Movie>();
            _mockProductionService.Setup(service => service.LoadMovieDatabase(It.IsAny<string>())).Returns(movies);

            // Capture console output
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);

                // Act
                _movieStudio.LoadMovies();

                // Assert
                var output = sw.ToString().Trim();
                Assert.Contains("No movies loaded.", output);
            }
        }

        [Fact]
        public void LoadMovies_CallsLoadMovieDatabaseWithCorrectFileName()
        {
            // Arrange
            var movies = new List<Movie>();
          
            _mockProductionService.Setup(service => service.LoadMovieDatabase("movies.yaml")).Returns(movies);

            // Act
            _movieStudio.LoadMovies();

            // Assert
            _mockProductionService.Verify(service => service.LoadMovieDatabase("movies.yaml"), Times.Once);
        }
    }

}
