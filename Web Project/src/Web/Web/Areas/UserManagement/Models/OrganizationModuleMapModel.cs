using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Entities;

namespace Web.Areas.UserManagement.Models
{
    public class OrganizationModuleMapModel
    {
        public List<long> module_ids { get; set; }
        public long organization_id { get; set; }
        public  virtual Organization organization { get; set; }
        public List<OrganizationModuleMap> organizationModuleMaps { get; set; }
        public List<Modules> modules { get; set; }
    }
}
