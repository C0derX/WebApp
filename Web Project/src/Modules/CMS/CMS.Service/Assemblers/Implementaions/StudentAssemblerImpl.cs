using CMS.Entities;
using CMS.Service.Assemblers.Interface;
using CMS.Service.Dto;

namespace CMS.Service.Assemblers.Implementaions
{
    public class StudentAssemblerImpl : StudentAssembler
    {
        public void copy(Student student, StudentDto studentDto)
        {
            student.Id = studentDto.Id;
            student.fullname = studentDto.fullname;
            student.email = studentDto.email;
            student.address = studentDto.address;
            student.phone_no = studentDto.phone_no;
            student.dob = studentDto.dob;
            student.student_id = studentDto.student_id;
        }
    }
}
