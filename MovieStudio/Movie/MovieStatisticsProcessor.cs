using MovieStudio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Movie
{
    public class MovieStatisticsProcessor : IStatisticsProcessor
    {
        public void Process(Movie movie, MovieStatistics statistics)
        {
            var crew = movie.GetCrew();

            // Update movie statistics
            statistics.IncActorsCount(crew["Actor"]);
            statistics.IncCameramenCount(crew["Cameraman"]);
            statistics.AddSuperStars(movie.Superstars);

            string currentMovieGenre = movie.Genre.ToString();
            if (!statistics.MovieGenres.ContainsKey(currentMovieGenre))
            {
                statistics.MovieGenres[currentMovieGenre] = 0;
            }
            statistics.MovieGenres[currentMovieGenre]++;
        }
    }

}
