using CMS.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CMS.Service.Repository.Interface
{
    public interface SeminarRepository
    {
        void insert(Seminar seminar);
        void delete(Seminar seminar);
        void update(Seminar seminar);
        List<Seminar> getAll();
        Seminar getById(long seminar_id);
        IQueryable<Seminar> getQueryable();
    }
}
