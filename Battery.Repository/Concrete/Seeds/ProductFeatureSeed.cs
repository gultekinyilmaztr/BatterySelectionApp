using Battery.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery.Repository.Concrete.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature
                {

                    Id = 1,
                    Icdeger = 0.37,
                    Gerilim = 3.292,
                    Durum = true,
                    ProductId = 1,
                },
                new ProductFeature()
                {
                    Id = 2,
                    Icdeger = 0.35,
                    Gerilim = 3.292,
                    Durum = true,
                    ProductId = 2,

                });
        }
    }
}
