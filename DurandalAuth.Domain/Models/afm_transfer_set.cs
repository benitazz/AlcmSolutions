using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_transfer_set
    {
        public int nrecords_dest { get; set; }
        public int nrecords_inserted { get; set; }
        public int nrecords_missing { get; set; }
        public int nrecords_source { get; set; }
        public int nrecords_updated { get; set; }
        public short processing_order { get; set; }
        public string set_name { get; set; }
        public string status { get; set; }
        public string table_name { get; set; }
        public string table_type { get; set; }
        public int autonumbered_id { get; set; }
    }
}
