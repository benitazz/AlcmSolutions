using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class bill_archive
    {
        public string bill_type_id { get; set; }
        public string bl_id { get; set; }
        public decimal cost_kwh { get; set; }
        public decimal cost_mmbtu { get; set; }
        public Nullable<int> cost_tran_sched_id { get; set; }
        public decimal count_lines { get; set; }
        public Nullable<System.DateTime> date_approved { get; set; }
        public System.DateTime date_due { get; set; }
        public Nullable<System.DateTime> date_exported { get; set; }
        public Nullable<System.DateTime> date_issued { get; set; }
        public Nullable<System.DateTime> date_paid { get; set; }
        public Nullable<System.DateTime> date_service_end { get; set; }
        public Nullable<System.DateTime> date_service_start { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public decimal expense_variance_avg { get; set; }
        public decimal expense_variance_month { get; set; }
        public decimal expense_variance_year { get; set; }
        public decimal income_variance_avg { get; set; }
        public decimal income_variance_month { get; set; }
        public decimal income_variance_year { get; set; }
        public decimal qty_energy { get; set; }
        public decimal qty_kwh { get; set; }
        public decimal qty_power { get; set; }
        public decimal qty_volume { get; set; }
        public string site_id { get; set; }
        public string status { get; set; }
        public string time_period { get; set; }
        public string vn_ac_id { get; set; }
        public decimal amount_expense { get; set; }
        public decimal amount_income { get; set; }
        public string vn_id { get; set; }
        public string bill_id { get; set; }
        public virtual energy_time_period energy_time_period { get; set; }
    }
}
