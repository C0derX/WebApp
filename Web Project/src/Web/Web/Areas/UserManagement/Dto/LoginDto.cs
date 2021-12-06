using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.UserManagement.Dto
{
    public class LoginDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username is required.")]
        public string username { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required.")]
        public string password { get; set; }
        public bool remember_me { get; set; }
    }
}
