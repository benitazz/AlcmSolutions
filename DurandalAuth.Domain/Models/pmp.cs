using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pmp
    {
        public pmp()
        {
            this.activity_log = new List<activity_log>();
            this.helpdesk_sla_request = new List<helpdesk_sla_request>();
            this.pmps = new List<pmp1>();
            this.pmpspts = new List<pmpspt>();
            this.pmpstrs = new List<pmpstr>();
            this.pmpstts = new List<pmpstt>();
            this.pms = new List<Pm>();
            this.wrs = new List<wr>();
        }

        public string ac_id { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string eq_std { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string pmp_ids_to_suppress { get; set; }
        public string pmp_type { get; set; }
        public string tr_id { get; set; }
        public string units { get; set; }
        public Nullable<decimal> units_hour { get; set; }
        public string pmp_id { get; set; }
        public virtual ac ac { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual eqstd eqstd { get; set; }
        public virtual ICollection<helpdesk_sla_request> helpdesk_sla_request { get; set; }
        public virtual tr tr { get; set; }
        public virtual ICollection<pmp1> pmps { get; set; }
        public virtual ICollection<pmpspt> pmpspts { get; set; }
        public virtual ICollection<pmpstr> pmpstrs { get; set; }
        public virtual ICollection<pmpstt> pmpstts { get; set; }
        public virtual ICollection<Pm> pms { get; set; }
        public virtual ICollection<wr> wrs { get; set; }
    }
}
