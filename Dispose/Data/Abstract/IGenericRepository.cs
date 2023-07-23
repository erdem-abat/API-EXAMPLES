namespace Dispose.Data.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(int id);
        void Add(T data);
        void SaveChanges();
        
    }
}
