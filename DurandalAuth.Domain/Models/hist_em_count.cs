using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class hist_em_count
    {
        public int count_em { get; set; }
        public string bl_id { get; set; }
        public string dv_id { get; set; }
        public string dp_id { get; set; }
        public short year { get; set; }
        public short month { get; set; }
    }
}
