using Core.Common.Repository.Implementations;
using Core.Context;
using System.Linq;
using UserManagement.Entities;
using UserManagement.Service.Repository.Interface;

namespace UserManagement.Context.Repository.Implementations
{
    public class ModuleRepositoryImpl:BaseRepositoryImpl<Modules>,ModuleRepository
    {
        private readonly AppDbContext _appDbContext;
        public ModuleRepositoryImpl(AppDbContext appDbContext):base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Modules getByCode(string code)
        {
            return _appDbContext.modules.Where(a => a.code == code).SingleOrDefault();
        }

        public Modules getByName(string name)
        {
            return _appDbContext.modules.Where(a =>!a.is_deleted && a.name == name).SingleOrDefault();
        }
    }
}
