using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pv
    {
        public decimal lead_time { get; set; }
        public Nullable<short> rank { get; set; }
        public string vn_pt_num { get; set; }
        public string part_id { get; set; }
        public string vn_id { get; set; }
        public virtual pt pt { get; set; }
        public virtual vn vn { get; set; }
    }
}
