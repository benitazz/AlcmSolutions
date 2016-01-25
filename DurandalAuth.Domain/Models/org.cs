using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class org
    {
        public org()
        {
            this.rms = new List<Rm>();
            this.rmpcts = new List<rmpct>();
        }

        public string ac_id { get; set; }
        public string contact_id { get; set; }
        public string description { get; set; }
        public string hierarchy_ids { get; set; }
        public string hpattern { get; set; }
        public string hpattern_acad { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string org_name { get; set; }
        public string org_id { get; set; }
        public virtual ac ac { get; set; }
        public virtual Contact contact { get; set; }
        public virtual ICollection<Rm> rms { get; set; }
        public virtual ICollection<rmpct> rmpcts { get; set; }
    }
}
