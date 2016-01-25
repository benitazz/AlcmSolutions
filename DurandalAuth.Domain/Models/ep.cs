using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ep
    {
        public decimal pt_life { get; set; }
        public decimal pt_use_yr { get; set; }
        public decimal quantity { get; set; }
        public string eq_id { get; set; }
        public string part_id { get; set; }
        public virtual eq eq { get; set; }
        public virtual pt pt { get; set; }
    }
}
