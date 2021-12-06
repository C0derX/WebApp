using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.UserManagement.Dto
{
    public class ConfirmRegistrationDto
    {
        //[Required(AllowEmptyStrings =false,ErrorMessage ="Email address is required")]
        //public string emailAddress { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Token is required")]
        public string token { get; set; }
    }
}
