using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class repairty
    {
        public repairty()
        {
            this.activity_log = new List<activity_log>();
            this.wrs = new List<wr>();
        }

        public string description { get; set; }
        public string repair_type { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<wr> wrs { get; set; }
    }
}
