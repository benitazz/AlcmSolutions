using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class vn_ac
    {
        public vn_ac()
        {
            this.bills = new List<bill>();
            this.bill_connector = new List<bill_connector>();
        }

        public string bill_address1 { get; set; }
        public string bill_address2 { get; set; }
        public string bill_city_id { get; set; }
        public string bill_ctry_id { get; set; }
        public string bill_postal_code { get; set; }
        public string bill_state_id { get; set; }
        public string bill_type_id { get; set; }
        public string bl_id { get; set; }
        public string eq_id { get; set; }
        public string remit_address1 { get; set; }
        public string remit_address2 { get; set; }
        public string remit_city_id { get; set; }
        public string remit_ctry_id { get; set; }
        public string remit_postal_code { get; set; }
        public string remit_state_id { get; set; }
        public string serv_address1 { get; set; }
        public string serv_address2 { get; set; }
        public string serv_city_id { get; set; }
        public string serv_ctry_id { get; set; }
        public string serv_postal_code { get; set; }
        public string serv_state_id { get; set; }
        public string site_id { get; set; }
        public string vn_id { get; set; }
        public string vn_ac_id { get; set; }
        public virtual ICollection<bill> bills { get; set; }
        public virtual ICollection<bill_connector> bill_connector { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bl bl { get; set; }
        public virtual City city { get; set; }
        public virtual City city1 { get; set; }
        public virtual City city2 { get; set; }
        public virtual ctry ctry { get; set; }
        public virtual ctry ctry1 { get; set; }
        public virtual ctry ctry2 { get; set; }
        public virtual eq eq { get; set; }
        public virtual site site { get; set; }
        public virtual state state { get; set; }
        public virtual state state1 { get; set; }
        public virtual state state2 { get; set; }
        public virtual vn vn { get; set; }
    }
}
