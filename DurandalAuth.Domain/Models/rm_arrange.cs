using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rm_arrange
    {
        public rm_arrange()
        {
            this.reserve_rm = new List<reserve_rm>();
            this.rm_resource_std = new List<rm_resource_std>();
        }

        public string ac_id { get; set; }
        public short action_approval_expired { get; set; }
        public short announce_days { get; set; }
        public System.DateTime announce_time { get; set; }
        public short approval { get; set; }
        public short approve_days { get; set; }
        public string available_for_group { get; set; }
        public short cost_late_cancel_pct { get; set; }
        public decimal cost_per_unit { get; set; }
        public decimal cost_per_unit_ext { get; set; }
        public short cost_unit { get; set; }
        public System.DateTime day_end { get; set; }
        public System.DateTime day_start { get; set; }
        public string doc_image { get; set; }
        public short external_allowed { get; set; }
        public string group_name { get; set; }
        public short is_default { get; set; }
        public short max_capacity { get; set; }
        public short max_days_ahead { get; set; }
        public short min_required { get; set; }
        public short post_block { get; set; }
        public short pre_block { get; set; }
        public string res_stds_not_allowed { get; set; }
        public short reservable { get; set; }
        public short cancel_days { get; set; }
        public System.DateTime cancel_time { get; set; }
        public string user_approval_expired { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string rm_id { get; set; }
        public string config_id { get; set; }
        public string rm_arrange_type_id { get; set; }
        public virtual ac ac { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual afm_groups afm_groups1 { get; set; }
        public virtual afm_users afm_users { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual ICollection<reserve_rm> reserve_rm { get; set; }
        public virtual Rm rm { get; set; }
        public virtual rm_config rm_config { get; set; }
        public virtual rm_arrange_type rm_arrange_type { get; set; }
        public virtual ICollection<rm_resource_std> rm_resource_std { get; set; }
    }
}
