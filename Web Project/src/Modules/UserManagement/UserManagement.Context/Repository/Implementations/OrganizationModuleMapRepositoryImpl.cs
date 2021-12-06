using Core.Common.Repository.Implementations;
using Core.Context;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Context.Repository.Implementations
{
    public class OrganizationModuleMapRepositoryImpl : BaseRepositoryImpl<OrganizationModuleMap>, OrganizationModuleMapRepository
    {
        private readonly AppDbContext _appDbContext;
        public OrganizationModuleMapRepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
