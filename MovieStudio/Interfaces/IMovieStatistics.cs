using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Interfaces
{
    public interface IMovieStatistics
    {
        void IncActorsCount(int actorsCount);
        void IncCameramenCount(int cameramenCount);
        void AddSuperStars(List<string> superstars);
        Dictionary<string, int> GetMovieGenres();
        bool IsEmpty();
    }
}
