using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ls_resp
    {
        public ls_resp()
        {
            this.activity_log = new List<activity_log>();
        }

        public string clause_type_id { get; set; }
        public string contact_id { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public short dates_match_lease { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string reference_loc { get; set; }
        public string resp_party { get; set; }
        public string resp_type { get; set; }
        public string ls_id { get; set; }
        public string resp_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual Contact contact { get; set; }
        public virtual l l { get; set; }
        public virtual ls_clause_type ls_clause_type { get; set; }
    }
}
