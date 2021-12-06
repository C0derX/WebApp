using UserManagement.Entities;

namespace UserManagement.Service.Services.Interface
{
    public interface AuthenticationService
    {
        User validate(string username, string password);
    }
}
