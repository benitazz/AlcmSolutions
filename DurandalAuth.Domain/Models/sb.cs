using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class sb
    {
        public sb()
        {
            this.sb_items = new List<sb_items>();
            this.sbaffins = new List<sbaffin>();
            this.sbperiods = new List<sbperiod>();
        }

        public short alloc_period { get; set; }
        public int alloc_score { get; set; }
        public int alloc_score_ext { get; set; }
        public string sb_as { get; set; }
        public string sb_desc { get; set; }
        public string sb_from { get; set; }
        public string sb_level { get; set; }
        public string sb_name { get; set; }
        public virtual ICollection<sb_items> sb_items { get; set; }
        public virtual ICollection<sbaffin> sbaffins { get; set; }
        public virtual ICollection<sbperiod> sbperiods { get; set; }
    }
}
