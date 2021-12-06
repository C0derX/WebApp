using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;

namespace UserManagement.Service.Repository.Interface
{
    public interface JwtTokenRepository
    {
        void insert(JwtToken token);
        void update(JwtToken token);
        void delete(JwtToken token);
        List<JwtToken> getAll();
        JwtToken getById(long token_id);
        List<JwtToken> getByUserId(long user_id);
        IQueryable<JwtToken> getQueryable();
    }
}
