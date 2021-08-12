using ClaimManager.DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace ClaimManager.DataLayer.DbContext
{
    public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<LossType> LossTypes { get; set; }
    }
}