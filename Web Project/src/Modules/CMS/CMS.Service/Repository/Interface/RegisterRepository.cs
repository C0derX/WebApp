using CMS.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CMS.Service.Repository.Interface
{
    public interface RegisterRepository
    {
        void insert(Register register);
        void delete(Register register);
        void update(Register register);
        List<Register> getAll();
        Register getById(long reg_id);
        IQueryable<Register> getQueryable();
    }
}
