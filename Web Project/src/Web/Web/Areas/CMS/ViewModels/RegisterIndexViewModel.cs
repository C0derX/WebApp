using CMS.Entities;
using Core.Common.Enums;
using System;
using System.Collections.Generic;

namespace Web.Areas.CMS.ViewModels
{
    public class RegisterIndexViewModel
    {
        public List<RegisterDetails> registerDetails = new List<RegisterDetails>();
    }
    public class RegisterDetails
    {
        public long Id { get; set; }
        public long student_id { get; set; }
        public long seminar_id { get; set; }
        public string title { get; set; }
        public bool is_active { get; set; }
        public DateTime created_date { get; set; }
        public Attendance attendance { get; set; }
        public virtual Student student { get; set; }
        public virtual Seminar seminar { get; set; }
    }
}
