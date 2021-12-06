using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.UserManagement.Dto
{
    public class RefreshTokenDto
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="JWT token is required.")]
        public string jwt_token { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Refresh token is required.")]
        public string refresh_token { get; set; }
    }
}
