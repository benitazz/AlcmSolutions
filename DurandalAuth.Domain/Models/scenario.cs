using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class scenario
    {
        public scenario()
        {
            this.projscns = new List<projscn>();
        }

        public string description { get; set; }
        public string scenario_type { get; set; }
        public string proj_scenario_id { get; set; }
        public virtual ICollection<projscn> projscns { get; set; }
    }
}
