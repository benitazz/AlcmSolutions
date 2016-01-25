using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class warranty
    {
        public warranty()
        {
            this.eqs = new List<eq>();
            this.fnstds = new List<fnstd>();
            this.tas = new List<ta>();
        }

        public string contact_info { get; set; }
        public Nullable<System.DateTime> date_expiration { get; set; }
        public string description { get; set; }
        public string doc_warranty { get; set; }
        public string image_warranty { get; set; }
        public string meter_units { get; set; }
        public decimal metered_exp { get; set; }
        public string war_vendor { get; set; }
        public string warranty_id { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual ICollection<fnstd> fnstds { get; set; }
        public virtual ICollection<ta> tas { get; set; }
    }
}
