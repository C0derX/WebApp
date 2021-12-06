using CMS.Entities;
using System.Collections.Generic;

namespace Web.Areas.CMS.ViewModels
{
    public class HomeIndexViewModel
    {
        public HomeDetails homeDetails = new HomeDetails();
        public List<Student> std { get; set; }
    }
    public class HomeDetails
    {
        public long student_count { get; set; }
        public long seminar_count { get; set; }
        public long organizer_count { get; set; }
        public long register_count { get; set; }
    }
}
