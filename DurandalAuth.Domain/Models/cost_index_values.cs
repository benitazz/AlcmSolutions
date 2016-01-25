using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cost_index_values
    {
        public decimal index_value { get; set; }
        public string cost_index_id { get; set; }
        public System.DateTime date_index_value { get; set; }
        public virtual cost_index cost_index { get; set; }
    }
}
