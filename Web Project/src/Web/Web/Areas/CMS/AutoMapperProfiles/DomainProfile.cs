using AutoMapper;
using Web.Areas.CMS.ViewModels;
using CMS.Entities;
using CMS.Service.Dto;

namespace Web.Areas.CMS.AutoMapperProfiles
{
    public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<StudentDetails, Student>().ReverseMap();
            CreateMap<StudentDto, Student>().ReverseMap();
            CreateMap<OrganizerDetails, Organizer>().ReverseMap();
            CreateMap<OrganizerDto, Organizer>().ReverseMap();
            CreateMap<SeminarDetails, Seminar>().ReverseMap();
            CreateMap<SeminarDto, Seminar>().ReverseMap();
            CreateMap<RegisterDetails, Register>().ReverseMap();
            CreateMap<RegisterDto, Register>().ReverseMap();
        }
    }
}
