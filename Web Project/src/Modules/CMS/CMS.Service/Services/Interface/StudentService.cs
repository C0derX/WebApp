using CMS.Service.Dto;
using Core.Common.Dto;

namespace CMS.Service.Services.Interface
{
    public interface StudentService
    {
        void save(StudentDto studentDto);
        void delete(DeleteDto deleteDto);
        void update(StudentDto studentDto);
        void enable(ModificationDto modificationDto);
        void disable(ModificationDto modificationDto);
    }
}
