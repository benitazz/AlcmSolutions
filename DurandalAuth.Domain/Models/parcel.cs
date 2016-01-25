using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class parcel
    {
        public parcel()
        {
            this.activity_log = new List<activity_log>();
            this.cost_tran_recur = new List<cost_tran_recur>();
            this.cost_tran_sched = new List<cost_tran_sched>();
        }

        public decimal area_cad { get; set; }
        public string block { get; set; }
        public string description { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public string image_file { get; set; }
        public Nullable<decimal> lat { get; set; }
        public string location { get; set; }
        public Nullable<decimal> lon { get; set; }
        public string lot { get; set; }
        public string name { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string pr_id { get; set; }
        public string parcel_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<cost_tran_recur> cost_tran_recur { get; set; }
        public virtual ICollection<cost_tran_sched> cost_tran_sched { get; set; }
        public virtual Property property { get; set; }
    }
}
