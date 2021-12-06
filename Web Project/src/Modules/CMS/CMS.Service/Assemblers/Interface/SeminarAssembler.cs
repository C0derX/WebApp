using CMS.Entities;
using CMS.Service.Dto;

namespace CMS.Service.Assemblers.Interface
{
    public interface SeminarAssembler
    {
        void copy(Seminar seminar,SeminarDto seminarDto );
    }
}
