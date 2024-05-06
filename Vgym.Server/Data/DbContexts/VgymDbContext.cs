using Microsoft.EntityFrameworkCore;
using Vgym.Models.Entities;


namespace Vgym.Data.Contexts
{
    public class VgymDbContext:DbContext
    {
        public VgymDbContext(DbContextOptions<VgymDbContext>options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseIdentityColumns();
        }
        public DbSet<User> Users { get; set; }
    }
}
