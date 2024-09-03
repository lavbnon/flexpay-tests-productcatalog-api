using Microsoft.EntityFrameworkCore;

namespace Flexpay.ProductCatalog.WebApi
{
    public class ProductCatalogDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "ProductDatabase");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catalog>().HasData(
                new Catalog { Id = 1, Name = "Basic items" },
                new Catalog { Id = 2, Name = "Better items" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000011"), Name = "Pants", Price = 59.99m, CatalogId = 1
                },
                new Product
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000012"), Name = "T-Shirt", Price = 10.99m, CatalogId = 1
                },
                new Product
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000111"), Name = "Fancy Pants", Price = 499.99m, CatalogId = 2
                },
                new Product
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000112"), Name = "Designer T-Shirt", Price = 259.99m, CatalogId = 2
                }
            );
        }

        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}