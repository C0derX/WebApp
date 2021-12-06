using Core.Common.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Entities
{
    [Table("user_role_map")]
    public class UserRoleMap:BaseEntity
    {
        [Required]
        public long user_id { get; set; }

        [Required]
        public long role_id { get; set; }

        [ForeignKey(nameof(user_id))]
        public virtual User User { get; set; }

        [ForeignKey(nameof(role_id))]
        public virtual Role Role { get; set; }
    }
}
