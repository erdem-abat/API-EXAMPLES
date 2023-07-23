using Dispose.Models;
using Microsoft.EntityFrameworkCore;

namespace Dispose.Data
{
    public class DisposeDbContext : DbContext
    {
        public DisposeDbContext(DbContextOptions<DisposeDbContext> options)
          : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

    }
}
