using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_docvers
    {
        public string author { get; set; }
        public Nullable<System.DateTime> checkin_date { get; set; }
        public Nullable<System.DateTime> checkin_time { get; set; }
        public string comments { get; set; }
        public string doc_file { get; set; }
        public decimal doc_size { get; set; }
        public byte[] file_contents { get; set; }
        public string transfer_status { get; set; }
        public string table_name { get; set; }
        public string field_name { get; set; }
        public string pkey_value { get; set; }
        public short version { get; set; }
        public virtual afm_docs afm_docs { get; set; }
        public virtual afm_users afm_users { get; set; }
        public virtual afm_flds afm_flds { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
    }
}
