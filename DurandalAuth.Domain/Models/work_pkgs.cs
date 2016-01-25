using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class work_pkgs
    {
        public work_pkgs()
        {
            this.activity_log = new List<activity_log>();
            this.activity_log_trans = new List<activity_log_trans>();
            this.invoices = new List<invoice>();
            this.proj_forecast_item = new List<proj_forecast_item>();
            this.work_pkg_bids = new List<work_pkg_bids>();
        }

        public short actions_locked { get; set; }
        public string apprv_mgr1 { get; set; }
        public string apprv_mgr1_status { get; set; }
        public string cx_docs_approved_by { get; set; }
        public string cx_docs_provided_by { get; set; }
        public string cx_docs_verified_by { get; set; }
        public Nullable<System.DateTime> date_act_end { get; set; }
        public Nullable<System.DateTime> date_act_start { get; set; }
        public Nullable<System.DateTime> date_app_mgr1 { get; set; }
        public Nullable<System.DateTime> date_cx_docs_approved { get; set; }
        public Nullable<System.DateTime> date_cx_docs_provided { get; set; }
        public Nullable<System.DateTime> date_cx_docs_verified { get; set; }
        public Nullable<System.DateTime> date_est_end { get; set; }
        public Nullable<System.DateTime> date_est_start { get; set; }
        public short days_per_week { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string doc_acts_xfer { get; set; }
        public short pct_complete { get; set; }
        public short pct_complete_cx_docs { get; set; }
        public string proj_phase { get; set; }
        public string status { get; set; }
        public string summary { get; set; }
        public string wbs_id { get; set; }
        public string project_id { get; set; }
        public string work_pkg_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<activity_log_trans> activity_log_trans { get; set; }
        public virtual Em em { get; set; }
        public virtual ICollection<invoice> invoices { get; set; }
        public virtual ICollection<proj_forecast_item> proj_forecast_item { get; set; }
        public virtual project project { get; set; }
        public virtual projphase projphase { get; set; }
        public virtual vn vn { get; set; }
        public virtual ICollection<work_pkg_bids> work_pkg_bids { get; set; }
    }
}
