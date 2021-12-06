using Core.Common.Enums;
using System;
using System.Collections.Generic;

namespace Web.Areas.UserManagement.ViewModels
{
    public class ModuleIndexViewModel
    {
        public List<ModuleDetails> moduleDetails = new List<ModuleDetails>();
    }

    public class ModuleDetails
    {
        public long Id { get; set; }
        public string name { get; set; }
        public string display_icon { get; set; }
        public ModuleKey module_key { get; set; }
        public string code { get; set; }
        public long display_order { get; set; }
        public DateTime created_date { get; set; }
    }
}
