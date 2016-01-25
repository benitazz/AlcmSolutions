using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class portfolio_scenario
    {
        public portfolio_scenario()
        {
            this.gps = new List<gp>();
        }

        public string description { get; set; }
        public string portfolio_scenario_id { get; set; }
        public virtual ICollection<gp> gps { get; set; }
    }
}
