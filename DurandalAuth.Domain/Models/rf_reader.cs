using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rf_reader
    {
        public rf_reader()
        {
            this.rf_activity = new List<rf_activity>();
        }

        public string bl_id { get; set; }
        public string description { get; set; }
        public string fl_id { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public string in_rm_id { get; set; }
        public Nullable<decimal> lat { get; set; }
        public Nullable<decimal> lon { get; set; }
        public string out_rm_id { get; set; }
        public string reader_type { get; set; }
        public string site_id { get; set; }
        public string reader_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual ICollection<rf_activity> rf_activity { get; set; }
        public virtual Rm rm { get; set; }
        public virtual Rm rm1 { get; set; }
        public virtual site site { get; set; }
    }
}
