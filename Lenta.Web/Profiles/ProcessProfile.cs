using AutoMapper;
using Lenta.Shared.Models.ManufacturingProcess;

namespace Lenta.Web.Profiles
{
    public class ProcessProfile : Profile
    {
        public ProcessProfile()
        {
            CreateMap<ManufacturingProcessDto, ManufacturingProcessForUpdateDto>();
        }
    }
}
