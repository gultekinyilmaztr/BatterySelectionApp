
using CorePackages.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Battery.Repository.Concrete.EntityFramework
{
    public class BatterySelectionDbContext : DbContext
    {
        public BatterySelectionDbContext(DbContextOptions<BatterySelectionDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<CategoryFeature> CategoryFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(BatterySelectionDbContext)));
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
