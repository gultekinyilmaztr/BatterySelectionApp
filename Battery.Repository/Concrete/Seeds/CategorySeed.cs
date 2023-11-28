
using CorePackages.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Battery.Repository.Concrete.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, CategoryName = "72Ah" },
                new Category { Id = 2, CategoryName = "105Ah" },
                new Category { Id = 3, CategoryName = "230Ah" });
        }
    }
}
