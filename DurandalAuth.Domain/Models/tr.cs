using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class tr
    {
        public tr()
        {
            this.activity_log = new List<activity_log>();
            this.cfs = new List<cf>();
            this.pmgens = new List<pmgen>();
            this.pmps = new List<pmp>();
            this.pmpstrs = new List<pmpstr>();
            this.resource_std = new List<resource_std>();
            this.rm_arrange_type = new List<rm_arrange_type>();
            this.woes = new List<wo>();
            this.wrs = new List<wr>();
            this.wrcfs = new List<wrcf>();
            this.wrtrs = new List<wrtr>();
        }

        public string description { get; set; }
        public string issue_work_in_format { get; set; }
        public string issue_work_to { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public decimal rate_double { get; set; }
        public decimal rate_hourly { get; set; }
        public decimal rate_over { get; set; }
        public decimal std_hours_avail { get; set; }
        public short wr_from_reserve { get; set; }
        public string tr_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<cf> cfs { get; set; }
        public virtual pmforecast_trm pmforecast_trm { get; set; }
        public virtual ICollection<pmgen> pmgens { get; set; }
        public virtual ICollection<pmp> pmps { get; set; }
        public virtual ICollection<pmpstr> pmpstrs { get; set; }
        public virtual ICollection<resource_std> resource_std { get; set; }
        public virtual ICollection<rm_arrange_type> rm_arrange_type { get; set; }
        public virtual ICollection<wo> woes { get; set; }
        public virtual ICollection<wr> wrs { get; set; }
        public virtual ICollection<wrcf> wrcfs { get; set; }
        public virtual ICollection<wrtr> wrtrs { get; set; }
    }
}
