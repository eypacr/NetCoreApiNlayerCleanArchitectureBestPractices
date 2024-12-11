using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistence.Categories;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(150);

        // Seed Data
        builder.HasData(
            new Category { Id = 1, Name = "Elektronik", Created = DateTime.Now, Updated = DateTime.Now },
            new Category { Id = 2, Name = "Aksesuarlar", Created = DateTime.Now, Updated = DateTime.Now },
            new Category { Id = 3, Name = "Ses", Created = DateTime.Now, Updated = DateTime.Now }
        );
    }
}
