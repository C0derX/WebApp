using Core.Common.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UserManagement.Entities;

namespace UserManagement.Service.Dto
{
    public class UserDto
    {
        public long Id { get; set; }
        public long created_by { get; set; }
        public bool is_active { get; set; } = true;

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name ="Email Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required.")]
        public string email { get; set; }

        [Display(Name ="Username")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username is required.")]
        public string username { get; set; }

        [Display(Name ="Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
        public string password { get; set; }

        public long modified_by { get; set; }

        public string registration_token { get; set; }

        public  UserDetailDto user_detail_dto { get; set; }
        
        [Display(Name ="Role Permission")]
        public long  role_id { get; set; }

    }
}
