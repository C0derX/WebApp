using System.Threading.Tasks;

namespace UserManagement.Service.Services.Interface
{
    public interface EmailSenderService
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
