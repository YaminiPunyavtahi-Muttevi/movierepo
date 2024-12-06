using MovieStudio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Movie
{
    public class MovieCollection : IMovieCollection
    {
        private List<Movie> movies;

        public MovieCollection()
        {
            movies = new List<Movie>();
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public void AddToArchive(Movie movie)
        {
            // Add the movie to the archive
            movies.Add(movie);
        }

    }

}
