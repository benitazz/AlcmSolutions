using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class commsub
    {
        public string comm_type { get; set; }
        public short is_active { get; set; }
        public string project_id { get; set; }
        public string project_type { get; set; }
        public string subscriber { get; set; }
        public string subscriber_type { get; set; }
        public int auto_number { get; set; }
        public virtual commtype commtype { get; set; }
        public virtual project project { get; set; }
        public virtual projecttype projecttype { get; set; }
    }
}
