using Core.Common.Enums;
using System.Collections.Generic;

namespace UserManagement.Service.Dto
{
    public class RolePermissionMapDto
    {
        public long role_id { get; set; }
        public List<Permissions> permissions { get; set; } = new List<Permissions>();
        public long created_by { get; set; }
        public long? modified_by { get; set; }
    }
}
