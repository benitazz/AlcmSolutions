using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class waste_manifests
    {
        public waste_manifests()
        {
            this.waste_out = new List<waste_out>();
        }

        public Nullable<System.DateTime> date_acceptance { get; set; }
        public Nullable<System.DateTime> date_alternate_facility { get; set; }
        public Nullable<System.DateTime> date_country_departure { get; set; }
        public Nullable<System.DateTime> date_exception { get; set; }
        public Nullable<System.DateTime> date_facility_contact { get; set; }
        public Nullable<System.DateTime> date_received { get; set; }
        public Nullable<System.DateTime> date_shipped { get; set; }
        public Nullable<System.DateTime> date_shipped_alt { get; set; }
        public Nullable<System.DateTime> date_transporter { get; set; }
        public Nullable<System.DateTime> date_transporter_2 { get; set; }
        public short discrepancy_full_rejection { get; set; }
        public short discrepancy_partial_rejection { get; set; }
        public short discrepancy_qty { get; set; }
        public short discrepancy_residue { get; set; }
        public short discrepancy_type { get; set; }
        public string doc { get; set; }
        public string exception_notes { get; set; }
        public string facility_contact_notes { get; set; }
        public string facility_id { get; set; }
        public string facility_id_alt { get; set; }
        public string handling_instructions { get; set; }
        public string international_shipments { get; set; }
        public string manifest_reference_num { get; set; }
        public string port { get; set; }
        public string sign_alternate_facility { get; set; }
        public string sign_facility { get; set; }
        public string sign_transporter { get; set; }
        public string sign_transporter_2 { get; set; }
        public string signed_by { get; set; }
        public string transporter_id { get; set; }
        public string transporter_id_2 { get; set; }
        public string manifest_number { get; set; }
        public virtual vn vn { get; set; }
        public virtual vn vn1 { get; set; }
        public virtual waste_facilities waste_facilities { get; set; }
        public virtual waste_facilities waste_facilities1 { get; set; }
        public virtual ICollection<waste_out> waste_out { get; set; }
    }
}
