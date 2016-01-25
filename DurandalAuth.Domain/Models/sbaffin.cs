using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class sbaffin
    {
        public string bu_id_1 { get; set; }
        public string bu_id_2 { get; set; }
        public string dp_id_1 { get; set; }
        public string dp_id_2 { get; set; }
        public string dv_id_1 { get; set; }
        public string dv_id_2 { get; set; }
        public string fg_title_1 { get; set; }
        public string fg_title_2 { get; set; }
        public string sb_name { get; set; }
        public short affinity { get; set; }
        public int auto_number { get; set; }
        public virtual bu bu { get; set; }
        public virtual bu bu1 { get; set; }
        public virtual dp dp { get; set; }
        public virtual dp dp1 { get; set; }
        public virtual dv dv { get; set; }
        public virtual dv dv1 { get; set; }
        public virtual sb sb { get; set; }
    }
}
