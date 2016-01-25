using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class eqprph
    {
        public string description { get; set; }
        public string eq_id { get; set; }
        public string eq_std { get; set; }
        public string num_serial { get; set; }
        public string prph_type { get; set; }
        public int auto_number { get; set; }
        public virtual eq eq { get; set; }
        public virtual eqstd eqstd { get; set; }
    }
}
