using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class emstd
    {
        public emstd()
        {
            this.ems = new List<Em>();
            this.em_sync = new List<em_sync>();
            this.helpdesk_sla_request = new List<helpdesk_sla_request>();
            this.rmstds = new List<rmstd>();
        }

        public string grade { get; set; }
        public string hpattern { get; set; }
        public string hpattern_acad { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string status { get; set; }
        public decimal std_area { get; set; }
        public string tc_contained_tbls { get; set; }
        public int count_em { get; set; }
        public string description { get; set; }
        public string em_std { get; set; }
        public virtual ICollection<Em> ems { get; set; }
        public virtual ICollection<em_sync> em_sync { get; set; }
        public virtual ICollection<helpdesk_sla_request> helpdesk_sla_request { get; set; }
        public virtual ICollection<rmstd> rmstds { get; set; }
    }
}
