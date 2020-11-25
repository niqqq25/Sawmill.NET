using AutoMapper;
using Lenta.Api.Entities;
using Lenta.Shared.Models.Customer;

namespace Lenta.Api.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerForCreationDto, Customer>();
        }
    }
}
