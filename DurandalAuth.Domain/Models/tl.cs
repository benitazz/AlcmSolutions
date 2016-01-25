using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class tl
    {
        public tl()
        {
            this.wrtls = new List<wrtl>();
        }

        public string bl_id { get; set; }
        public Nullable<System.DateTime> date_purchased { get; set; }
        public string fl_id { get; set; }
        public string location { get; set; }
        public string rm_id { get; set; }
        public string status { get; set; }
        public decimal std_hours_avail { get; set; }
        public string tool_type { get; set; }
        public string tool_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Rm rm { get; set; }
        public virtual tt tt { get; set; }
        public virtual ICollection<wrtl> wrtls { get; set; }
    }
}
