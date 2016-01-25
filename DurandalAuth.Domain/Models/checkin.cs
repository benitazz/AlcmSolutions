using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class checkin
    {
        public string asset_type { get; set; }
        public System.DateTime date_received { get; set; }
        public string serial_number { get; set; }
        public int po_id { get; set; }
        public int po_line_id { get; set; }
        public string ta_id { get; set; }
        public virtual po po { get; set; }
        public virtual po_line po_line { get; set; }
    }
}
