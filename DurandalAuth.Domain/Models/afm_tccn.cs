using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_tccn
    {
        public string ca_std { get; set; }
        public string comments { get; set; }
        public string downhill_key { get; set; }
        public string downhill_position { get; set; }
        public string downhill_position_end { get; set; }
        public string downhill_table { get; set; }
        public string transfer_status { get; set; }
        public string uphill_key { get; set; }
        public string uphill_position { get; set; }
        public string uphill_position_end { get; set; }
        public string uphill_table { get; set; }
        public int auto_number { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
        public virtual afm_tbls afm_tbls1 { get; set; }
        public virtual castd castd { get; set; }
    }
}
