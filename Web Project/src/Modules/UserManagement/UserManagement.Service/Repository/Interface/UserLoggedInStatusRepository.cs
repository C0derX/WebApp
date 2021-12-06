using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;

namespace UserManagement.Service.Repository.Interface
{
    public interface UserLoggedInStatusRepository
    {
        void insert(UserLoggedInStatus user_detail);
        void update(UserLoggedInStatus user_detail);
        List<UserLoggedInStatus> getAll();
        UserLoggedInStatus getById(long Id);
        UserLoggedInStatus getByUserId(long Id);
        IQueryable<UserLoggedInStatus> getQueryable();
    }
}
