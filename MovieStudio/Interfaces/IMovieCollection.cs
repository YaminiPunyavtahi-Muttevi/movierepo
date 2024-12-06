using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Interfaces
{
    public interface IMovieCollection
    {
        List<Movie.Movie> GetMovies();
        void AddMovie(Movie.Movie movie);

        void AddToArchive(Movie.Movie movie);
    }
}
