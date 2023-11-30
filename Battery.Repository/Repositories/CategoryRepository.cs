using Battery.Repository.Concrete.EntityFramework;
using CorePackages.Entities.Concrete;
using CorePackages.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Battery.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BatterySelectionDbContext context) : base(context)
        {
        }

        public async Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId)
        {
            return await _context.Categories.Include(x => x.Products).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
        }
    }
}
