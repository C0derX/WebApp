using CMS.Entities;
using Core.Common.Enums;
using System;
using System.Collections.Generic;

namespace Web.Areas.CMS.ViewModels
{
    public class SeminarIndexViewModel
    {
        public List<SeminarDetails> seminarDetails = new List<SeminarDetails>();
    }
    public class SeminarDetails
    {
        public long Id { get; set; }
        public long org_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public types types { get; set; }
        public bool is_active { get; set; }
        public DateTime created_date { get; set; }
        public DateTime date { get; set; }
        public virtual Organizer organizer { get; set; }
    }
}
