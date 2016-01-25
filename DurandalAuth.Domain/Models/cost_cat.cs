using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cost_cat
    {
        public cost_cat()
        {
            this.activity_log = new List<activity_log>();
            this.bill_type = new List<bill_type>();
            this.budget_item = new List<budget_item>();
            this.cost_tran = new List<cost_tran>();
            this.cost_tran_recur = new List<cost_tran_recur>();
            this.cost_tran_sched = new List<cost_tran_sched>();
            this.ls_chrgbck_agree = new List<ls_chrgbck_agree>();
            this.vat_percent = new List<vat_percent>();
        }

        public string cost_class_id { get; set; }
        public string cost_type { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string rollup_prorate { get; set; }
        public string cost_cat_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<bill_type> bill_type { get; set; }
        public virtual ICollection<budget_item> budget_item { get; set; }
        public virtual cost_class cost_class { get; set; }
        public virtual ICollection<cost_tran> cost_tran { get; set; }
        public virtual ICollection<cost_tran_recur> cost_tran_recur { get; set; }
        public virtual ICollection<cost_tran_sched> cost_tran_sched { get; set; }
        public virtual ICollection<ls_chrgbck_agree> ls_chrgbck_agree { get; set; }
        public virtual ICollection<vat_percent> vat_percent { get; set; }
    }
}
