using CMS.Entities;
using CMS.Service.Assemblers.Interface;
using CMS.Service.Dto;

namespace CMS.Service.Assemblers.Implementaions
{
    public class RegisterAssemblerImpl : RegisterAsssembler
    {
        public void copy(Register register, RegisterDto registerDto)
        {
            register.Id = registerDto.Id;
            register.title = registerDto.title;
            register.seminar_id = registerDto.seminar_id;
            register.student_id = registerDto.student_id;
            register.attendance = registerDto.attendance;
        }
    }
}
