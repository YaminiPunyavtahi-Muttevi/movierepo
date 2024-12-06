using MovieStudio.Interfaces;
using MovieStudio.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Movie
{
    public class MovieCrew : ICrew
    {
        private readonly List<Actor> _actors;
        private readonly List<CameraMan> _cameramen;

        public MovieCrew(List<Actor> actors, List<CameraMan> cameramen)
        {
            _actors = actors ?? throw new ArgumentNullException(nameof(actors));
            _cameramen = cameramen ?? throw new ArgumentNullException(nameof(cameramen));
        }

        public Dictionary<string, int> GetCrew()
        {
            var crew = new Dictionary<string, int>
        {
            { "Actor", _actors.Count },
            { "Cameraman", _cameramen.Count }
        };
            return crew;
        }

        public List<string> GetSuperstars()
        {
            var superstars = _actors.Where(a => a.IsSuperStar()).Select(a => a.Name).ToList();
            return superstars;
        }
    }

}
