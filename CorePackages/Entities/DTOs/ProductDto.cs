using CorePackages.Entities.Concrete;

namespace CorePackages.Entities.DTOs
{
    public class ProductDto : BaseDto
    {
        public Category? Category { get; set; }
        public ProductFeature? ProductFeature { get; set; }

    }
}
