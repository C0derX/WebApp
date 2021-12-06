using CMS.Entities;
using CMS.Service.Repository.Interface;
using Core.Common.Repository.Implementations;
using Core.Context;

namespace CMS.Context.Repository.Implementations
{
    public class StudentRepositoryImpl : BaseRepositoryImpl<Student>, StudentRepository
    {
        private readonly AppDbContext _appDbContext;

        public StudentRepositoryImpl(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
