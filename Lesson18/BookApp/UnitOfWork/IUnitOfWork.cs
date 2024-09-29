namespace BookApp.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CreateTransaction();
        Task Commit();
        Task Rollback();
        Task SaveChange();
    }
}
