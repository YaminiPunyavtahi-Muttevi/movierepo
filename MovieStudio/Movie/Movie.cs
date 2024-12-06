using MovieStudio.Interfaces;
using MovieStudio.Staff;
using MovieStudio.Staff.Team;
using MovieStudio.Thirdparty;
using System;
using System.Collections.Generic;

namespace MovieStudio.Movie
{
    public class Movie
    {
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public int DaysInProduction { get; set; }

        // Make IsFinished property read-only from outside, with a private setter
        public bool IsFinished { get; private set; }

        private readonly ICrew _crew;

        public List<string> Superstars { get; private set; }

        public Movie(string name, Genre genre, ICrew crew)
        {
            Name = name;
            Genre = genre;
            IsFinished = false;  // Initial state
            DaysInProduction = 0;
            _crew = crew ?? throw new ArgumentNullException(nameof(crew));
            Superstars = _crew.GetSuperstars();
        }

        // Only expose a method to change the state of IsFinished
        public void MarkAsFinished()
        {
            if (!IsFinished)
            {
                IsFinished = true;
                // You can also add additional logic or notifications here
            }
        }

        public void UpdateContent()
        {
            if (!IsFinished) // Logic to avoid changing the content once the movie is finished
            {
                DaysInProduction++;
            }
            else
            {
                throw new InvalidOperationException("Cannot update content after the movie is finished.");
            }
        }

        public Dictionary<string, int> GetCrew()
        {
            return _crew.GetCrew();
        }

        public override string ToString()
        {
            return $"Movie {Name} [{Genre}], status: {(IsFinished ? "finished" : "in production")}, days in production: {DaysInProduction}";
        }
    }


}

