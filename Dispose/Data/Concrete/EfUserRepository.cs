using Dispose.Data.Abstract;
using Dispose.Models;

namespace Dispose.Data.Concrete
{
    public class EfUserRepository : EfGenericRepository<User>, IUserRepository
    {
        public EfUserRepository(DisposeDbContext context) : base(context)
        {

        }
        public DisposeDbContext disposeContext
        {
            get
            {
                return context as DisposeDbContext;
            }
        }
    }
}
