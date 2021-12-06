using CMS.Entities;
using CMS.Service.Dto;

namespace CMS.Service.Assemblers.Interface
{
    public interface StudentAssembler
    {
        void copy(Student student, StudentDto studentDto);
    }
}
