using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cost_tran
    {
        public cost_tran()
        {
            this.ls_cam_rec_report = new List<ls_cam_rec_report>();
        }

        public Nullable<int> cost_tran_recur_id { get; set; }
        public string ctry_id { get; set; }
        public string currency_budget { get; set; }
        public string currency_payment { get; set; }
        public Nullable<System.DateTime> date_assessed { get; set; }
        public System.DateTime date_due { get; set; }
        public Nullable<System.DateTime> date_paid { get; set; }
        public Nullable<System.DateTime> date_tax_late1 { get; set; }
        public Nullable<System.DateTime> date_tax_late2 { get; set; }
        public Nullable<System.DateTime> date_tax_late3 { get; set; }
        public System.DateTime date_trans_created { get; set; }
        public Nullable<System.DateTime> date_used_for_mc_budget { get; set; }
        public Nullable<System.DateTime> date_used_for_mc_payment { get; set; }
        public string description { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public decimal exchange_rate_budget { get; set; }
        public decimal exchange_rate_override { get; set; }
        public decimal exchange_rate_payment { get; set; }
        public Nullable<int> invoice_id { get; set; }
        public string ls_id { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string pa_name { get; set; }
        public string parcel_id { get; set; }
        public string pr_id { get; set; }
        public string status { get; set; }
        public string tax_authority_contact { get; set; }
        public string tax_bill_num { get; set; }
        public decimal tax_clr { get; set; }
        public Nullable<decimal> tax_milage_rate { get; set; }
        public decimal tax_period_in_months { get; set; }
        public string tax_type { get; set; }
        public decimal tax_value_assessed { get; set; }
        public decimal vat_amount_override { get; set; }
        public decimal vat_percent_override { get; set; }
        public decimal vat_percent_value { get; set; }
        public string ac_id { get; set; }
        public Nullable<int> activity_log_id { get; set; }
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
        public decimal amount_tax_late1 { get; set; }
        public decimal amount_tax_late2 { get; set; }
        public decimal amount_tax_late3 { get; set; }
        public string bl_id { get; set; }
        public string cam_cost { get; set; }
        public string chrgbck_status { get; set; }
        public string cost_cat_id { get; set; }
        public int cost_tran_id { get; set; }
        public virtual afm_currencies afm_currencies { get; set; }
        public virtual afm_currencies afm_currencies1 { get; set; }
        public virtual cost_cat cost_cat { get; set; }
        public virtual ctry ctry { get; set; }
        public virtual ICollection<ls_cam_rec_report> ls_cam_rec_report { get; set; }
    }
}
