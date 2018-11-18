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
            CreateMap<InsurancePolicy, InsuranceViewModel>();
            CreateMap<Education, EducationViewModel>();
            CreateMap<Passport, PassportViewModel>();
            CreateMap<Position, PostViewModel>();
            CreateMap<ApplicationUser, UserViewModel>();
        }
    }
}
