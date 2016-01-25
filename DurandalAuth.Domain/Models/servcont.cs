using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class servcont
    {
        public servcont()
        {
            this.eqs = new List<eq>();
            this.helpdesk_sla_response = new List<helpdesk_sla_response>();
        }

        public string contact_info { get; set; }
        public Nullable<System.DateTime> date_expiration { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string image_serv_contract { get; set; }
        public string servcont_vendor { get; set; }
        public string servcont_id { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual ICollection<helpdesk_sla_response> helpdesk_sla_response { get; set; }
    }
}
