using Project.Exceptions;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.Service.Dto
{
    public class OrganizationDto
    {
        private string _orgName;
        public long Id { get; set; }
        [Display(Name ="Organization Name")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Organization Name is required.")]
        public string organization_name
        {
            get => _orgName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new NonEmptyValueException("Organization Name is Required");
                _orgName = value;
            }
        }
        [Display(Name = "Short Name")]
        public string short_name { get; set; }
        [Display(Name = "Organization Description")]
        public string description { get; set; }
        [Display(Name = "Address")]
        public string address { get; set; }
        [Display(Name = "Contact Number")]
        public string contact_no { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "PAN Number")]
        public string pan_no { get; set; }
        [Display(Name = "Organization Logo")]
        public string logo { get; set; }
        [Display(Name = "Contact Person")]
        public string contact_person { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        [Display(Name = "Facebook Url")]
        public string facebook_url { get; set; }
        [Display(Name = "Twitter Url")]
        public string twitter_url { get; set; }
        [Display(Name = "Instagram Url")]
        public string instagram_url { get; set; }
        [Display(Name = "Youtube Url")]
        public string youtube_url { get; set; }
        public long  modified_by { get; set; }
        public  long created_by { get; set; }
    }
}
