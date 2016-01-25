using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class bas_measurement_scope
    {
        public string bl_id { get; set; }
        public int data_point_id { get; set; }
        public string eq_id { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public string site_id { get; set; }
        public string zone_id { get; set; }
        public int measurement_scope_id { get; set; }
        public virtual bas_data_point bas_data_point { get; set; }
        public virtual bl bl { get; set; }
        public virtual eq eq { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Rm rm { get; set; }
        public virtual site site { get; set; }
        public virtual zone zone { get; set; }
    }
}
