using System.Collections.Generic;
using UserManagement.Entities;

namespace Web.Areas.UserManagement.Models
{
    public class RoleMenuModel
    {
        public long role_id { get; set; }
        public List<long> menu_ids { get; set; }
        public List<RoleMenuMap> roleMenuMaps {get;set;}
        public List<Modules> modules { get; set; }
    }

   
}
