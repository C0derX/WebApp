using Project.Exceptions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Common.Entities
{
    public class BaseEntity
    {
        private long _createdBy;
        [Key]
        public long Id { get; set; }

        [Required]
        public DateTime created_date { get; set; } = DateTime.Now;
        public DateTime? modified_date { get; set; }

        [Required]
        public bool is_deleted { get; set; } = false;

        [Required]
        public long created_by {
            get => _createdBy;
            set
            {
                if (value <= 0)
                    throw new InvalidValueException("User is invalid");
                _createdBy = value;
            }
        }

        public long? modified_by { get; set; }

        public virtual void delete()
        {
            is_deleted = true;
        }
    }
}
