using Core.Common.Entities;
using Core.Common.Enums;
using Project.Exceptions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Entities
{
    public class Seminar:BaseEntity
    {
        private string _title;
        private long _orgId;
        [Display(Name = "Organizer")]

        public long org_id { get=>_orgId;
            set
            {
                if (value<=0)
                {
                    throw new NonEmptyValueException("Organizer Id Cannot Be Empty");
                }
                _orgId = value;
            }
        }
        [Display(Name = "Title")]
        [Required]
        public string title { get=>_title;
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NonEmptyValueException("Seminar Title Cannot Be Empty");
                }_title = value;
            } 
        }
        [Display(Name = "Description")]

        public string description { get; set; }
        [Display(Name = "Date")]
        [Required]
        public DateTime date { get; set; }

        [ForeignKey("org_id")]
        public virtual Organizer organizer { get; set; }
        public  types types { get; set; }
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
