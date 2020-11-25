using AutoMapper;
using Lenta.Api.Entities;
using Lenta.Shared.Models.CustomerOrderItem;

namespace Lenta.Api.Profiles
{
    public class CustomerOrderItemProfile : Profile
    {
        public CustomerOrderItemProfile()
        {
            CreateMap<CustomerOrderItem, CustomerOrderItemDto>();
            CreateMap<CustomerOrderItemForCreationDto, CustomerOrderItem>();
        }
    }
}
