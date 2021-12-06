using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Entities;
using UserManagement.Service.Assemblers.Interface;
using UserManagement.Service.Dto;

namespace UserManagement.Service.Assemblers.Implementations
{
    public class OrganizationAssemblerImpl : OrganizationAssembler
    {
        public void copy(Organization organization, OrganizationDto organizationDto)
        {
            organization.organization_name = organizationDto.organization_name;
            organization.address = organizationDto.address;
            organization.contact_no = organizationDto.contact_no;
            organization.contact_person = organizationDto.contact_person;
            organization.description = organizationDto.description;
            organization.email = organizationDto.email;
            organization.facebook_url = organizationDto.facebook_url;
            organization.instagram_url =organizationDto.instagram_url;
            organization.latitude = organizationDto.latitude;
            organization.longitude = organizationDto.longitude;
            organization.pan_no = organizationDto.pan_no;
            organization.short_name = organizationDto.short_name;
            organization.twitter_url = organizationDto.twitter_url;
            organization.youtube_url = organizationDto.youtube_url;
            if(organizationDto.logo!=null)
            organization.logo = organizationDto.logo;
        }
    }
}
