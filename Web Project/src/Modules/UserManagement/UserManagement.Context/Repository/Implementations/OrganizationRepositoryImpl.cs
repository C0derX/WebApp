using Core.Common.Repository.Implementations;
using Core.Context;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Context.Repository.Implementations
{
    public class OrganizationRepositoryImpl : BaseRepositoryImpl<Organization>, OrganizationRepository
    {
        private readonly AppDbContext _appDbContext;
        public OrganizationRepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
