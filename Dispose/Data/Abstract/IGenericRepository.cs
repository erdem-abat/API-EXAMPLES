namespace Dispose.Data.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(int id);
        void Add(T entity);
        void Dispose();
        void SaveChanges();
    }
}
