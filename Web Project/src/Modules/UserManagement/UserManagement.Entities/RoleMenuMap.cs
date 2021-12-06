using Core.Common.Entities;
using Project.Exceptions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Entities
{
    [Table("role_menu_map")]
    public class RoleMenuMap:BaseEntity
    {
        private long _roleId, _menuId;

        [Required]
        public long role_id
        {
            get => _roleId;
            set
            {
                if (value <= 0)
                {
                    throw new InvalidValueException("Role Id is invalid.");
                }
                _roleId = value;
            }
        }

        [Required]
        public long menu_id
        {
            get => _menuId;
            set
            {
                if (value <= 0)
                {
                    throw new InvalidValueException("Menu Id is Invalid.");
                }
                _menuId = value;
            }
        }

        [ForeignKey(nameof(menu_id))]
        public virtual Menu Menu { get; set; }

        [ForeignKey(nameof(role_id))]
        public virtual Role Role { get; set; }

    }
}
