namespace ImdbLibrary.Data.Repository
{
    public interface IRepositoryFactory
    {
        IRepository<T> CreateRepository<T>();
    }
}