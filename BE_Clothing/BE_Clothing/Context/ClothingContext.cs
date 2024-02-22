using BE_Clothing.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BE_Clothing.Context
{
    public class ClothingContext : DbContext
    {
        public ClothingContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User>? users { get; set; }
        public DbSet<Clothing>? clothings { get; set; }
    }
}
