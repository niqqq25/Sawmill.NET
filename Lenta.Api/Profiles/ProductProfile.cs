using AutoMapper;
using Lenta.Api.Entities;
using Lenta.Shared.Models.Product;

namespace Lenta.Api.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductForCreationDto, Product>();
            CreateMap<ProductForUpdateDto, Product>();

            CreateMap<Product, CustomProductDto>();
            CreateMap<CustomProductForCreationDto, Product>();
        }
    }
}
