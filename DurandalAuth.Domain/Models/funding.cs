using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class funding
    {
        public funding()
        {
            this.activity_log = new List<activity_log>();
            this.projfunds = new List<projfund>();
            this.projscns = new List<projscn>();
        }

        public decimal amt_total { get; set; }
        public Nullable<System.DateTime> date_avail { get; set; }
        public Nullable<System.DateTime> date_avail_end { get; set; }
        public string description { get; set; }
        public string fund_type { get; set; }
        public string program_id { get; set; }
        public string source_type { get; set; }
        public string fund_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual program program { get; set; }
        public virtual ICollection<projfund> projfunds { get; set; }
        public virtual ICollection<projscn> projscns { get; set; }
    }
}
