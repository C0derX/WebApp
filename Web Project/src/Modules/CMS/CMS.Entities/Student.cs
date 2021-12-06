using Core.Common.Entities;
using Project.Exceptions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Entities
{
    public class Student:BaseEntity
    {
        private string _fullName,_address,_phoneNo,_email;
        private long _studentId;

        [Display(Name = "Student Id")]
        [Required]
        public long student_id
        {
            get => _studentId;
            set
            {
                if (value<=0)
                {
                    throw new NonEmptyValueException("Student Id Is Required");
                }
                _studentId = value;
            }
        }
        [Display(Name = "Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is Required.")]
        public string fullname { get => _fullName;
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NonEmptyValueException("Full Name Is Requied");
                }_fullName = value;
            } 
        }
        [Required]
        [Display(Name = "Address")]
        public string address { get=>_address;
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NonEmptyValueException("Address Is Required");
                }
                _address = value;
            } 
        }
        [Required]
        [Display(Name = "Phone No")]
        public string phone_no { get=>_phoneNo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NonEmptyValueException("Phone NO Cannot Be Empty");
                }
                _phoneNo = value;
            }
        }

        [Required]
        [Display(Name = "Email")]
        public string email { get => _email; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NonEmptyValueException("Email Cannot Be Empty");
                }
                _email = value;
            } 
        }
        [Display(Name = "DOB")]
        public DateTime dob { get; set; }
        [Required]
        public bool is_active { get; set; } = true;
        public void setActive()
        {
            is_active = true;
        }

        public void setInactive()
        {
            is_active = false;
        }
    }
}
