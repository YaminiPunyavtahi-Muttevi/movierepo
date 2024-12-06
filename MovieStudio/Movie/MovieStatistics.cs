using MovieStudio.Interfaces;
using System;
using System.Collections.Generic;

namespace MovieStudio.Movie
{
    public class MovieStatistics : IMovieStatistics
    {
        private IMovieCollection movieCollection;
        public Dictionary<string, int> MovieGenres { get; private set; }
        public int TotalActors { get; private set; }
        public int TotalCameramen { get; private set; }
        public List<string> Superstars { get; private set; }

        public MovieStatistics(IMovieCollection collection)
        {
            movieCollection = collection ?? throw new ArgumentNullException(nameof(collection));
            MovieGenres = new Dictionary<string, int>();
            TotalActors = 0;
            TotalCameramen = 0;
            Superstars = new List<string>();
        }

        public bool IsEmpty()
        {
            return TotalActors + TotalCameramen + Superstars.Count == 0;
        }

        public void IncActorsCount(int actorsCount)
        {
            TotalActors += actorsCount;
        }

        public void IncCameramenCount(int cameramenCount)
        {
            TotalCameramen += cameramenCount;
        }

        public void AddSuperStars(List<string> superstars)
        {
            Superstars.AddRange(superstars);
        }

        public Dictionary<string, int> GetMovieGenres()
        {
            return MovieGenres;
        }
    }

}
