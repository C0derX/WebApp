using Core.Common.Repository.Implementations;
using Core.Context;
using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Context.Repository.Implementations
{
    public class JwtTokenRepositoryImpl:BaseRepositoryImpl<JwtToken>,JwtTokenRepository
    {
        private AppDbContext _appDbContext;
        public JwtTokenRepositoryImpl(AppDbContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<JwtToken> getByUserId(long user_id)
        {
            return _appDbContext.jwt_tokens.Where(a => a.user_id == user_id).ToList();
        }
    }
}
