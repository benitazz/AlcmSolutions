using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ca
    {
        public ca()
        {
            this.cps = new List<cp>();
            this.wies = new List<wy>();
        }

        public string ca_std { get; set; }
        public decimal cost { get; set; }
        public Nullable<System.DateTime> date_installed { get; set; }
        public string description { get; set; }
        public string drop_pole { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string fl_id { get; set; }
        public short is_multiplexing { get; set; }
        public decimal length { get; set; }
        public short num_pairs { get; set; }
        public short num_pairs_active { get; set; }
        public short num_pairs_avail { get; set; }
        public string rm_id { get; set; }
        public string site_id { get; set; }
        public string tc_cabling_level { get; set; }
        public string tc_level { get; set; }
        public string tc_service { get; set; }
        public string tc_use_status { get; set; }
        public decimal unit_weight { get; set; }
        public string bl_id { get; set; }
        public string ca_id { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual bl bl { get; set; }
        public virtual castd castd { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Rm rm { get; set; }
        public virtual site site { get; set; }
        public virtual ICollection<cp> cps { get; set; }
        public virtual ICollection<wy> wies { get; set; }
    }
}
