using System;
using System.Collections.Generic;

namespace Web.Areas.CMS.ViewModels
{
    public class OrganizerIndexViewModel
    {
        public List<OrganizerDetails> organizerDetails = new List<OrganizerDetails>();

    }
    public class OrganizerDetails
    {
        public long Id { get; set; }
        public string orgname { get; set; }
        public string orgaddress { get; set; }
        public string org_phone_no { get; set; }
        public string orgemail { get; set; }
        public bool is_active { get; set; }
        public DateTime created_date { get; set; }
    }
}
