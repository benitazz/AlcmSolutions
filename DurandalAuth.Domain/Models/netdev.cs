using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class netdev
    {
        public netdev()
        {
            this.cards = new List<card>();
            this.ndports = new List<ndport>();
        }

        public string bl_id { get; set; }
        public string cross_connect_level { get; set; }
        public string description { get; set; }
        public string detail_dwg { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string fl_id { get; set; }
        public string hardware_address { get; set; }
        public short is_multiplexing { get; set; }
        public string net_address { get; set; }
        public string net_address_ip { get; set; }
        public string net_card_type { get; set; }
        public string net_id { get; set; }
        public string net_sub_mask { get; set; }
        public string netdev_std { get; set; }
        public string netdev_type { get; set; }
        public string num_serial { get; set; }
        public string rack_id { get; set; }
        public string rm_id { get; set; }
        public string tc_level { get; set; }
        public string tc_service { get; set; }
        public string netdev_id { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual bl bl { get; set; }
        public virtual ICollection<card> cards { get; set; }
        public virtual Fl fl { get; set; }
        public virtual ICollection<ndport> ndports { get; set; }
        public virtual net net { get; set; }
        public virtual netdevstd netdevstd { get; set; }
        public virtual rack rack { get; set; }
        public virtual Rm rm { get; set; }
    }
}
