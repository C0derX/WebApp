using Core.Common.Repository.Implementations;
using Core.Context;
using System.Linq;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Context.Repository.Implementations
{
    public class RoleRepositoryImpl:BaseRepositoryImpl<Role>,RoleRepository
    {
        private readonly AppDbContext _appDbContext;
        public RoleRepositoryImpl(AppDbContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Role getByName(string role_name)
        {
            return _appDbContext.role.Where(a => a.name.ToUpper() == role_name.ToUpper()).SingleOrDefault();
        }
    }
}
