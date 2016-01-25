using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pmgen
    {
        public string bl_id { get; set; }
        public System.DateTime date_start { get; set; }
        public string fl_id { get; set; }
        public short gen_new_pmsd { get; set; }
        public string group_param { get; set; }
        public string pm_group { get; set; }
        public string pm_type { get; set; }
        public string recurring_rule { get; set; }
        public string site_id { get; set; }
        public string tr_id { get; set; }
        public short use_pm_group { get; set; }
        public int pmgen_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual pmgp pmgp { get; set; }
        public virtual site site { get; set; }
        public virtual tr tr { get; set; }
    }
}
