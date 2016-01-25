using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rm_resource_std
    {
        public string description { get; set; }
        public string eq_id { get; set; }
        public string resource_std { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public string config_id { get; set; }
        public string rm_arrange_type_id { get; set; }
        public string fixed_resource_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual eq eq { get; set; }
        public virtual Fl fl { get; set; }
        public virtual resource_std resource_std1 { get; set; }
        public virtual Rm rm { get; set; }
        public virtual rm_arrange rm_arrange { get; set; }
        public virtual rm_config rm_config { get; set; }
    }
}
