using CMS.Entities;
using CMS.Service.Repository.Interface;
using Core.Common.Repository.Implementations;
using Core.Context;

namespace CMS.Context.Repository.Implementations
{
    public class OrganizerRepositoryImpl : BaseRepositoryImpl<Organizer>, OrganizerRepository
    {
        private readonly AppDbContext _appDbContext;

        public OrganizerRepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
