using AutoMapper;
using CorePackages.Entities.Concrete;
using CorePackages.Entities.DTOs;

namespace Battery.Service.Mapping
{
    public class MapProfile : Profile
    {

        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<Product, ProductWithCategoryDto>();
            CreateMap<Category, CategoryWithProductsDto>();
        }
    }
}
