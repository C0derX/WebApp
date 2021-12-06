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
    public class OrganizerServiceImpl : OrganizerService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly OrganizerAssembler _organizerAssembler;
        private readonly OrganizerRepository _organizerRepository;

        public OrganizerServiceImpl(UnitOfWork unitOfWork, OrganizerAssembler organizerAssembler, OrganizerRepository organizerRepository)
        {
            _unitOfWork = unitOfWork;
            _organizerAssembler = organizerAssembler;
            _organizerRepository = organizerRepository;
        }
        public void delete(DeleteDto deleteDto)
        {
            try
            {
                _unitOfWork.begin();
                var org = _organizerRepository.getById(deleteDto.Id) ?? throw new ItemNotFoundException($"Organizer with id {deleteDto.Id} not found");
                org.delete();
                org.modified_by = deleteDto.modified_by;
                org.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Organizer>().update(org);
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
                var org = _organizerRepository.getById(modificationDto.Id) ?? throw new ItemNotFoundException("Organizer not found.");
                org.setInactive();
                org.modified_by = modificationDto.modified_by;
                org.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Organizer>().update(org);
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
                var org = _organizerRepository.getById(modificationDto.Id) ?? throw new ItemNotFoundException("Organizer not found.");
                org.setActive();
                org.modified_by = modificationDto.modified_by;
                org.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Organizer>().update(org);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void save(OrganizerDto organizerDto)
        {
            try
            {
                _unitOfWork.begin();
                Organizer organizer = new Organizer();
                _organizerAssembler.copy(organizer, organizerDto);
                organizer.created_by = organizerDto.created_by;
                organizer.created_date = DateTime.Now;
                _unitOfWork.GetRepository<Organizer>().insert(organizer);
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }

        public void update(OrganizerDto organizerDto)
        {
            try
            {
                _unitOfWork.begin();
                var organizer = _organizerRepository.getById(organizerDto.Id) ?? throw new ItemNotFoundException("Id not found");
                _organizerAssembler.copy(organizer, organizerDto);
                organizer.modified_by = organizerDto.modified_by;
                organizer.modified_date = DateTime.Now;
                _unitOfWork.GetRepository<Organizer>().update(organizer);
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
