using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rm_config
    {
        public rm_config()
        {
            this.reserve_rm = new List<reserve_rm>();
            this.rm_arrange = new List<rm_arrange>();
            this.rm_resource_std = new List<rm_resource_std>();
        }

        public string config_name { get; set; }
        public string doc_layout { get; set; }
        public string excluded_config { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public string config_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual ICollection<reserve_rm> reserve_rm { get; set; }
        public virtual Rm rm { get; set; }
        public virtual ICollection<rm_arrange> rm_arrange { get; set; }
        public virtual ICollection<rm_resource_std> rm_resource_std { get; set; }
    }
}
