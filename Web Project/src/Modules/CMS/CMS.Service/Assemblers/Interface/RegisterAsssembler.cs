using CMS.Entities;
using CMS.Service.Dto;

namespace CMS.Service.Assemblers.Interface
{
    public  interface RegisterAsssembler
    {
        void copy(Register register,RegisterDto registerDto);
    }
}
