using Core.Common.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Entities
{
    [Table("user_loggedin_status_setup")]
    public class UserLoggedInStatus:BaseEntity
    {
        [Required]
        public long user_id { get; set; }
        [Required]
        public bool is_user_logged_in { get; set; } = false;

        public void setUserLoggedIn()
        {
            is_user_logged_in = true;
        }
        public void setUserLoggedOut()
        {
            is_user_logged_in = false;
        }
    }
}
