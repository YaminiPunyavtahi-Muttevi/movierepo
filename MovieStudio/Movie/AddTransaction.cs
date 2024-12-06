using MovieStudio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Movie
{
    public class AddTransaction : IMoneyTransaction
    {
        public void Execute(Money money, long amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount to add must be non-negative.");
            money.Amount += amount;
        }
    }
}
