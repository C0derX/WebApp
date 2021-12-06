using CMS.Entities;
using CMS.Service.Assemblers.Interface;
using CMS.Service.Dto;
using CMS.Service.Repository.Interface;
using CMS.Service.Services.Interface;
using Core.Common.Dto;
using Core.Library.UnitOfWork;
using Project.Exceptions;
using System;

namespace CMS.Service.Services.Implementations
{
    public class RegisterServiceImpl : RegisterService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly RegisterAsssembler _registerAssembler;
        private readonly RegisterRepository _registerRepository;

        public RegisterServiceImpl(UnitOfWork unitOfWork, RegisterAsssembler registerAssembler, RegisterRepository registerRepository)
        {
            _unitOfWork = unitOfWork;
            _registerAssembler = registerAssembler;
            _registerRepository = registerRepository;
        }
        public void delete(DeleteDto deleteDto)
        {
            try
            {
                _unitOfWork.begin();
                var reg = _registerRepository.getById(deleteDto.Id) ?? throw new ItemNotFoundException($"Register with id {deleteDto.Id} not found");
                reg.delete();
                reg.modified_by = deleteDto.modified_by;
                reg.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Register>().update(reg);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void save(RegisterDto registerDto)
        {
            try
            {
                _unitOfWork.begin();
                Register register = new Register();
                _registerAssembler.copy(register, registerDto);
                register.created_by = registerDto.created_by;
                register.created_date = DateTime.Now;
                _unitOfWork.GetRepository<Register>().insert(register);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void update(RegisterDto registerDto)
        {
            try
            {
                _unitOfWork.begin();
                var register = _registerRepository.getById(registerDto.Id) ?? throw new ItemNotFoundException("Id not found");
                _registerAssembler.copy(register, registerDto);
                register.modified_by = registerDto.modified_by;
                register.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Register>().update(register);
                _unitOfWork.commit();
            }
            catch (Exception)
            {

                _unitOfWork.rollback();
                throw;
            }
        }
    }
}
