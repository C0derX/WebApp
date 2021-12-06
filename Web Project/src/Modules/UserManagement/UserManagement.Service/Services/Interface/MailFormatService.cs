using UserManagement.Service.Dto;

namespace UserManagement.Service.Services.Interface
{
    public interface MailFormatService
    {
        string getRegisterMailFormat(RegisterDto dto, string redirect_url);
        string getChangePasswordMailFormat(string email, string new_pass);
        string getRecoverPasswordMailFormat(RecoverPasswordDto dto, string full_url);
    }
}
