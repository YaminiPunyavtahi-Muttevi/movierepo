using MovieStudio.Interfaces;
using MovieStudio.Thirdparty;
using MovieStudio.Thirdparty.Exceptions;

namespace MovieStudio.Staff
{
    public class Accountant : StudioEmployee, IAccountant
    {
        public Accountant(string name) : base(name, JobSalary.ACCOUNTANT)
        {

        }

        public void Pay(StudioEmployee person, IFinanceService financeService)
        {
            long salary = person.Salary;
            person.PaySalary(salary);
            if ((financeService.GetBudget() - salary) < 0)
            {
                financeService.InitBudget(0);
                throw new BudgetIsOverException();
            }
            financeService.DecreaseBudget(salary);

        }

       
    }
}
