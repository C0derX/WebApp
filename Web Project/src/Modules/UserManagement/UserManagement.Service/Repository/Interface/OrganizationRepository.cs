using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;

namespace UserManagement.Service.Repository.Interface
{
    public interface OrganizationRepository
    {
        void insert(Organization organization);
        void update(Organization organization);
        void delete(Organization organization);
        List<Organization> getAll();
        Organization getById(long role_id);
        IQueryable<Organization> getQueryable();
    }
}
