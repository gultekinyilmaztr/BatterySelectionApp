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
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 2,
                CellSerialNo = "02YCB65321800JB4B0003053",
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 2,
                CategoryId = 2,
                CellSerialNo = "02YCB65321800JB4B0003014",
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 3,
                CategoryId = 2,
                CellSerialNo = "02YCB65311800JB4B0003457",
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 4,
                CategoryId = 2,
                CellSerialNo = "02YCB65311800JB4B0004181",
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 5,
                CategoryId = 2,
                CellSerialNo = "02YCB65321800JB4B0004780",
                CreatedDate = DateTime.Now
            });

        }
    }
}
