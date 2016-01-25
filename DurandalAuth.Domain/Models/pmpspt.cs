using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pmpspt
    {
        public decimal qty_required { get; set; }
        public string pmp_id { get; set; }
        public short pmps_id { get; set; }
        public string part_id { get; set; }
        public virtual pmp pmp { get; set; }
        public virtual pmp1 pmp1 { get; set; }
        public virtual pt pt { get; set; }
    }
}
