using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class vat_percent
    {
        public short is_exception { get; set; }
        public decimal vat_percent_value { get; set; }
        public string cost_cat_id { get; set; }
        public string ctry_id { get; set; }
        public virtual cost_cat cost_cat { get; set; }
        public virtual ctry ctry { get; set; }
    }
}
