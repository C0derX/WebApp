using CMS.Service.Dto;
using Core.Common.Dto;

namespace CMS.Service.Services.Interface
{
    public interface SeminarService
    {
        void save(SeminarDto seminarDto);
        void delete(DeleteDto deleteDto);
        void update(SeminarDto seminarDto);
        void enable(ModificationDto modificationDto);
        void disable(ModificationDto modificationDto);
    }
}
