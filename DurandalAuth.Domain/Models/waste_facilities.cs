using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class waste_facilities
    {
        public waste_facilities()
        {
            this.waste_manifests = new List<waste_manifests>();
            this.waste_manifests1 = new List<waste_manifests>();
            this.waste_out = new List<waste_out>();
        }

        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city_id { get; set; }
        public string contact_name { get; set; }
        public string ctry_id { get; set; }
        public short disposal { get; set; }
        public string email { get; set; }
        public string facility_name { get; set; }
        public string facility_number { get; set; }
        public string fax { get; set; }
        public string notes { get; set; }
        public string phone { get; set; }
        public short recycle { get; set; }
        public string state_id { get; set; }
        public string status { get; set; }
        public string title { get; set; }
        public short treatment { get; set; }
        public string vn_id { get; set; }
        public string zip { get; set; }
        public string facility_id { get; set; }
        public virtual City city { get; set; }
        public virtual ctry ctry { get; set; }
        public virtual state state { get; set; }
        public virtual vn vn { get; set; }
        public virtual ICollection<waste_manifests> waste_manifests { get; set; }
        public virtual ICollection<waste_manifests> waste_manifests1 { get; set; }
        public virtual ICollection<waste_out> waste_out { get; set; }
    }
}
