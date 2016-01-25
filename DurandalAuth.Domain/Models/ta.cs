using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ta
    {
        public ta()
        {
            this.mo_ta = new List<mo_ta>();
            this.ta_compinvtrial = new List<ta_compinvtrial>();
            this.ta_dep = new List<ta_dep>();
            this.ta_trial = new List<ta_trial>();
        }

        public string bl_id { get; set; }
        public string condition { get; set; }
        public string curr_bl_id { get; set; }
        public string curr_fl_id { get; set; }
        public string curr_rm_id { get; set; }
        public string curr_site_id { get; set; }
        public Nullable<System.DateTime> date_delivery { get; set; }
        public Nullable<System.DateTime> date_return { get; set; }
        public Nullable<System.DateTime> date_sale { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string em_id { get; set; }
        public string fl_id { get; set; }
        public string fn_std { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public Nullable<decimal> lat { get; set; }
        public string layer_name { get; set; }
        public Nullable<decimal> lon { get; set; }
        public Nullable<int> po_id { get; set; }
        public Nullable<int> po_line_id { get; set; }
        public string policy_id { get; set; }
        public string property_type { get; set; }
        public string rf_id { get; set; }
        public string rm_id { get; set; }
        public string serial_number { get; set; }
        public string status { get; set; }
        public string survey_id { get; set; }
        public string ta_lease_id { get; set; }
        public string use1 { get; set; }
        public decimal value_original { get; set; }
        public decimal value_replace { get; set; }
        public decimal value_salvage { get; set; }
        public string warranty_id { get; set; }
        public string ta_id { get; set; }
        public virtual bar_code_list bar_code_list { get; set; }
        public virtual bl bl { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Em em { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Fl fl1 { get; set; }
        public virtual fnstd fnstd { get; set; }
        public virtual ICollection<mo_ta> mo_ta { get; set; }
        public virtual po po { get; set; }
        public virtual po_line po_line { get; set; }
        public virtual policy policy { get; set; }
        public virtual property_type property_type1 { get; set; }
        public virtual Rm rm { get; set; }
        public virtual Rm rm1 { get; set; }
        public virtual survey survey { get; set; }
        public virtual ICollection<ta_compinvtrial> ta_compinvtrial { get; set; }
        public virtual ICollection<ta_dep> ta_dep { get; set; }
        public virtual ta_lease ta_lease { get; set; }
        public virtual ICollection<ta_trial> ta_trial { get; set; }
        public virtual warranty warranty { get; set; }
    }
}
