using MovieStudio.Interfaces;
using MovieStudio.Movie;
using MovieStudio.Staff;
using MovieStudio.Thirdparty;
using System;
using System.Linq;

namespace MovieStudio.Finance
{
    public class MovieFinanceService : IMovieFinanceService
    {
        private IMoney _movieBudget;
        private readonly IMoneyFactory _moneyFactory;

        // Constructor dependency injection of IMoney and IMoneyFactory
        public MovieFinanceService(IMoneyFactory moneyFactory, IMoney movieBudget)
        {
            _moneyFactory = moneyFactory;
            _movieBudget = movieBudget;
        }


        public void InitBudget(long initialSum)
        {
            // Initialize using the factory to create an IMoney object
            _movieBudget = _moneyFactory.Create(initialSum);
        }

        public long GetBudget()
        {
            return _movieBudget.Amount;
        }
    }

}
