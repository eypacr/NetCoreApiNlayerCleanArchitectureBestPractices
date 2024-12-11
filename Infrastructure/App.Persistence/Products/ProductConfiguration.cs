using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistence.Products;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
        builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");
        builder.Property(x => x.Stock).IsRequired();
        builder.Property(x => x.CategoryId).IsRequired();
        builder.Property(x => x.Created).IsRequired();
        builder.Property(x => x.Updated).IsRequired();

        // Seed Data
        builder.HasData(
            new Product { Id = 1, Name = "Dizüstü Bilgisayar", Price = 10000.00m, Stock = 50, CategoryId = 1, Created = DateTime.Now, Updated = DateTime.Now },
            new Product { Id = 2, Name = "Akıllı Telefon", Price = 7000.00m, Stock = 100, CategoryId = 2, Created = DateTime.Now, Updated = DateTime.Now },
            new Product { Id = 3, Name = "Kulaklık", Price = 1500.00m, Stock = 200, CategoryId = 3, Created = DateTime.Now, Updated = DateTime.Now },
            new Product { Id = 4, Name = "Akıllı Saat", Price = 3000.00m, Stock = 80, CategoryId = 2, Created = DateTime.Now, Updated = DateTime.Now },
            new Product { Id = 5, Name = "Tablet", Price = 5000.00m, Stock = 120, CategoryId = 1, Created = DateTime.Now, Updated = DateTime.Now }
        );
    }
}
