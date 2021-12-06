using Core.Common.Entities;
using Core.Common.Enums;
using Project.Exceptions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Entities
{
    public class Register :BaseEntity
    {
        private long _student_id,_seminar_id;
     
        [Display(Name ="Title")]
        public string title { get; set; }
        [Required]
        public long student_id { 
            get => _student_id;
            set
            {
                if (value<=0)
                {
                    throw new NonEmptyValueException("Student Id Cannot Be Empty");
                }
                _student_id = value;
            }
        }
        [Required]
        public long seminar_id
        {
            get => _seminar_id;
            set
            {
                if (value <= 0)
                {
                    throw new NonEmptyValueException("Seminar Id Cannot Be Empty");
                }
                _seminar_id = value;
            }
        }
        [ForeignKey("student_id")]
        public virtual Student student { get; set; }
        [ForeignKey("seminar_id")]
        public virtual Seminar seminar { get; set; }
        public Attendance attendance { get; set; }
    }
}
