using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_cert_proj
    {
        public gb_cert_proj()
        {
            this.gb_cert_docs = new List<gb_cert_docs>();
            this.gb_cert_log = new List<gb_cert_log>();
            this.gb_cert_scores = new List<gb_cert_scores>();
        }

        public string certified_level { get; set; }
        public Nullable<System.DateTime> date_application { get; set; }
        public Nullable<System.DateTime> date_certified { get; set; }
        public Nullable<System.DateTime> date_closed { get; set; }
        public Nullable<System.DateTime> date_perf_end { get; set; }
        public Nullable<System.DateTime> date_perf_start { get; set; }
        public Nullable<System.DateTime> date_registered { get; set; }
        public string description { get; set; }
        public string description_area { get; set; }
        public string fl_id { get; set; }
        public string goal_level { get; set; }
        public string cert_num { get; set; }
        public short cert_part_num { get; set; }
        public string cert_status { get; set; }
        public string rm_id { get; set; }
        public decimal tot_annual_savings { get; set; }
        public decimal tot_capital_cost { get; set; }
        public decimal tot_final_score { get; set; }
        public decimal tot_payback_period { get; set; }
        public decimal tot_self_score { get; set; }
        public string bl_id { get; set; }
        public string cert_std { get; set; }
        public string project_name { get; set; }
        public virtual bl bl { get; set; }
        public virtual ICollection<gb_cert_docs> gb_cert_docs { get; set; }
        public virtual gb_cert_levels gb_cert_levels { get; set; }
        public virtual gb_cert_levels gb_cert_levels1 { get; set; }
        public virtual ICollection<gb_cert_log> gb_cert_log { get; set; }
        public virtual gb_cert_std gb_cert_std { get; set; }
        public virtual ICollection<gb_cert_scores> gb_cert_scores { get; set; }
    }
}
