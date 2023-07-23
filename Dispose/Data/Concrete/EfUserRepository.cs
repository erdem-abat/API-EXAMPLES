using dispose.Data.Abstract;
using dispose.Models;
using Microsoft.EntityFrameworkCore;

namespace dispose.Data.Concrete
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
