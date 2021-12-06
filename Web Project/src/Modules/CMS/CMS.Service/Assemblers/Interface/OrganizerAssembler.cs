using CMS.Entities;
using CMS.Service.Dto;

namespace CMS.Service.Assemblers.Interface
{
    public interface OrganizerAssembler
    {
        void copy(Organizer organizer, OrganizerDto organizerDto);

    }
}
