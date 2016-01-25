using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class pa
    {
        public pa()
        {
            this.cost_tran_recur = new List<cost_tran_recur>();
            this.cost_tran_sched = new List<cost_tran_sched>();
            this.pa_dep = new List<pa_dep>();
        }

        public string condition { get; set; }
        public Nullable<decimal> cost { get; set; }
        public decimal cost_selling { get; set; }
        public Nullable<System.DateTime> date_received { get; set; }
        public Nullable<System.DateTime> date_sold { get; set; }
        public string image_file { get; set; }
        public Nullable<System.DateTime> last_date { get; set; }
        public string ls_id { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string property_type { get; set; }
        public string status { get; set; }
        public Nullable<decimal> value_book { get; set; }
        public Nullable<decimal> value_mkt { get; set; }
        public decimal value_replace { get; set; }
        public decimal value_salvage { get; set; }
        public Nullable<decimal> value_tax { get; set; }
        public string pr_id { get; set; }
        public string pa_name { get; set; }
        public virtual ICollection<cost_tran_recur> cost_tran_recur { get; set; }
        public virtual ICollection<cost_tran_sched> cost_tran_sched { get; set; }
        public virtual l l { get; set; }
        public virtual ICollection<pa_dep> pa_dep { get; set; }
        public virtual Property property { get; set; }
        public virtual property_type property_type1 { get; set; }
    }
}
