using AutoMapper;
using MyVitals.API.Business;
using MyVitals.API.Entities.Dto;
using MyVitals.API.ViewModels;
using Unit = MyVitals.API.Entities.Unit;

namespace MyVitals.API
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<UnitDto, UnitViewModel>().ReverseMap();
        }
    }
}