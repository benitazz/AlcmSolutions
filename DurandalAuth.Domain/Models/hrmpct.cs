using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class hrmpct
    {
        public string ac_id { get; set; }
        public Nullable<int> activity_log_id { get; set; }
        public decimal area_chargable { get; set; }
        public decimal area_comn { get; set; }
        public decimal area_comn_nocup { get; set; }
        public decimal area_comn_ocup { get; set; }
        public decimal area_comn_rm { get; set; }
        public decimal area_comn_serv { get; set; }
        public decimal area_rm { get; set; }
        public string bl_id { get; set; }
        public short confirmed { get; set; }
        public decimal cost { get; set; }
        public Nullable<System.DateTime> date_created { get; set; }
        public Nullable<System.DateTime> date_deleted { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public short day_part { get; set; }
        public string del_user_name { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string em_id { get; set; }
        public string fl_id { get; set; }
        public string from_bl_id { get; set; }
        public string from_fl_id { get; set; }
        public string from_rm_id { get; set; }
        public Nullable<int> mo_id { get; set; }
        public string org_id { get; set; }
        public Nullable<int> parent_pct_id { get; set; }
        public Nullable<decimal> pct_space { get; set; }
        public Nullable<decimal> pct_time { get; set; }
        public Nullable<short> primary_em { get; set; }
        public Nullable<short> primary_rm { get; set; }
        public string prorate { get; set; }
        public string resources { get; set; }
        public string rm_cat { get; set; }
        public string rm_id { get; set; }
        public string rm_type { get; set; }
        public short status { get; set; }
        public string user_name { get; set; }
        public Nullable<int> visitor_id { get; set; }
        public int pct_id { get; set; }
    }
}
