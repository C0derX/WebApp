using Core.Common.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.Service.Dto
{
    public class RoleDto
    {
        public long Id { get; set; }
        public long created_by { get; set; }
        public long? modified_by { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Role name is required.")]
        [MaxLength(100)]
        [Display(Name ="Role Name")]
        public string name { get; set; }
        public bool is_enabled { get; set; } = true;

        [Display(Name = "Permissions")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Permission is required.")]
        public List<Permissions> permissions { get; set; }

        public List<long> menu_ids { get; set; } = new List<long>();
    }
}
