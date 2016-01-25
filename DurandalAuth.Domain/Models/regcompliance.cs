using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class regcompliance
    {
        public regcompliance()
        {
            this.activity_log = new List<activity_log>();
        }

        public string bl_id { get; set; }
        public string comp_action { get; set; }
        public string comp_status_orig { get; set; }
        public string comp_status_res { get; set; }
        public string contact_id { get; set; }
        public System.DateTime date_logged { get; set; }
        public Nullable<System.DateTime> date_resolved { get; set; }
        public string description { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string fl_id { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string pr_id { get; set; }
        public string regulation { get; set; }
        public string rm_id { get; set; }
        public int regcomp_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual bl bl { get; set; }
        public virtual Contact contact { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Property property { get; set; }
        public virtual regulation regulation1 { get; set; }
        public virtual Rm rm { get; set; }
    }
}
