using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class budget_item
    {
        public string cost_cat_id { get; set; }
        public System.DateTime date_budget_created { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_seasonal_end { get; set; }
        public Nullable<System.DateTime> date_seasonal_start { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public string description { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string ls_id { get; set; }
        public decimal month_exp { get; set; }
        public decimal month_inc { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string pr_id { get; set; }
        public string source { get; set; }
        public decimal yearly_factor { get; set; }
        public string ac_id { get; set; }
        public string bl_id { get; set; }
        public string budget_id { get; set; }
        public int budget_item_id { get; set; }
        public virtual ac ac { get; set; }
        public virtual bl bl { get; set; }
        public virtual budget budget { get; set; }
        public virtual cost_cat cost_cat { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual l l { get; set; }
        public virtual Property property { get; set; }
    }
}
