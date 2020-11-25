using AutoMapper;
using Lenta.Api.Entities;
using Lenta.Shared.Models.ManufacturingOrder;

namespace Lenta.Api.Profiles
{
    public class ManufacturingOrderProfile : Profile
    {
        public ManufacturingOrderProfile()
        {
            CreateMap<ManufacturingOrder, ManufacturingOrderDto>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Product.Name));
            CreateMap<ManufacturingOrder, ManufacturingOrderFullDto>();
            CreateMap<ManufacturingOrderForCreationDto, ManufacturingOrder>();
        }
    }
}
