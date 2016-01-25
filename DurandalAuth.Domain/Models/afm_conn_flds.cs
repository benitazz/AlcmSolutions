using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_conn_flds
    {
        public string destination_fld { get; set; }
        public string field_id { get; set; }
        public Nullable<int> ignore_nulls { get; set; }
        public short is_schema_field { get; set; }
        public string parameter { get; set; }
        public Nullable<int> cache { get; set; }
        public string result { get; set; }
        public string rule_id { get; set; }
        public string validate_tbl { get; set; }
        public string connector_id { get; set; }
        public int position { get; set; }
        public virtual afm_connector afm_connector { get; set; }
        public virtual afm_conn_rule_cat afm_conn_rule_cat { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
    }
}
