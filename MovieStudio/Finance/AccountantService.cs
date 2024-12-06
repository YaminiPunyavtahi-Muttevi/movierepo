using MovieStudio.Interfaces;
using MovieStudio.Staff;
using MovieStudio.Thirdparty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Finance
{
    public class AccountantService
    {
        private readonly IAccountantFinder _accountantFinder;

        // Depend on the abstraction, not the concrete class
        public AccountantService(IAccountantFinder accountantFinder)
        {
            _accountantFinder = accountantFinder;
        }

        public Accountant GetAccountant(IStaffingService staffingService)
        {
            return _accountantFinder.FindAccountant(staffingService);
        }
    }

}


