using Core.Common.Helpers;
using Core.Library.UnitOfWork;
using Microsoft.AspNetCore.Http;
using System;
using UserManagement.Entities;
using UserManagement.Service.Assemblers.Interface;
using UserManagement.Service.Dto;
using UserManagement.Service.Repository.Interface;
using UserManagement.Service.Services.Interface;

namespace UserManagement.Service.Services.Implementations
{
    public sealed class UserDetailServiceImpl : UserDetailService
    {
        private readonly UserDetailRepository _userDetailRepo;
        private readonly UserDetailAssembler _userDetailAssembler;
        private readonly FileHelper _fileHelper;
        private readonly UnitOfWork _unitOfWork;

        public UserDetailServiceImpl(UserDetailRepository userDetailRepo, UserDetailAssembler userDetailAssembler, FileHelper fileHelper, UnitOfWork unitOfWork)
        {
            _userDetailRepo = userDetailRepo;
            _userDetailAssembler = userDetailAssembler;
            _fileHelper = fileHelper;
            _unitOfWork = unitOfWork;
        }

        public void saveOrUpdate(UserDetailDto user_detail_dto, IFormFile file = null)
        {
            try
            {
                _unitOfWork.begin();
                var userDetail = _userDetailRepo.getByUserId(user_detail_dto.user_id);

                if (userDetail == null)
                {
                    save(user_detail_dto, file);
                }
                else
                {
                    update(user_detail_dto, userDetail, file);
                }
                _unitOfWork.commit();
            }
            catch (Exception)
            {
                _unitOfWork.rollback();
                throw;
            }
        }
        private void update(UserDetailDto user_detail_dto, UserDetails user_detail, IFormFile file)
        {
            if (file != null)
            {
                if (user_detail.image != null)
                {
                    deleteImage(user_detail.image);
                }
                user_detail_dto.image = _fileHelper.saveFileAndGetFileName(file, user_detail_dto.first_name + " " + user_detail_dto.last_name);
            }

            _userDetailAssembler.copy(user_detail, user_detail_dto);
            _unitOfWork.GetRepository<UserDetails>().update(user_detail);
        }
        private void save(UserDetailDto user_detail_dto, IFormFile file)
        {

            var userDetail = new UserDetails();
            _userDetailAssembler.copy(userDetail, user_detail_dto);

            if (file != null)
            {
                string filePrefix = user_detail_dto.first_name + " " + user_detail_dto.last_name;

                userDetail.image = _fileHelper.saveFileAndGetFileName(file, filePrefix);
            }

            _unitOfWork.GetRepository<UserDetails>().insert(userDetail);
        }
        private void deleteImage(string iMAGE_PATH)
        {
            _fileHelper.deleteImage(iMAGE_PATH, _fileHelper.getPathToImageFolder());
        }
    }
}
