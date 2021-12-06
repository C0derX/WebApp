using Core.Common.Entities;
using Project.Exceptions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace UserManagement.Entities
{
    [Table("user_role")]
    public class Role:BaseEntity
    {
        private string _name;

        [Required]
        [MaxLength(100)]
        public string name { 
            get=>_name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NonEmptyValueException("Role cannot be Empty.");
                }
                _name = value;
            }
        }

        [Required]
        public bool is_enabled { get; set; } = true;
        public void enable()
        {
            is_enabled = true;
        }

        public void disable()
        {
            is_enabled = false;
        }
        public virtual List<RoleMenuMap> role_menu_maps { get; set; } = new List<RoleMenuMap>();

        public virtual List<UserRoleMap> user_role_maps { get; set; } = new List<UserRoleMap>();
        public virtual RolePermissionMap RolePermissionMap { get; set; }

        public bool hasUsersAssigned() => user_role_maps.Where(a => !a.is_deleted).Count() > 0;
    }
}
