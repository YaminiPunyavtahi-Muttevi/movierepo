using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Interfaces
{
    public interface IProductionService
    {   
        bool CanProduceMovie(int daysInProduction, int staffCount, long availableBudget);
        List<Movie.Movie> LoadMovieDatabase(string fileName);
    }
}
