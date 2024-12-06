using MovieStudio.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Interfaces
{// Interface for statistics processing
    public interface IStatisticsProcessor
    {
        void Process(Movie.Movie movie, MovieStatistics statistics);
    }

}
