using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_conn_log
    {
        public string connector_id { get; set; }
        public Nullable<System.DateTime> date_log { get; set; }
        public string msg { get; set; }
        public Nullable<System.DateTime> time_log { get; set; }
        public int conn_log_id { get; set; }
        public virtual afm_connector afm_connector { get; set; }
    }
}
