using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_docs
    {
        public afm_docs()
        {
            this.afm_docvers = new List<afm_docvers>();
        }

        public Nullable<System.DateTime> lock_date { get; set; }
        public Nullable<System.DateTime> lock_time { get; set; }
        public short locked { get; set; }
        public string locked_by { get; set; }
        public Nullable<short> deleted { get; set; }
        public string description { get; set; }
        public string transfer_status { get; set; }
        public string table_name { get; set; }
        public string field_name { get; set; }
        public string pkey_value { get; set; }
        public virtual afm_flds afm_flds { get; set; }
        public virtual afm_users afm_users { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
        public virtual ICollection<afm_docvers> afm_docvers { get; set; }
    }
}
