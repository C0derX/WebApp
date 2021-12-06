using Core.Common.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Entities
{
    public class OrganizationModuleMap:BaseEntity
    {
        public long module_id { get; set; }
        public long organization_id { get; set; }
        [ForeignKey("module_id")]
        public virtual Modules modules { get; set; }
        [ForeignKey("organization_id")]
        public virtual Organization organization { get; set; }
    }
}
