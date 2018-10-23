using AutoMapper;
using PersonalFiles.DAL;
using PersonalFiles.Models;

namespace PersonalFiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonViewModel>();
        }
    }
}
