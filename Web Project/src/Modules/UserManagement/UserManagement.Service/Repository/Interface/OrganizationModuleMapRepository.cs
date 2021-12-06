using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;

namespace UserManagement.Service.Repository.Interface
{
    public interface OrganizationModuleMapRepository
    {
        void insert(OrganizationModuleMap organizationModuleMap);
        void update(OrganizationModuleMap organizationModuleMap);
        void delete(OrganizationModuleMap organizationModuleMap);
        List<OrganizationModuleMap> getAll();
        OrganizationModuleMap getById(long role_id);
        IQueryable<OrganizationModuleMap> getQueryable();
    }
}
