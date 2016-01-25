using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_tctrace
    {
        public string branch_level { get; set; }
        public string detailed_memo { get; set; }
        public string source_key { get; set; }
        public string source_table { get; set; }
        public string summary_memo { get; set; }
        public string trace_direction { get; set; }
        public string trace_level { get; set; }
        public string transfer_status { get; set; }
        public int auto_number { get; set; }
    }
}
