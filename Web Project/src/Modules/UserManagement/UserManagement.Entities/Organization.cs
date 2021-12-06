using Core.Common.Entities;
using Project.Exceptions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.Entities
{
    public class Organization : BaseEntity
    {
        private string _orgName;

        [Required]
        [MaxLength(50)]
        public string organization_name {
            get => _orgName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new NonEmptyValueException("Organization Name is Required");
                _orgName = value;
            }
        }
        [MaxLength(20)]
        public string short_name { get; set; }
        [MaxLength(300)]
        public string description { get; set; }
        [MaxLength(50)]
        public string address { get; set; }
        [MaxLength(15)]
        public string contact_no { get; set; }
        [MaxLength(30)]
        public string email { get; set; }
        [MaxLength(15)]
        public string pan_no { get; set; }
        public string logo { get; set; }
        [MaxLength(15)]
        public string contact_person { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string facebook_url { get; set; }
        public string twitter_url { get; set; }
        public string instagram_url { get; set; }
        public string youtube_url { get; set; }

        public virtual List<OrganizationModuleMap> organizationModuleMaps { get; set; }
    }
}
