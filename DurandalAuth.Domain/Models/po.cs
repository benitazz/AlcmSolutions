using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class po
    {
        public po()
        {
            this.activity_log = new List<activity_log>();
            this.checkins = new List<checkin>();
            this.eqs = new List<eq>();
            this.po_line = new List<po_line>();
            this.tas = new List<ta>();
        }

        public Nullable<System.DateTime> date_paid { get; set; }
        public Nullable<System.DateTime> date_received { get; set; }
        public Nullable<System.DateTime> date_request { get; set; }
        public Nullable<System.DateTime> date_sent { get; set; }
        public string em_id { get; set; }
        public decimal federal_tax { get; set; }
        public decimal shipping { get; set; }
        public decimal state_tax { get; set; }
        public string terms { get; set; }
        public string vn_id { get; set; }
        public int po_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<checkin> checkins { get; set; }
        public virtual Em em { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual ICollection<po_line> po_line { get; set; }
        public virtual vn vn { get; set; }
        public virtual ICollection<ta> tas { get; set; }
    }
}
