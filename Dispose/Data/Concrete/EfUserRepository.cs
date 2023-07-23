using dispose.Data.Abstract;
using Dispose.Data.Abstract;
using Dispose.Models;
using Microsoft.EntityFrameworkCore;

namespace Dispose.Data.Concrete
{
    public class EfUserRepository : EfGenericRepository<User>, IUserRepository
    {
        public EfUserRepository(DisposeDbContext ctx) : base(ctx)
        {
        }
        public DisposeDbContext userContext
        {
            get
            {
                return context as DisposeDbContext;
            }
        }
    }
}
