using AutoMapper;
using ParkManagement.Domain.Models;
using ParkManagement.Domain.Models.Entities;

namespace ParkManagement.Domain.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NationalPark, NationalParkCreationDto>().ReverseMap();
        }
    }
}