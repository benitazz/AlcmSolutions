using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pmressum
    {
        public decimal hours_or_quantity { get; set; }
        public System.DateTime date_todo { get; set; }
        public string resource_type { get; set; }
        public string resource_id { get; set; }
    }
}
