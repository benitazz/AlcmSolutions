using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_em_ppe_types
    {
        public string bl_id { get; set; }
        public Nullable<System.DateTime> date_delivered { get; set; }
        public string doc { get; set; }
        public string fl_id { get; set; }
        public Nullable<int> incident_id { get; set; }
        public string rm_id { get; set; }
        public string em_id { get; set; }
        public string ppe_type_id { get; set; }
        public System.DateTime date_use { get; set; }
        public virtual bl bl { get; set; }
        public virtual Em em { get; set; }
        public virtual Fl fl { get; set; }
        public virtual ehs_incidents ehs_incidents { get; set; }
        public virtual ehs_ppe_types ehs_ppe_types { get; set; }
        public virtual Rm rm { get; set; }
    }
}
