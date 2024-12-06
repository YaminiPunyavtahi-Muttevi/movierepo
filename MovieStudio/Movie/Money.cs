using MovieStudio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Movie
{
    public class Money : IMoney
    {
        public long Amount { get; set; }

        public Money(long amount)
        {
            Amount = amount;
        }

        // Allow modifications through a transaction
        public void ApplyTransaction(IMoneyTransaction transaction, long amount)
        {
            transaction.Execute(this, amount);
        }
    }

}
