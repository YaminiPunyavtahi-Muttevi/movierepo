using MovieStudio.Interfaces;

namespace MovieStudio.Movie
{
    public class MovieProductionSchedule : IProductionSchedule
    {
        public int DaysInProduction { get; set; }

        public void InitProduction(int daysInProduction)
        {
            DaysInProduction = daysInProduction;
        }

        public void Progress()
        {
            DaysInProduction--;
        }

    }
}
