using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ot
    {
        public string bl_id { get; set; }
        public string comments { get; set; }
        public decimal cost_purchase { get; set; }
        public decimal cost_selling { get; set; }
        public Nullable<System.DateTime> date_purchase { get; set; }
        public Nullable<System.DateTime> date_sold { get; set; }
        public string description { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string pr_id { get; set; }
        public string status { get; set; }
        public int ot_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Property property { get; set; }
    }
}
