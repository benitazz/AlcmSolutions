using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class lessor
    {
        public lessor()
        {
            this.ta_lease = new List<ta_lease>();
        }

        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string contact { get; set; }
        public string country { get; set; }
        public string description { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string phone_ext { get; set; }
        public string postalcode { get; set; }
        public string region { get; set; }
        public string lessor_id { get; set; }
        public virtual ICollection<ta_lease> ta_lease { get; set; }
    }
}
