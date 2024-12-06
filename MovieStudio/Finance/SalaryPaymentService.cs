using MovieStudio.Interfaces;
using MovieStudio.Thirdparty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStudio.Finance
{
    public class SalaryPaymentService
    {
  
      private readonly IAccountantFinder _accountantFinder;

        public SalaryPaymentService(IAccountantFinder accountantFinder)
        {
            _accountantFinder = accountantFinder;
        }

        public void PaySalaries(IStaffingService staffingService, IFinanceService financeService)
        {
            var accountant = _accountantFinder.FindAccountant(staffingService);

            foreach (StudioEmployee person in staffingService.GetStaff())
            {
                accountant.Pay(person, financeService);
            }
        }
    }
}
