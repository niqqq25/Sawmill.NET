using AutoMapper;
using Lenta.Api.Entities;
using Lenta.Shared.Models.Resource;

namespace Lenta.Api.Profiles
{
    public class ResourcesProfile : Profile
    {
        public ResourcesProfile()
        {
            CreateMap<Resource, ResourceDto>();
            CreateMap<ResourceForCreationDto, Resource>();
            CreateMap<ResourceForUpdateDto, Resource>();
        }
    }
}
