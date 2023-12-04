using CorePackages.Entities.Concrete;

namespace CorePackages.Entities.DTOs
{
    public class ProductWithCategoryDto : ProductDto
    {
        public CategoryDto Category { get; set; }

        public ProductFeatureDto ProductFeature { get; set; }
    }
}
