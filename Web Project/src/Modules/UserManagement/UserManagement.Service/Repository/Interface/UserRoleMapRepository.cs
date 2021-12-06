using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;

namespace UserManagement.Service.Repository.Interface
{
    public interface UserRoleMapRepository
    {
        void insert(UserRoleMap user_role_map);
        void update(UserRoleMap user_role_map);
        void delete(UserRoleMap user_role_map);
        List<UserRoleMap> getAll();
        List<UserRoleMap> getByRole(long role_id);
        List<UserRoleMap> getByUser(long user_id);
        UserRoleMap getByRoleAndUser(long role_id, long user_id);
        UserRoleMap getById(long user_role_map_id);
        IQueryable<UserRoleMap> getQueryable();
    }
}
