using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class status_log
    {
        public string status_new { get; set; }
        public string status_old { get; set; }
        public string em_id { get; set; }
        public string table_name { get; set; }
        public string field_name { get; set; }
        public string record_id { get; set; }
        public System.DateTime date_changed { get; set; }
        public System.DateTime time_changed { get; set; }
        public virtual afm_flds afm_flds { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
        public virtual Em em { get; set; }
    }
}
