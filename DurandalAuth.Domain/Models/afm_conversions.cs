using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_conversions
    {
        public Nullable<System.DateTime> date_conversion { get; set; }
        public Nullable<System.DateTime> date_last_update { get; set; }
        public string destin_units { get; set; }
        public string exchange_rate_type { get; set; }
        public decimal factor { get; set; }
        public string is_currency { get; set; }
        public string source_units { get; set; }
        public string symbol { get; set; }
        public string transfer_status { get; set; }
        public int auto_number { get; set; }
        public virtual afm_currencies afm_currencies { get; set; }
        public virtual afm_currencies afm_currencies1 { get; set; }
    }
}
