using CorePackages.Entities.Concrete;
using CorePackages.Entities.DTOs;

namespace CorePackages.Services
{
    public interface IProductService : IService<Product>
    {
        Task<List<ProductWithCategoryDto>> GetProductsWithCategory();
    }
}
