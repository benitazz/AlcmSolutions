using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class csi
    {
        public csi()
        {
            this.activity_log = new List<activity_log>();
            this.eqs = new List<eq>();
            this.eqstds = new List<eqstd>();
        }

        public string description { get; set; }
        public string hierarchy_ids { get; set; }
        public string csi_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual ICollection<eqstd> eqstds { get; set; }
    }
}
