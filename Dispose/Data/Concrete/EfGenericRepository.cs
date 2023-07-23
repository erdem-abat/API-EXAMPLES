using Dispose.Data.Abstract;
using Dispose.Models;

namespace Dispose.Data.Concrete
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DisposeDbContext context;
        public EfGenericRepository(DisposeDbContext ctx)
        {
            context = ctx;
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
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
