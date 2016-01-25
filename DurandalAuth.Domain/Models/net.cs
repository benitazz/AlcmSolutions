using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class net
    {
        public net()
        {
            this.cards = new List<card>();
            this.ems = new List<Em>();
            this.eqs = new List<eq>();
            this.netdevs = new List<netdev>();
        }

        public string administrator { get; set; }
        public string ca_type { get; set; }
        public string comments { get; set; }
        public string description { get; set; }
        public Nullable<short> is_virtual { get; set; }
        public string lan_type { get; set; }
        public string net_address { get; set; }
        public string net_os_type { get; set; }
        public int num_nodes { get; set; }
        public string transport_protocol { get; set; }
        public string wan_type { get; set; }
        public string net_id { get; set; }
        public virtual ICollection<card> cards { get; set; }
        public virtual catype catype { get; set; }
        public virtual ICollection<Em> ems { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual ICollection<netdev> netdevs { get; set; }
    }
}
