using MovieStudio.Finance;
using MovieStudio.Interfaces;
using MovieStudio.Movie;
using MovieStudio.Staff;
using MovieStudio.Thirdparty;
using MovieStudio.Thirdparty.Exceptions;
using System;
using System.Linq;

namespace MovieStudio
{
    public class MovieStudio
    {
        private IProductionService _productionService;

        public MovieStudio(IProductionService productionService)
        {
            _productionService = productionService;
        }

        public void LoadMovies()
        {
            string fileName = "movies.yaml"; // Example filename
            var movies = _productionService.LoadMovieDatabase(fileName);  // Calls the mocked method

            if (movies.Any())  // If there are movies
            {
                Console.WriteLine($"{movies.Count} movies loaded.");
            }
            else
            {
                Console.WriteLine("No movies loaded.");
            }
        }

    }

}

