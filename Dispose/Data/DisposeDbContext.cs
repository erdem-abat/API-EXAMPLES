using Dispose.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Dispose.Data
{
    public class DisposeDbContext : DbContext
    {
        public DisposeDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

    }
}
