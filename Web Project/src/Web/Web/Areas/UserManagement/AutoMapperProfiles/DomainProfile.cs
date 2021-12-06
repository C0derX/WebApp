using AutoMapper;
using Web.Areas.UserManagement.ViewModels;
using Web.Areas.UserManagement.Models;
using UserManagement.Entities;
using UserManagement.Service.Dto;

namespace Web.Areas.UserManagement.AutoMapperProfiles
{
    public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<Modules, ModuleDetails>().ReverseMap();
            CreateMap<ModuleDto, Modules>().ReverseMap();
            CreateMap<MenuDetails, Menu>().ReverseMap();
            CreateMap<MenuDto, Menu>().ReverseMap();
            CreateMap<Role, RoleDetails>().ReverseMap();
            CreateMap<RoleDto, Role>().ReverseMap();
            CreateMap<RoleMenuMapDto, RoleMenuModel>().ReverseMap();
            CreateMap<UserDataDetails, User>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<UserDetailDto, UserDetails>().ReverseMap();
            CreateMap<OrganizationDto, Organization>().ReverseMap();
        }
    }
}
