using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class bill_connector
    {
        public string bill_file_type { get; set; }
        public string bill_line_connector_id { get; set; }
        public string bill_type_id { get; set; }
        public string connector_version { get; set; }
        public Nullable<System.DateTime> date_effective_end { get; set; }
        public System.DateTime date_effective_start { get; set; }
        public string default_file { get; set; }
        public string description { get; set; }
        public short auto_approve { get; set; }
        public string vn_id { get; set; }
        public string vn_ac_id { get; set; }
        public string bill_connector_id { get; set; }
        public virtual afm_connector afm_connector { get; set; }
        public virtual afm_connector afm_connector1 { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual vn_ac vn_ac { get; set; }
    }
}
