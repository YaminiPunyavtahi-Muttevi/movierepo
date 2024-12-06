using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStudio.Movie;

namespace MovieStudio.Interfaces
{
    public interface IMovieLoader
    {
        List<Movie.Movie> LoadMovies(string fileName);
    }
}
