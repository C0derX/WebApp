using System.Collections.Generic;
using System.Linq;
using UserManagement.Entities;

namespace UserManagement.Service.Repository.Interface
{
    public interface ModuleRepository
    {
        void insert(Modules module);
        void update(Modules module);
        void delete(Modules module);
        List<Modules> getAll();
        Modules getById(long module_id);
        Modules getByName(string name);
        Modules getByCode(string code);
        IQueryable<Modules> getQueryable();
    }
}
