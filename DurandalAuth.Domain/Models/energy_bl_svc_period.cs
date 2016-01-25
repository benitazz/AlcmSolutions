using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class energy_bl_svc_period
    {
        public decimal consumption { get; set; }
        public decimal cost { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public decimal demand { get; set; }
        public decimal norm_cdd { get; set; }
        public decimal norm_hdd { get; set; }
        public short num_days { get; set; }
        public short outlier_consumption { get; set; }
        public short outlier_demand { get; set; }
        public decimal period_cdd { get; set; }
        public decimal period_hdd { get; set; }
        public short period_index { get; set; }
        public decimal period_oat { get; set; }
        public string vn_id { get; set; }
        public string bl_id { get; set; }
        public string bill_type_id { get; set; }
        public string time_period { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bl bl { get; set; }
        public virtual energy_time_period energy_time_period { get; set; }
        public virtual vn vn { get; set; }
    }
}
