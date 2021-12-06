using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserManagement.Entities
{
    public class JwtToken
    {
        [Key]
        public long jwt_token_id { get; set; }

        [Required]
        public long user_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string old_token { get; set; }

        [MaxLength(50)]
        public string new_token { get; set; }

        [ForeignKey(nameof(user_id))]
        public virtual User User { get; set; }
    }
}
