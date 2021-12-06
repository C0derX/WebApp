using System.ComponentModel.DataAnnotations;

namespace UserManagement.Service.Dto
{
    public class PasswordRecoverDto
    {
        public long user_id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required.")]
        public string email { get; set; }
        public string new_password { get; set; }
        public string confirm_password { get; set; }
        public long modified_by { get; set; }
    }
}
