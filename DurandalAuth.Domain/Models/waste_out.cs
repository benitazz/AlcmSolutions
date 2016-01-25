using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class waste_out
    {
        public string bl_id { get; set; }
        public string contact_id { get; set; }
        public string container_cat { get; set; }
        public string container_id { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_shipped { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public string dp_id { get; set; }
        public string dv_id { get; set; }
        public string em_id { get; set; }
        public string eq_id { get; set; }
        public string facility_id { get; set; }
        public string fl_id { get; set; }
        public string generator_id { get; set; }
        public string manifest_number { get; set; }
        public string method_code { get; set; }
        public string notes { get; set; }
        public int number_containers { get; set; }
        public string pr_id { get; set; }
        public decimal quantity { get; set; }
        public string rm_id { get; set; }
        public string shipment_id { get; set; }
        public string site_id { get; set; }
        public string status { get; set; }
        public string storage_location { get; set; }
        public Nullable<System.DateTime> time_end { get; set; }
        public Nullable<System.DateTime> time_start { get; set; }
        public string transporter_id { get; set; }
        public string units { get; set; }
        public string units_type { get; set; }
        public string waste_disposition { get; set; }
        public string waste_profile { get; set; }
        public int waste_id { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_unit bill_unit { get; set; }
        public virtual hazard_container_cat hazard_container_cat { get; set; }
        public virtual vn vn { get; set; }
        public virtual waste_areas waste_areas { get; set; }
        public virtual waste_dispositions waste_dispositions { get; set; }
        public virtual waste_facilities waste_facilities { get; set; }
        public virtual waste_generators waste_generators { get; set; }
        public virtual waste_manifests waste_manifests { get; set; }
        public virtual waste_mgmt_methods waste_mgmt_methods { get; set; }
        public virtual waste_profiles waste_profiles { get; set; }
    }
}
