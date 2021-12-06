using System;
using System.Collections.Generic;

namespace Web.Areas.CMS.ViewModels
{
    public class StudentIndexViewModel
    {
        public List<StudentDetails> studentDetails = new List<StudentDetails>();
    }
    public class StudentDetails
    {
        public long Id { get; set; }
        public long student_id { get; set; }
        public string fullname { get; set; }
        public string address { get; set; }
        public string phone_no { get; set; }
        public string email { get; set; }
        public bool is_active { get; set; }
        public DateTime created_date { get; set; }
        public DateTime dob { get; set; }
    }
}
