using MovieStudio.Interfaces;
using MovieStudio.Movie;
using MovieStudio.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Finance
{
    public class AccountantFinder : IAccountantFinder
    {
        private readonly ErrorHandler _errorHandler;
        public Accountant FindAccountant(IStaffingService staffingService)
        {
            var accountant = staffingService.GetStaff().OfType<Accountant>().FirstOrDefault();
            if (accountant == null)
            {
                _errorHandler.HandleAccountantNotFound();
            }
            return accountant;
        }
    }

}
