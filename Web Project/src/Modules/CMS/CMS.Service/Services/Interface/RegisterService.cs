using CMS.Service.Dto;
using Core.Common.Dto;

namespace CMS.Service.Services.Interface
{
    public interface  RegisterService
    {
        void save(RegisterDto registerDto);
        void delete(DeleteDto deleteDto);
        void update(RegisterDto registerDto);
    }
}
