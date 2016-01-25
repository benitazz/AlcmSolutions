using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_atyp
    {
        public afm_atyp()
        {
            this.afm_layr = new List<afm_layr>();
        }

        public short atxt_boxed { get; set; }
        public short atxt_gen { get; set; }
        public double atxt_ht { get; set; }
        public double atxt_ht_cm { get; set; }
        public double atxt_ht_in { get; set; }
        public short atxt_just { get; set; }
        public string atxt_style { get; set; }
        public double atxt_xoff_cm { get; set; }
        public double atxt_xoff_in { get; set; }
        public double atxt_yoff_cm { get; set; }
        public double atxt_yoff_in { get; set; }
        public string dflt_symbol { get; set; }
        public string dflt_view { get; set; }
        public string dflt_view_sc { get; set; }
        public short entity_type { get; set; }
        public short param_units { get; set; }
        public string pop_layer { get; set; }
        public string pop_loc { get; set; }
        public short record_source { get; set; }
        public short regen_pop { get; set; }
        public string rule_id { get; set; }
        public short scaled_ins { get; set; }
        public string std_table { get; set; }
        public string transfer_status { get; set; }
        public string table_name { get; set; }
        public virtual afm_dwgpub afm_dwgpub { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
        public virtual afm_tbls afm_tbls1 { get; set; }
        public virtual ICollection<afm_layr> afm_layr { get; set; }
    }
}
