using CMS.Entities;
using CMS.Service.Assemblers.Interface;
using CMS.Service.Dto;

namespace CMS.Service.Assemblers.Implementaions
{
    public class SeminarAssemblerImpl : SeminarAssembler
    {
        public void copy(Seminar seminar, SeminarDto seminarDto)
        {
            seminar.Id = seminarDto.Id;
            seminar.description = seminarDto.description;
            seminar.title = seminarDto.title;
            seminar.org_id = seminarDto.org_id;
            seminar.types = seminarDto.types;
            seminar.date = seminarDto.date;
        }
    }
}
