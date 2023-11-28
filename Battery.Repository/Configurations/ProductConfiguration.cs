using Battery.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Battery.Repository.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CellSerialNo).IsRequired().HasMaxLength(200);
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
        }
    }
}

//builder: Bu, ModelBuilder sınıfına ait bir nesnedir. Bu nesne, bir veritabanı modeli oluşturulurken kullanılır.

//HasOne(x => x.Category): Bu, Product sınıfının Category özelliğinin birincil anahtar (primary key) ile ilişkilendirildiğini belirtir. Yani, bir Product nesnesi bir Category nesnesine bağlıdır.

//WithMany(x => x.Products): Bu, Category sınıfının birçok Product nesnesi içerebileceğini belirtir. Yani, bir kategori birden fazla ürün içerebilir.

//HasForeignKey(x => x.CategoryId): Bu, Product sınıfındaki CategoryId özelliğinin, ilişkinin dış anahtarını temsil ettiğini belirtir. Yani, CategoryId alanı, Category tablosundaki bir kategori 
//    ile eşleşen bir dış anahtar (foreign key) olarak kullanılır.
