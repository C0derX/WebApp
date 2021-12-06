using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Entities;

namespace Web.Areas.UserManagement.ViewModels
{
    public class MenuIndexViewModel
    {
        public List<MenuDetails> menuDetails = new List<MenuDetails>();
    }

    public class MenuDetails
    {
        public long Id { get; set; }
        public long module_id { get; set; }
        public long? parent_menu_id { get; set; }
        public string name { get; set; }
        public string display_icon { get; set; }
        public string web_url { get; set; }
        public string api_url { get; set; }
        public int display_order { get; set; }
        public bool is_active { get; set; }
        public DateTime created_date { get; set; }
        public virtual Modules Modules { get; set; }
        public virtual Menu ParentMenu { get; set; }
    }
}
