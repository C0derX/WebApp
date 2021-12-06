using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;

namespace UserManagement.Service.Repository.Interface
{
    public interface UserRepository
    {
        void insert(User user);
        void update(User user);
        void delete(User user);
        List<User> getAll();
        User getByToken(string token);
        User getByUsername(string username);
        User getByUserEmail(string email);
        User getById(long user_id);
        IQueryable<User> getQueryable();
    }
}
