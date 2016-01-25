using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gp
    {
        public decimal area { get; set; }
        public decimal area_chargable { get; set; }
        public decimal area_comn { get; set; }
        public decimal area_comn_gp { get; set; }
        public decimal area_comn_serv { get; set; }
        public decimal area_manual { get; set; }
        public string bl_id { get; set; }
        public decimal cost { get; set; }
        public int count_em { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public string description { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string fl_id { get; set; }
        public string gp_function { get; set; }
        public string gp_num { get; set; }
        public string gp_std { get; set; }
        public string head { get; set; }
        public Nullable<short> is_available { get; set; }
        public string layer_name { get; set; }
        public string ls_id { get; set; }
        public string name { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public decimal pct_floor { get; set; }
        public string planning_bu_id { get; set; }
        public string portfolio_scenario_id { get; set; }
        public string prorate { get; set; }
        public int gp_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual bu bu { get; set; }
        public virtual dp dp { get; set; }
        public virtual dv dv { get; set; }
        public virtual Fl fl { get; set; }
        public virtual gpstd gpstd { get; set; }
        public virtual l l { get; set; }
        public virtual portfolio_scenario portfolio_scenario { get; set; }
    }
}
