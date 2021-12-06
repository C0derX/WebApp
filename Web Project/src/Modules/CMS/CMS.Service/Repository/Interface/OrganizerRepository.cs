using CMS.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CMS.Service.Repository.Interface
{
    public interface OrganizerRepository
    {
        void insert(Organizer organizer);
        void delete(Organizer organizer);
        void update(Organizer organizer);
        List<Organizer> getAll();
        Organizer getById(long org_id);
        IQueryable<Organizer> getQueryable();
    }
}
