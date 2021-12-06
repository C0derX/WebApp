using System.ComponentModel.DataAnnotations;

namespace UserManagement.Service.Dto
{
    public class UserDetailDto
    {
        public long user_id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "First name is required.")]
        [MaxLength(50)]
        [Display(Name ="First Name")]
        public string first_name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name is required.")]
        [MaxLength(50)]
        [Display(Name ="Last Name")]
        public string last_name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Permanent Address is required.")]
        [MaxLength(100)]
        [Display(Name ="Permanent Address")]
        public string permanent_address { get; set; }

        [MaxLength(100)]
        [Display(Name = "Temporary Address")]
        public string temporary_address { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Primary contact is required.")]
        [StringLength(15, ErrorMessage = "The {0} should contain {2} digits.", MinimumLength = 10)]
        [Display(Name = "Primary Contact")]
        public string primary_contact { get; set; }

        [MaxLength(15)]
        [Display(Name = "Secondary Contact")]
        public string secondary_contact { get; set; }

        [MaxLength(100)]
        [Display(Name = "User Image")]
        public string image { get; set; }
    }
}
