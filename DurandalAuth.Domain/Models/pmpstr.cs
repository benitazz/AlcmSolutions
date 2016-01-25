using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pmpstr
    {
        public decimal hours_req { get; set; }
        public string pmp_id { get; set; }
        public short pmps_id { get; set; }
        public string tr_id { get; set; }
        public virtual pmp pmp { get; set; }
        public virtual pmp1 pmp1 { get; set; }
        public virtual tr tr { get; set; }
    }
}
