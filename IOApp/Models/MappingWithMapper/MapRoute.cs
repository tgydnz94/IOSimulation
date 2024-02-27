using AutoMapper;
using IOApp.Models.Dtos;
using Models.Concrete;

namespace IOApp.Models.MappingWithMapper
{
    public class MapRoute : Profile
    {
        public MapRoute()
        {
            CreateMap<AddCourseDto, Course>();
        }

    }
}
