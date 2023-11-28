using CorePackages.Entities.Concrete;

namespace CorePackages.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetProductWithCategory();
    }
}
