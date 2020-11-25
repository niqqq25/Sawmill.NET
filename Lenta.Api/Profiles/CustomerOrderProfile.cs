using AutoMapper;
using Lenta.Api.Entities;
using Lenta.Shared.Models.CustomerOrder;

namespace Lenta.Api.Profiles
{
    public class CustomerOrderProfile : Profile
    {
        public CustomerOrderProfile()
        {
            CreateMap<CustomerOrder, CustomerOrderDto>();
            CreateMap<CustomerOrder, CustomerOrderFullDto>();
            CreateMap<CustomerOrderForCreationDto, CustomerOrder>();
        }
    }
}
