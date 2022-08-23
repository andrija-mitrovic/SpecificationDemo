using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
