using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class waste_generators
    {
        public waste_generators()
        {
            this.waste_out = new List<waste_out>();
        }

        public string bl_id { get; set; }
        public string contact_id { get; set; }
        public string fl_id { get; set; }
        public string generator_name { get; set; }
        public string pr_id { get; set; }
        public string rm_id { get; set; }
        public string site_id { get; set; }
        public string type { get; set; }
        public string generator_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Contact contact { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Property property { get; set; }
        public virtual Rm rm { get; set; }
        public virtual site site { get; set; }
        public virtual ICollection<waste_out> waste_out { get; set; }
    }
}
