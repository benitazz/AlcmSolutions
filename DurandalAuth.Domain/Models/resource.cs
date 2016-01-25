using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class resource
    {
        public resource()
        {
            this.reserve_rs = new List<reserve_rs>();
        }

        public string ac_id { get; set; }
        public short action_approval_expired { get; set; }
        public short announce_days { get; set; }
        public System.DateTime announce_time { get; set; }
        public short approval { get; set; }
        public short approve_days { get; set; }
        public string available_for_group { get; set; }
        public string bl_id { get; set; }
        public short cancel_days { get; set; }
        public System.DateTime cancel_time { get; set; }
        public short cost_late_cancel_pct { get; set; }
        public decimal cost_per_unit { get; set; }
        public decimal cost_per_unit_ext { get; set; }
        public short cost_unit { get; set; }
        public System.DateTime day_end { get; set; }
        public System.DateTime day_start { get; set; }
        public short default_calculation { get; set; }
        public string doc_image { get; set; }
        public string eq_id { get; set; }
        public string group_name { get; set; }
        public short max_days_ahead { get; set; }
        public short post_block { get; set; }
        public short pre_block { get; set; }
        public short quantity { get; set; }
        public short reservable { get; set; }
        public string resource_name { get; set; }
        public string resource_std { get; set; }
        public string resource_type { get; set; }
        public short room_service { get; set; }
        public string room_service_group { get; set; }
        public string site_id { get; set; }
        public string user_approval_expired { get; set; }
        public string resource_id { get; set; }
        public virtual ac ac { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual afm_groups afm_groups1 { get; set; }
        public virtual afm_groups afm_groups2 { get; set; }
        public virtual afm_users afm_users { get; set; }
        public virtual bl bl { get; set; }
        public virtual eq eq { get; set; }
        public virtual ICollection<reserve_rs> reserve_rs { get; set; }
        public virtual resource_std resource_std1 { get; set; }
        public virtual site site { get; set; }
    }
}
