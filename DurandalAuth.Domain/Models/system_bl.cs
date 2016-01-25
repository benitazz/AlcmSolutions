using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class system_bl
    {
        public system_bl()
        {
            this.system_dep = new List<system_dep>();
            this.system_dep1 = new List<system_dep>();
            this.zones = new List<zone>();
        }

        public string bl_id { get; set; }
        public string comments { get; set; }
        public string contact_id { get; set; }
        public string description { get; set; }
        public string recovery_status { get; set; }
        public string system_type { get; set; }
        public string system_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Contact contact { get; set; }
        public virtual system_type system_type1 { get; set; }
        public virtual ICollection<system_dep> system_dep { get; set; }
        public virtual ICollection<system_dep> system_dep1 { get; set; }
        public virtual ICollection<zone> zones { get; set; }
    }
}
