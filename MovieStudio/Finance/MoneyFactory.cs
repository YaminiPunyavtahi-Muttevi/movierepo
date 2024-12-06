using MovieStudio.Interfaces;
using MovieStudio.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Finance
{
    public class MoneyFactory : IMoneyFactory
    {
        public IMoney Create(long amount)
        {
            return new Money(amount);
        }
    }
}
