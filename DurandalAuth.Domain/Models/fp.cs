using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class fp
    {
        public fp()
        {
            this.combexts = new List<combext>();
            this.jks = new List<jk>();
            this.jkexts = new List<jkext>();
            this.moes = new List<mo>();
            this.wies = new List<wy>();
        }

        public string bl_id { get; set; }
        public Nullable<System.DateTime> date_installed { get; set; }
        public string description { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string em_id { get; set; }
        public string fl_id { get; set; }
        public string fp_std { get; set; }
        public string grid_id { get; set; }
        public string rm_id { get; set; }
        public string tc_level { get; set; }
        public string fp_id { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual bl bl { get; set; }
        public virtual ICollection<combext> combexts { get; set; }
        public virtual Em em { get; set; }
        public virtual Fl fl { get; set; }
        public virtual fpstd fpstd { get; set; }
        public virtual grid grid { get; set; }
        public virtual Rm rm { get; set; }
        public virtual ICollection<jk> jks { get; set; }
        public virtual ICollection<jkext> jkexts { get; set; }
        public virtual ICollection<mo> moes { get; set; }
        public virtual ICollection<wy> wies { get; set; }
    }
}
