using AutoMapper;
using Lenta.Shared.Models.Product;

namespace Lenta.Web.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDto, ProductForUpdateDto>();
        }
    }
}
