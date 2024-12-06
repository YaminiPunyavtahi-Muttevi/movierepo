using MovieStudio.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Interfaces
{
    public interface IMoneyTransaction
    {
        void Execute(Money money, long amount);
    }

}
