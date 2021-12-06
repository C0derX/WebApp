using CMS.Entities;
using CMS.Service.Repository.Interface;
using Core.Common.Repository.Implementations;
using Core.Context;

namespace CMS.Context.Repository.Implementations
{
    public class SeminarRepositoryImpl : BaseRepositoryImpl<Seminar>, SeminarRepository
    {
        private readonly AppDbContext _appDbContext;
        public SeminarRepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }

}
