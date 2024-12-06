namespace MovieStudio.Interfaces
{
    public interface IMovieFinanceService
    {
        void InitBudget(long initialSum);

      

        long GetBudget();

    }
}