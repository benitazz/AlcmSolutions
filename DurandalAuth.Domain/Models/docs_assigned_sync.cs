using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class docs_assigned_sync
    {
        public Nullable<System.DateTime> date_doc { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string doc_author { get; set; }
        public int mob_doc_id { get; set; }
        public Nullable<int> mob_incident_id { get; set; }
        public Nullable<short> mob_is_changed { get; set; }
        public string mob_locked_by { get; set; }
        public string name { get; set; }
        public int auto_number { get; set; }
    }
}
