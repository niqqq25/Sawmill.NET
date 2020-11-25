using AutoMapper;
using Lenta.Api.Entities;
using Lenta.Shared.Models.ManufacturingProcess;

namespace Lenta.Api.Profiles
{
    public class ManufacturingProcessProfile : Profile
    {
        public ManufacturingProcessProfile()
        {
            CreateMap<ManufacturingProcess, ManufacturingProcessDto>();
            CreateMap<ManufacturingProcessForCreationDto, ManufacturingProcess>();
            CreateMap<ManufacturingProcessForUpdateDto, ManufacturingProcess>();
        }
    }
}
