using CorePackages.Entities.Concrete;
using CorePackages.Entities.DTOs;

namespace CorePackages.Services
{
    public interface ICategoryService : IService<Category>
    {
        public Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}
