using Project.Exceptions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Entities
{
    [Table("user_details")]
    public class UserDetails
    {
        private string _firstName, _lastName, _permanentAddress;
        private long _userId;

        [Key]
        public long Id { get; set; }

        [Required]
        public long user_id
        {
            get => _userId;
            set
            {
                if (value <= 0)
                {
                    throw new InvalidValueException("User Id in not valid.");
                }
                _userId = value;
            }
        }
        [MaxLength(50)]
        [Required]
        public string first_name
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NonEmptyValueException("First Name is Required.");
                }
                _firstName = value;
            }
        }
        [Required]
        [MaxLength(50)]
        public string last_name
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NonEmptyValueException("Last Name is Required.");
                }
                _lastName = value;
            }
        }
        [Required]
        [MaxLength(100)]
        public string permanent_address
        {
            get => _permanentAddress;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NonEmptyValueException("Permanent Address is Required.");
                }
                _permanentAddress = value;
            }
        }

        [MaxLength(100)]
        public string temporary_address { get; set; }

        [Required]
        [MaxLength(15)]
        public string primary_contact { get; set; }

        [MaxLength(15)]
        public string secondary_contact { get; set; }

        [MaxLength(150)]
        public string image { get; set; }

        [ForeignKey(nameof(user_id))]
        public virtual User User { get; set; }

        public string getUserFullName()
        {
            return $"{first_name} {last_name}";
        }

    }
}
