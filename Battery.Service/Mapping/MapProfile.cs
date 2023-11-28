using AutoMapper;
using Battery.Entities.Concrete;
using Battery.Entities.DTOs;

namespace Battery.Service.Mapping
{
    public class MapProfile : Profile
    {

        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
        }
    }
}
