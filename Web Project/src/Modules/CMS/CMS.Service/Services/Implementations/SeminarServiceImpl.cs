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
    public class SeminarServiceImpl:SeminarService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly SeminarAssembler _seminarAssembler;
        private readonly SeminarRepository _seminarRepository;

        public SeminarServiceImpl(UnitOfWork unitOfWork, SeminarAssembler seminarAssembler, SeminarRepository seminarRepository)
        {
            _unitOfWork = unitOfWork;
            _seminarAssembler = seminarAssembler;
            _seminarRepository = seminarRepository;
        }

        public void delete(DeleteDto deleteDto)
        {
            try
            {
                _unitOfWork.begin();
                var seminar = _seminarRepository.getById(deleteDto.Id) ?? throw new ItemNotFoundException($"Seminar with id {deleteDto.Id} not found");
                seminar.delete();
                seminar.modified_by = deleteDto.modified_by;
                seminar.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Seminar>().update(seminar);
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
                var seminar = _seminarRepository.getById(modificationDto.Id) ?? throw new ItemNotFoundException("Seminar not found.");
                seminar.setInactive();
                seminar.modified_by = modificationDto.modified_by;
                seminar.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Seminar>().update(seminar);
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
                var std = _seminarRepository.getById(modificationDto.Id) ?? throw new ItemNotFoundException("Seminar not found.");
                std.setActive();
                std.modified_by = modificationDto.modified_by;
                std.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Seminar>().update(std);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void save(SeminarDto seminarDto)
        {
            try
            {
                _unitOfWork.begin();
                Seminar seminar = new Seminar();
                _seminarAssembler.copy(seminar, seminarDto);
                seminar.created_by = seminarDto.created_by;
                seminar.created_date = DateTime.Now;
                _unitOfWork.GetRepository<Seminar>().insert(seminar);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void update(SeminarDto seminarDto)
        {
            try
            {
                _unitOfWork.begin();
                var seminar = _seminarRepository.getById(seminarDto.Id) ?? throw new ItemNotFoundException("Id not found");
                _seminarAssembler.copy(seminar, seminarDto);
                seminar.modified_by = seminarDto.modified_by;
                seminar.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Seminar>().update(seminar);
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
