using MovieStudio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Movie
{
    public class SubstractTransaction : IMoneyTransaction
        
    {

           public void Execute(Money money, long amount)
            {
                if (amount < 0)
                    throw new ArgumentException("Amount to subtract must be non-negative.");
                if (money.Amount < amount)
                    throw new InvalidOperationException("Insufficient funds.");
                money.Amount -= amount;
            }
    }

}

