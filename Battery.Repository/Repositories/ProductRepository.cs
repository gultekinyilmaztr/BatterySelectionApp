using Battery.Repository.Concrete.EntityFramework;
using CorePackages.Entities.Concrete;
using CorePackages.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Battery.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(BatterySelectionDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductWithCategory()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}
