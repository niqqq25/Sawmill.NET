using AutoMapper;
using Lenta.Shared.Models.Resource;

namespace Lenta.Web.Profiles
{
    public class ResourceProfile : Profile
    {
        public ResourceProfile()
        {
            CreateMap<ResourceDto, ResourceForUpdateDto>();
        }
    }
}
