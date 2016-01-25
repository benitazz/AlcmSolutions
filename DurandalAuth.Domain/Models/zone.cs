using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class zone
    {
        public zone()
        {
            this.bas_measurement_scope = new List<bas_measurement_scope>();
        }

        public string description { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public short highlight_outline { get; set; }
        public string hpattern_acad { get; set; }
        public string layer_name { get; set; }
        public string system_id { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string zone_id { get; set; }
        public virtual ICollection<bas_measurement_scope> bas_measurement_scope { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual system_bl system_bl { get; set; }
    }
}
