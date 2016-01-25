using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class work_pkg_bids
    {
        public string approved_by { get; set; }
        public string bid_type { get; set; }
        public string comments { get; set; }
        public string contact_id { get; set; }
        public decimal cost_bid { get; set; }
        public decimal cost_contract { get; set; }
        public Nullable<System.DateTime> date_approved { get; set; }
        public Nullable<System.DateTime> date_contract_end { get; set; }
        public Nullable<System.DateTime> date_contract_start { get; set; }
        public System.DateTime date_submitted { get; set; }
        public Nullable<System.DateTime> date_updated { get; set; }
        public Nullable<System.DateTime> date_warranty_exp { get; set; }
        public string doc_contract { get; set; }
        public string doc_proposal { get; set; }
        public short duration_bidded { get; set; }
        public short full_scope_bid { get; set; }
        public decimal not_to_exceed { get; set; }
        public string payment_terms { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> time_updated { get; set; }
        public string unit_quantity { get; set; }
        public string warranty_desc { get; set; }
        public string project_id { get; set; }
        public string work_pkg_id { get; set; }
        public string vn_id { get; set; }
        public virtual Contact contact { get; set; }
        public virtual Em em { get; set; }
        public virtual project project { get; set; }
        public virtual vn vn { get; set; }
        public virtual work_pkgs work_pkgs { get; set; }
    }
}
