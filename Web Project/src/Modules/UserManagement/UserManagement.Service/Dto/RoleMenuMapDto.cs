using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.Service.Dto
{
    public class RoleMenuMapDto
    {
        [Required]
        public long role_id { get; set; }
        public List<long> menu_ids { get; set; }
        public long created_by { get; set; }
    }
}
