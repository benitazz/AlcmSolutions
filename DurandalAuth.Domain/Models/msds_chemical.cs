using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class msds_chemical
    {
        public msds_chemical()
        {
            this.msds_constituent = new List<msds_constituent>();
        }

        public string ec_number { get; set; }
        public string icsc_number { get; set; }
        public string rtecs_number { get; set; }
        public string tier2 { get; set; }
        public string un_number { get; set; }
        public string alias { get; set; }
        public string cas_number { get; set; }
        public string chemical_id { get; set; }
        public virtual ICollection<msds_constituent> msds_constituent { get; set; }
    }
}
