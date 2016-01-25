using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class wy
    {
        public wy()
        {
            this.cas = new List<ca>();
            this.fps = new List<fp>();
            this.jks = new List<jk>();
        }

        public string access_space { get; set; }
        public string bl_id { get; set; }
        public Nullable<System.DateTime> date_installed { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string fl_id { get; set; }
        public decimal length { get; set; }
        public short num_cables { get; set; }
        public short num_cables_max { get; set; }
        public string rm_id { get; set; }
        public string site_id { get; set; }
        public string tc_cabling_level { get; set; }
        public string tc_level { get; set; }
        public decimal weight_max { get; set; }
        public decimal weight_total { get; set; }
        public string wy_type { get; set; }
        public string wy_use { get; set; }
        public string wy_id { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Rm rm { get; set; }
        public virtual site site { get; set; }
        public virtual wytype wytype { get; set; }
        public virtual ICollection<ca> cas { get; set; }
        public virtual ICollection<fp> fps { get; set; }
        public virtual ICollection<jk> jks { get; set; }
    }
}
