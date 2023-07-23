using dispose.Data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace dispose.Data.Concrete
{
    public class EfGenericRepository <T> :IDisposable, IGenericRepository<T> where T : class
    {
        protected readonly DbContext context;
        public EfGenericRepository(DbContext ctx)
        {
            context = ctx;
        }

        public void Add(T data)
        {
            context.Add<T>(data);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
