using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class op
    {
        public op()
        {
            this.activity_log = new List<activity_log>();
        }

        public Nullable<decimal> area { get; set; }
        public string comments { get; set; }
        public decimal cost_est { get; set; }
        public Nullable<System.DateTime> date_exercised { get; set; }
        public Nullable<System.DateTime> date_exercising_applicable { get; set; }
        public Nullable<System.DateTime> date_option { get; set; }
        public Nullable<System.DateTime> date_option_introduced { get; set; }
        public Nullable<System.DateTime> date_review { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public short dates_match_lease { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string exercised_by { get; set; }
        public string image_doc1 { get; set; }
        public string image_doc2 { get; set; }
        public string op_type { get; set; }
        public string who_can_exercise { get; set; }
        public string ls_id { get; set; }
        public string op_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual Em em { get; set; }
        public virtual l l { get; set; }
    }
}
