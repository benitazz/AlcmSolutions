using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pt
    {
        public pt()
        {
            this.eps = new List<ep>();
            this.it = new List<it>();
            this.pmpspts = new List<pmpspt>();
            this.pvs = new List<pv>();
            this.wrpts = new List<wrpt>();
            this.pt1 = new List<pt>();
            this.pts = new List<pt>();
        }

        public string acc_prop_type { get; set; }
        public string bl_id { get; set; }
        public string cad_file_name { get; set; }
        public string @class { get; set; }
        public decimal cost_abc { get; set; }
        public decimal cost_total { get; set; }
        public decimal cost_unit_avg { get; set; }
        public decimal cost_unit_last { get; set; }
        public decimal cost_unit_std { get; set; }
        public Nullable<System.DateTime> date_of_last_cnt { get; set; }
        public Nullable<System.DateTime> date_of_last_use { get; set; }
        public string description { get; set; }
        public string fl_id { get; set; }
        public string model_no { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public decimal qty_calc_wk_use { get; set; }
        public decimal qty_calc_yr_use { get; set; }
        public decimal qty_last_purch { get; set; }
        public decimal qty_min_hand { get; set; }
        public short qty_of_vendors { get; set; }
        public decimal qty_on_hand { get; set; }
        public decimal qty_on_order { get; set; }
        public decimal qty_on_reserve { get; set; }
        public decimal qty_physical_count { get; set; }
        public decimal qty_std_order { get; set; }
        public decimal qty_to_date_yr_use { get; set; }
        public decimal qty_to_order { get; set; }
        public string rm_id { get; set; }
        public string stock_no { get; set; }
        public string storage { get; set; }
        public string units_issue { get; set; }
        public decimal units_ord_iss { get; set; }
        public string units_order { get; set; }
        public string part_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual ICollection<ep> eps { get; set; }
        public virtual Fl fl { get; set; }
        public virtual ICollection<it> it { get; set; }
        public virtual ICollection<pmpspt> pmpspts { get; set; }
        public virtual Rm rm { get; set; }
        public virtual ICollection<pv> pvs { get; set; }
        public virtual ICollection<wrpt> wrpts { get; set; }
        public virtual ICollection<pt> pt1 { get; set; }
        public virtual ICollection<pt> pts { get; set; }
    }
}
