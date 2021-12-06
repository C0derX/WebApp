using CMS.Entities;
using CMS.Service.Assemblers.Interface;
using CMS.Service.Dto;
using CMS.Service.Repository.Interface;
using CMS.Service.Services.Interface;
using Core.Common.Dto;
using Core.Library.UnitOfWork;
using Project.Exceptions;
using System;
using System.Linq;

namespace CMS.Service.Services.Implementations
{
    public class StudentServiceImpl : StudentService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly StudentAssembler _studentAssembler;
        private readonly StudentRepository _studentRepository;

        public StudentServiceImpl(UnitOfWork unitOfWork, StudentAssembler studentAssembler, StudentRepository studentRepository)
        {
            _unitOfWork = unitOfWork;
            _studentAssembler = studentAssembler;
            _studentRepository = studentRepository;
        }
        public void delete(DeleteDto deleteDto)
        {
            try
            {
                _unitOfWork.begin();
                var std = _studentRepository.getById(deleteDto.Id) ?? throw new ItemNotFoundException($"Student with id {deleteDto.Id} not found");
                std.delete();
                std.modified_by = deleteDto.modified_by;
                std.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Student>().update(std);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void disable(ModificationDto modificationDto)
        {
            try
            {
                _unitOfWork.begin();
                var std = _studentRepository.getById(modificationDto.Id) ?? throw new ItemNotFoundException("Student not found.");
                std.setInactive();
                std.modified_by = modificationDto.modified_by;
                std.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Student>().update(std);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void enable(ModificationDto modificationDto)
        {
            try
            {
                _unitOfWork.begin();
                var std = _studentRepository.getById(modificationDto.Id) ?? throw new ItemNotFoundException("Student not found.");
                std.setActive();
                std.modified_by = modificationDto.modified_by;
                std.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Student>().update(std);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void save(StudentDto studentDto)
        {
            try
            {
                _unitOfWork.begin();
                Student student = new Student();
                bool dublicateExists = checkDublicateLinkType(studentDto) == true;
                if (dublicateExists)
                    throw new ItemUsedException("This Student ID already exist.Please Choose New One to Create");
                _studentAssembler.copy(student, studentDto);
                student.created_by = studentDto.created_by;
                student.created_date = DateTime.Now;
                _unitOfWork.GetRepository<Student>().insert(student);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void update(StudentDto studentDto)
        {
            try
            {
                _unitOfWork.begin();
                var student = _studentRepository.getById(studentDto.Id) ?? throw new ItemNotFoundException("Id not found");
                _studentAssembler.copy(student, studentDto);
                student.modified_by = studentDto.modified_by;
                student.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Student>().update(student);
                _unitOfWork.commit();
            }
            catch (Exception)
            {

                _unitOfWork.rollback();
                throw;
            }
        }
        private  bool checkDublicateLinkType(StudentDto dto)
        {
            return  _studentRepository.getQueryable().Where(a => a.student_id == dto.student_id).Count() > 0;
        }
    }
}
