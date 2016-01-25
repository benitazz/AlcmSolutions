using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class port
    {
        public string bl_id { get; set; }
        public string description { get; set; }
        public string fl_id { get; set; }
        public string port_std { get; set; }
        public string rack_id { get; set; }
        public string rm_id { get; set; }
        public string tc_level { get; set; }
        public string tc_use_status { get; set; }
        public string port_id { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual portstd portstd { get; set; }
        public virtual rack rack { get; set; }
        public virtual Rm rm { get; set; }
    }
}
