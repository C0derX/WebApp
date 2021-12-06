using Core.Common.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Entities
{
    [Table("user")]
    public class User:BaseEntity
    {
        [DataType(DataType.EmailAddress)]
        [MaxLength(100)]
        [Required]
        public string email { get; set; }

        [Required]
        [MaxLength(50)]
        public string username { get; set; }

        [MaxLength(250)]
        [Required]
        public string password { get; set; }

        [MaxLength(1000)]
        public string registration_token { get; set; }

        [Required]
        public bool is_active { get; set; } = true;
        [Required]
        public bool is_email_confirmed { get; set; } = false;
        [Required]
        public int password_change_count { get; set; } = 0;
        [Required]
        public int access_failed_count { get; set; } = 0;

        public void setActive()
        {
            is_active = true;
        }
        public void setInactive()
        {
            is_active = false;
        }
        public void markEmailAsConfirmed()
        {
            is_email_confirmed = true;
        }
        public void increaseAccessFailedCount()
        {
            access_failed_count++;
        }
        public void increasePasswordChangeCount()
        {
            password_change_count++;
        }

        public virtual UserDetails UserDetails { get; set; }

        public virtual UserRoleMap UserRoleMap { get; set; }

    }
}
