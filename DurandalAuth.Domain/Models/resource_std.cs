using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class resource_std
    {
        public resource_std()
        {
            this.resources = new List<resource>();
            this.rm_resource_std = new List<rm_resource_std>();
        }

        public string description { get; set; }
        public string resource_name { get; set; }
        public string resource_name_01 { get; set; }
        public string resource_name_02 { get; set; }
        public string resource_name_03 { get; set; }
        public string resource_name_ch { get; set; }
        public string resource_name_de { get; set; }
        public string resource_name_es { get; set; }
        public string resource_name_fr { get; set; }
        public string resource_name_it { get; set; }
        public string resource_name_jp { get; set; }
        public string resource_name_ko { get; set; }
        public string resource_name_nl { get; set; }
        public string resource_name_no { get; set; }
        public string resource_name_zh { get; set; }
        public string resource_nature { get; set; }
        public string tr_id { get; set; }
        public string vn_id { get; set; }
        public string resource_std1 { get; set; }
        public virtual tr tr { get; set; }
        public virtual vn vn { get; set; }
        public virtual ICollection<resource> resources { get; set; }
        public virtual ICollection<rm_resource_std> rm_resource_std { get; set; }
    }
}
