using Core.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Entities;

namespace Web.Areas.UserManagement.ViewModels
{
    public class RoleIndexViewModel
    {
        public List<RoleDetails> roleDetails = new List<RoleDetails>();
    }

    public class RoleDetails
    {
        public long Id { get; set; }
        public string name { get; set; }
        public bool is_enabled { get; set; }
        public DateTime created_date { get; set; }
        public List<Permissions> permissions { get; set; }
    }
}
