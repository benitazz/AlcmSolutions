using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class po_line
    {
        public po_line()
        {
            this.checkins = new List<checkin>();
            this.eqs = new List<eq>();
            this.tas = new List<ta>();
        }

        public string catno { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public decimal unit_cost { get; set; }
        public int po_id { get; set; }
        public int po_line_id { get; set; }
        public virtual ICollection<checkin> checkins { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual po po { get; set; }
        public virtual ICollection<ta> tas { get; set; }
    }
}
