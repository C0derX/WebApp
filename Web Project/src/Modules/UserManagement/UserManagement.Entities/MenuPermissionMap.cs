using Core.Common.Entities;
using Core.Common.Enums;
using Core.Common.Helpers.PermissionHelpers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Entities
{
    [Table("menu_permission_map")]
    public class MenuPermissionMap:BaseEntity
    {
        [Required]
        public long menu_id { get; set; }
        public string permissions  { get; set; }

        [ForeignKey(nameof(menu_id))]
        public virtual Menu menu { get; set; }

        public List<Permissions> getPermissions() => permissions.UnpackPermissionsFromString();
        public void setPermissions(List<Permissions> permissionss)
        {
            permissions = permissionss.PackPermissionsIntoString();
        }
    }
}
