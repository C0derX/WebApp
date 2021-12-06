using CMS.Service.Dto;
using Core.Common.Dto;

namespace CMS.Service.Services.Interface
{
    public interface OrganizerService
    {
        void save(OrganizerDto organizerDto);
        void delete(DeleteDto deleteDto);
        void update(OrganizerDto organizerDto);
        void enable(ModificationDto modificationDto);
        void disable(ModificationDto modificationDto);
    }
}
