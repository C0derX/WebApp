using CMS.Entities;
using CMS.Service.Assemblers.Interface;
using CMS.Service.Dto;

namespace CMS.Service.Assemblers.Implementaions
{
    public class OrganizerAssemblerImpl : OrganizerAssembler
    {
        public void copy(Organizer organizer, OrganizerDto organizerDto)
        {
            organizer.Id = organizerDto.Id;
            organizer.orgname = organizerDto.orgname;
            organizer.orgemail = organizerDto.orgemail;
            organizer.orgaddress = organizerDto.orgaddress;
            organizer.org_phone_no = organizerDto.org_phone_no;
        }
    }
}
