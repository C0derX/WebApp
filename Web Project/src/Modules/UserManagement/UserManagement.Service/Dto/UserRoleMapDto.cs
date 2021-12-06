using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace UserManagement.Service.Dto
{
    public class UserRoleMapDto
    {
        [Required]
        public long user_id { get; set; }
        public long role_id { get; set; }

        public long created_by { get; set; }
        public long? modified_by { get; set; }
    }
}
