using MovieStudio.Interfaces;
using MovieStudio.Staff;
using MovieStudio.Thirdparty;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using YamlDotNet.Serialization;

namespace MovieStudio.Movie
{
    public class ProductionService : IProductionService
    {
        private IMovieLoader _movieLoader;
        public ProductionService(IMovieLoader movieLoader)
        {

            _movieLoader = movieLoader;
        }
    

        public bool CanProduceMovie(int daysInProduction, int staffCount, long availableBudget)
        {
            return availableBudget > daysInProduction * staffCount * 1000;
        }

      
        public List<Movie> LoadMovieDatabase(string fileName)
        {
            return _movieLoader.LoadMovies(fileName);
        }
    }


}

