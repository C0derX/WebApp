using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;

namespace UserManagement.Service.Repository.Interface
{
    public interface UserDetailRepository
    {
        void insert(UserDetails user_detail);
        void update(UserDetails user_detail);
        List<UserDetails> getAll();
        UserDetails getById(long user_detail_id);
        UserDetails getByUserId(long user_id);
        IQueryable<UserDetails> getQueryable();
    }
}
