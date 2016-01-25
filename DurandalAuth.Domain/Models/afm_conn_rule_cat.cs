using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_conn_rule_cat
    {
        public afm_conn_rule_cat()
        {
            this.afm_conn_flds = new List<afm_conn_flds>();
        }

        public string class_name { get; set; }
        public short data_type { get; set; }
        public string description { get; set; }
        public Nullable<short> is_schema_field { get; set; }
        public string method_name { get; set; }
        public string parameter { get; set; }
        public string rule_id { get; set; }
        public virtual ICollection<afm_conn_flds> afm_conn_flds { get; set; }
    }
}
