using Core.Common.Entities;
using Core.Common.Enums;
using Core.Common.Helpers.PermissionHelpers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Entities
{
    [Table("role_permission_map")]
    public class RolePermissionMap:BaseEntity
    {
        [Required]
        public long role_id { get; set; }
        public string permissions  { get;set; }

        [ForeignKey("role_id")]
        public virtual Role Role { get; set; }
        public List<Permissions> getPermissions() => permissions.UnpackPermissionsFromString();
        public void setPermissions(List<Permissions> permissionss)
        {
            permissions = permissionss.PackPermissionsIntoString();
        }
    }
}
