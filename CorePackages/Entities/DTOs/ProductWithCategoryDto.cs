namespace CorePackages.Entities.DTOs
{
    public class ProductWithCategoryDto : ProductDto
    {
        public CategoryDto? Category { get; set; }
    }
}
