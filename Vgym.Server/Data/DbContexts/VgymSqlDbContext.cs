using Microsoft.EntityFrameworkCore;
using Vgym.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vgym.Data.Contexts
{
    public class VgymSqlDbContext:DbContext
    {
        public VgymSqlDbContext(DbContextOptions<VgymSqlDbContext>options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseIdentityColumns();
        }
        public DbSet<User> Users { get; set; }
    }
}
