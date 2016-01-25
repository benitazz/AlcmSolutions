using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class bu
    {
        public bu()
        {
            this.dvs = new List<dv>();
            this.gps = new List<gp>();
            this.sb_items = new List<sb_items>();
            this.sbaffins = new List<sbaffin>();
            this.sbaffins1 = new List<sbaffin>();
        }

        public decimal area_chargable { get; set; }
        public decimal area_comn { get; set; }
        public decimal area_comn_gp { get; set; }
        public decimal area_comn_nocup { get; set; }
        public decimal area_comn_ocup { get; set; }
        public decimal area_comn_rm { get; set; }
        public decimal area_comn_serv { get; set; }
        public decimal area_gp { get; set; }
        public decimal area_nocup { get; set; }
        public decimal area_ocup { get; set; }
        public decimal area_rm { get; set; }
        public decimal cost { get; set; }
        public int count_em { get; set; }
        public string name { get; set; }
        public string bu_id { get; set; }
        public virtual ICollection<dv> dvs { get; set; }
        public virtual ICollection<gp> gps { get; set; }
        public virtual ICollection<sb_items> sb_items { get; set; }
        public virtual ICollection<sbaffin> sbaffins { get; set; }
        public virtual ICollection<sbaffin> sbaffins1 { get; set; }
    }
}
