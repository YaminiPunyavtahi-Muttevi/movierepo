using MovieStudio.Interfaces;
using MovieStudio.Movie;
using MovieStudio.Thirdparty;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStudio.Staff.Team
{
    public class StudioStaff : ICrew
    {
        public List<Actor> Actors { get; set; }
        public List<CameraMan> Cameramen { get; set; }

        public StudioStaff(List<Actor> actors, List<CameraMan> cameramen)
        {
            Actors = actors;
            Cameramen = cameramen;
        }

        // Implement the ICrew interface methods
        public Dictionary<string, int> GetCrew()
        {
            var crew = new Dictionary<string, int>
        {
            { "Actor", Actors.Count },
            { "Cameraman", Cameramen.Count }
        };
            return crew;
        }

        public List<string> GetSuperstars()
        {
            var superstars = Actors.Where(a => a.IsSuperStar()).Select(a => a.Name).ToList();
            return superstars;
        }


      
    }

}
