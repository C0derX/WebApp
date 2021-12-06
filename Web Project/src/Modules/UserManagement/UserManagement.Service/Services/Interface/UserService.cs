using Core.Common.Dto;
using Microsoft.AspNetCore.Http;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Services.Interface
{
    public interface UserService
    {
        void save(UserDto user_dto);
        void register(RegisterDto register_dto);
        void markEmailRegistered(string token);
        void update(UserDto user_dto,IFormFile file);
        void delete(DeleteDto dto);
        void enable(ModificationDto dto);
        void disable(ModificationDto dto);
        void changePassword(ChangePasswordDto change_password_dto);
        void resetPassword(ChangePasswordDto change_password_dto);
        void sendPasswordRecoveryEmail(RecoverPasswordDto recover_password_dto);
    }
}
