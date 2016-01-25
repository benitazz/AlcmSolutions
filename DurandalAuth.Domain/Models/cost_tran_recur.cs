using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cost_tran_recur
    {
        public cost_tran_recur()
        {
            this.cost_index_trans = new List<cost_index_trans>();
        }

        public string ac_id { get; set; }
        public decimal amount_expense { get; set; }
        public decimal amount_expense_base_budget { get; set; }
        public decimal amount_expense_base_payment { get; set; }
        public decimal amount_expense_total_payment { get; set; }
        public decimal amount_expense_vat_budget { get; set; }
        public decimal amount_expense_vat_payment { get; set; }
        public decimal amount_income { get; set; }
        public decimal amount_income_base_budget { get; set; }
        public decimal amount_income_base_payment { get; set; }
        public decimal amount_income_total_payment { get; set; }
        public decimal amount_income_vat_budget { get; set; }
        public decimal amount_income_vat_payment { get; set; }
        public string bl_id { get; set; }
        public string cam_cost { get; set; }
        public string cost_cat_id { get; set; }
        public string ctry_id { get; set; }
        public string currency_budget { get; set; }
        public string currency_payment { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_seasonal_end { get; set; }
        public Nullable<System.DateTime> date_seasonal_start { get; set; }
        public System.DateTime date_start { get; set; }
        public System.DateTime date_trans_created { get; set; }
        public Nullable<System.DateTime> date_used_for_mc_budget { get; set; }
        public Nullable<System.DateTime> date_used_for_mc_payment { get; set; }
        public string description { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public decimal exchange_rate_budget { get; set; }
        public decimal exchange_rate_override { get; set; }
        public decimal exchange_rate_payment { get; set; }
        public string ls_id { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string pa_name { get; set; }
        public string parcel_id { get; set; }
        public string period { get; set; }
        public short period_custom { get; set; }
        public string pr_id { get; set; }
        public short status_active { get; set; }
        public decimal vat_amount_override { get; set; }
        public decimal vat_percent_override { get; set; }
        public decimal vat_percent_value { get; set; }
        public decimal yearly_factor { get; set; }
        public int cost_tran_recur_id { get; set; }
        public virtual ac ac { get; set; }
        public virtual afm_currencies afm_currencies { get; set; }
        public virtual afm_currencies afm_currencies1 { get; set; }
        public virtual bl bl { get; set; }
        public virtual cost_cat cost_cat { get; set; }
        public virtual ICollection<cost_index_trans> cost_index_trans { get; set; }
        public virtual ctry ctry { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual l l { get; set; }
        public virtual pa pa { get; set; }
        public virtual parcel parcel { get; set; }
        public virtual Property property { get; set; }
    }
}
