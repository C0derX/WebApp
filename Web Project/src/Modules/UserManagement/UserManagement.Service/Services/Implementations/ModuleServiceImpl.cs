using Core.Common.Dto;
using Core.Library.UnitOfWork;
using Project.Exceptions;
using System;
using UserManagement.Entities;
using UserManagement.Service.Assemblers.Interface;
using UserManagement.Service.Dto;
using UserManagement.Service.Repository.Interface;
using UserManagement.Service.Services.Interface;

namespace UserManagement.Service.Services.Implementations
{
    public class ModuleServiceImpl : ModuleService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly ModuleRepository _moduleRepository;
        private readonly ModuleAssembler _moduleAssembler;

        public ModuleServiceImpl(UnitOfWork unitOfWork, ModuleRepository moduleRepository, ModuleAssembler moduleAssembler)
        {
            _unitOfWork = unitOfWork;
            _moduleRepository = moduleRepository;
            _moduleAssembler = moduleAssembler;
        }
        public void delete(DeleteDto dto)
        {
            try
            {
                _unitOfWork.begin();
                var module = _moduleRepository.getById(dto.Id) ?? throw new ItemNotFoundException($"Module with ID {dto.Id} doesnot Exist.");
                module.delete();
                module.modified_by = dto.modified_by;
                module.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Modules>().update(module);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void save(ModuleDto moduleDto)
        {
            try
            {
                _unitOfWork.begin();
                validateNameAndCode(moduleDto);
                Modules module = new Modules();
                _moduleAssembler.copy(module, moduleDto);
                module.created_date = DateTime.Now;
                module.created_by = moduleDto.created_by;
                _unitOfWork.GetRepository<Modules>().insert(module);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void update(ModuleDto moduleDto)
        {
            try
            {
                _unitOfWork.begin();
                var module = _moduleRepository.getById(moduleDto.Id) ?? throw new ItemNotFoundException($"Module with ID {moduleDto.Id} doesnot exist.");
                validateNameAndCode(moduleDto);
                _moduleAssembler.copy(module, moduleDto);
                module.modified_by = moduleDto.modified_by;
                module.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Modules>().update(module);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        private bool isModuleNameAllowed(ModuleDto module_dto)
        {
            var moduleWithSameName = _moduleRepository.getByName(module_dto.name);
            bool moduleWithSameNameDoesnotExist = moduleWithSameName == null;
            bool moduleWithSameNameIsSameAsDto = false;
            if (moduleWithSameName != null)
            {
                moduleWithSameNameIsSameAsDto = moduleWithSameName.Id == module_dto.Id;
            }
            return moduleWithSameNameDoesnotExist || moduleWithSameNameIsSameAsDto;
        }

        private bool checkIfCodeIsDuplicate(ModuleDto module_dto)
        {
            var moduleWithSameCode = _moduleRepository.getByCode(module_dto.code);
            if (moduleWithSameCode == null || moduleWithSameCode.Id == module_dto.Id)
            {
                return false;
            }
            return true;
        }
        private void validateNameAndCode(ModuleDto moduleDto)
        {
            bool isNameAllowed = isModuleNameAllowed(moduleDto);
            if (!isNameAllowed)
                throw new DuplicateItemException("Module with same name already exists.");
            bool isCodeDuplicate = checkIfCodeIsDuplicate(moduleDto);
            if (isCodeDuplicate)
                throw new DuplicateItemException("Module with same code already exists.");
        }

    }
}
