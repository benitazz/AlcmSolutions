using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class jk
    {
        public jk()
        {
            this.combexts = new List<combext>();
            this.jkexts = new List<jkext>();
            this.mo_eq = new List<mo_eq>();
            this.wies = new List<wy>();
        }

        public string bl_id { get; set; }
        public string ca_std { get; set; }
        public Nullable<System.DateTime> date_installed { get; set; }
        public string description { get; set; }
        public string drop_pole { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string em_id { get; set; }
        public string extension { get; set; }
        public string fl_id { get; set; }
        public string fp_id { get; set; }
        public string grid_id { get; set; }
        public string jk_std { get; set; }
        public string pbx_port_id { get; set; }
        public string phone { get; set; }
        public string rm_id { get; set; }
        public string tc_level { get; set; }
        public string tc_service { get; set; }
        public string tc_use { get; set; }
        public string tc_use_status { get; set; }
        public string jk_id { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual bl bl { get; set; }
        public virtual castd castd { get; set; }
        public virtual ICollection<combext> combexts { get; set; }
        public virtual Em em { get; set; }
        public virtual Fl fl { get; set; }
        public virtual fp fp { get; set; }
        public virtual grid grid { get; set; }
        public virtual jkstd jkstd { get; set; }
        public virtual Rm rm { get; set; }
        public virtual ICollection<jkext> jkexts { get; set; }
        public virtual ICollection<mo_eq> mo_eq { get; set; }
        public virtual ICollection<wy> wies { get; set; }
    }
}
