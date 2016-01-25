using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pmpstt
    {
        public decimal hours_req { get; set; }
        public string pmp_id { get; set; }
        public short pmps_id { get; set; }
        public string tool_type { get; set; }
        public virtual pmp pmp { get; set; }
        public virtual pmp1 pmp1 { get; set; }
        public virtual tt tt { get; set; }
    }
}
