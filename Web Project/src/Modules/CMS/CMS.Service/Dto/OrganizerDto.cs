using Project.Exceptions;
using System.ComponentModel.DataAnnotations;

namespace CMS.Service.Dto
{
    public class OrganizerDto
    {
        private string _orgName, _address, _phoneNo, _email;

        public long Id { get; set; }
        public long created_by { get; set; }
        public long modified_by { get; set; }

        [Display(Name = "Organizer")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is Required.")]
        public string orgname
        {
            get => _orgName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NonEmptyValueException("Full Name Is Requied");
                }
                _orgName = value;
            }
        }
        [Required]
        [Display(Name = "Address")]
        public string orgaddress
        {
            get => _address;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NonEmptyValueException("Organizer Address Is Required");
                }
                _address = value;
            }
        }
        [Required]
        [Display(Name = "Phone No")]
        public string org_phone_no
        {
            get => _phoneNo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NonEmptyValueException("Organizer Phone NO Cannot Be Empty");
                }
                _phoneNo = value;
            }
        }

        [Required]
        [Display(Name = "Email")]
        public string orgemail
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NonEmptyValueException("Email Cannot Be Empty");
                }
                _email = value;
            }
        }
    }
}
