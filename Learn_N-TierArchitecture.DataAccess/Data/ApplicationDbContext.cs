using Microsoft.EntityFrameworkCore;
using Learn_N_TierArchitecture.Model;

namespace Learn_N_TierArchitecture.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Create Table
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<Product> Product { get; set; }

        // Seed Table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1, Name = "Type 1" }
                , new ProductType { Id = 2, Name = "Type 2" }
                , new ProductType { Id = 3, Name = "Type 3" }
                );
        }
    }
}
