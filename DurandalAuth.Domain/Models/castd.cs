using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class castd
    {
        public castd()
        {
            this.afm_tccn = new List<afm_tccn>();
            this.cas = new List<ca>();
            this.jks = new List<jk>();
            this.jkstds = new List<jkstd>();
        }

        public string ca_type { get; set; }
        public short color { get; set; }
        public string description { get; set; }
        public decimal diameter { get; set; }
        public decimal diameter_core { get; set; }
        public short is_multiplexing { get; set; }
        public string layer_name { get; set; }
        public decimal length_max { get; set; }
        public string mfr { get; set; }
        public short num_pairs { get; set; }
        public string num_serial { get; set; }
        public string tc_cabling_level { get; set; }
        public string tc_contained_tbls { get; set; }
        public string tc_level { get; set; }
        public short tc_npositions { get; set; }
        public string tc_service { get; set; }
        public decimal unit_cost { get; set; }
        public decimal unit_weight { get; set; }
        public string vn_id { get; set; }
        public decimal bandwidth { get; set; }
        public string ca_std { get; set; }
        public virtual ICollection<afm_tccn> afm_tccn { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual ICollection<ca> cas { get; set; }
        public virtual catype catype { get; set; }
        public virtual vn vn { get; set; }
        public virtual ICollection<jk> jks { get; set; }
        public virtual ICollection<jkstd> jkstds { get; set; }
    }
}
