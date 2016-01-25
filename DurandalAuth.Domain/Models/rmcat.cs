using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rmcat
    {
        public rmcat()
        {
            this.rms = new List<Rm>();
            this.rmpcts = new List<rmpct>();
            this.rmpctmob_sync = new List<rmpctmob_sync>();
            this.rmtypes = new List<rmtype>();
            this.surveyrm_sync = new List<surveyrm_sync>();
        }

        public Nullable<decimal> area { get; set; }
        public Nullable<decimal> area_avg { get; set; }
        public decimal cost_sqft { get; set; }
        public decimal count_em { get; set; }
        public string description { get; set; }
        public string hpattern { get; set; }
        public string hpattern_acad { get; set; }
        public Nullable<short> occupiable { get; set; }
        public string supercat { get; set; }
        public Nullable<int> tot_count { get; set; }
        public string used_in_calcs { get; set; }
        public string rm_cat { get; set; }
        public virtual ICollection<Rm> rms { get; set; }
        public virtual ICollection<rmpct> rmpcts { get; set; }
        public virtual ICollection<rmpctmob_sync> rmpctmob_sync { get; set; }
        public virtual ICollection<rmtype> rmtypes { get; set; }
        public virtual ICollection<surveyrm_sync> surveyrm_sync { get; set; }
    }
}
