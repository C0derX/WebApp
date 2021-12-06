using System.ComponentModel.DataAnnotations;

namespace UserManagement.Service.Dto
{
    public class RegisterDto
    {
        public long created_by { get; set; }
        public string token { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email address is required.")]
        public string email { get; set; }

        [Compare(nameof(email), ErrorMessage = "Emails don't match.")]
        public string confirm_email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email address is required.")]
        public string password { get; set; }

        [Compare(nameof(confirm_password), ErrorMessage = "Passwords don't match.")]
        public string confirm_password { get; set; }

        public string base_url { get; set; }
    }
}
