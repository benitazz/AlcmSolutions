using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cb_accredit_person
    {
        public cb_accredit_person()
        {
            this.activity_log = new List<activity_log>();
        }

        public string accredit_source_id { get; set; }
        public string accredit_type_id { get; set; }
        public string cert_num { get; set; }
        public string comments { get; set; }
        public string contact_id { get; set; }
        public Nullable<System.DateTime> date_accredited { get; set; }
        public Nullable<System.DateTime> date_expire { get; set; }
        public string doc { get; set; }
        public string em_id { get; set; }
        public Nullable<int> insp_num { get; set; }
        public string lic_num { get; set; }
        public string prob_type { get; set; }
        public string vn_id { get; set; }
        public string person_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual cb_accredit_source cb_accredit_source { get; set; }
        public virtual cb_accredit_type cb_accredit_type { get; set; }
        public virtual Contact contact { get; set; }
        public virtual Em em { get; set; }
        public virtual probtype probtype { get; set; }
        public virtual vn vn { get; set; }
    }
}
