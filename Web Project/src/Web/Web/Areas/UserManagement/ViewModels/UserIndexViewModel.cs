using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Entities;

namespace Web.Areas.UserManagement.ViewModels
{
    public class UserIndexViewModel
    {
        public List<UserDataDetails> userDataDetails = new List<UserDataDetails>();
    }

    public class UserDataDetails
    {
        public long Id { get; set; }
        public long created_by { get; set; }
        public DateTime created_date { get; set; }
        public bool is_active { get; set; } = true;
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public long modified_by { get; set; }
        public string registration_token { get; set; }
        public virtual UserDetails userDetails { get; set; }
        public virtual UserRoleMap UserRoleMap { get; set; }
    }
}
