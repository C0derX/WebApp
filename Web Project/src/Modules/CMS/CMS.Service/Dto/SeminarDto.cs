using CMS.Entities;
using Core.Common.Enums;
using Project.Exceptions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Service.Dto
{
    public class SeminarDto
    {
        private string _title;
        private long _orgId;

        public long Id { get; set; }
        public long created_by { get; set; }
        public long modified_by { get; set; }

        [Display(Name = "Organizer")]
        public long org_id
        {
            get => _orgId;
            set
            {
                if (value <= 0)
                {
                    throw new NonEmptyValueException("Organizer Id Cannot Be Empty");
                }
                _orgId = value;
            }
        }
        [Display(Name = "Title")]
        [Required]
        public string title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NonEmptyValueException("Seminar Title Cannot Be Empty");
                }
                _title = value;
            }
        }
        [Display(Name = "Description")]

        public string description { get; set; }
        [Display(Name = "Date")]
        public DateTime date { get; set; }

        [ForeignKey("org_id")]
        public virtual Organizer organizer { get; set; }
        public types types { get; set; }
    }
}
