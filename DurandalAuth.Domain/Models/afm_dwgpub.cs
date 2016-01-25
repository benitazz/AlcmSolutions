using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_dwgpub
    {
        public afm_dwgpub()
        {
            this.afm_atyp = new List<afm_atyp>();
        }

        public string color_mapping { get; set; }
        public string comments { get; set; }
        public string dwg_view { get; set; }
        public string filter_assigned { get; set; }
        public string filter_owner { get; set; }
        public Nullable<short> highlight_outline { get; set; }
        public string hpattern_acad { get; set; }
        public string is_active { get; set; }
        public string layer_addl { get; set; }
        public string layer_background { get; set; }
        public string layer_output { get; set; }
        public Nullable<short> lgnd_all_owners { get; set; }
        public Nullable<short> lgnd_counts { get; set; }
        public Nullable<short> lgnd_draw { get; set; }
        public Nullable<short> lgnd_key_flds { get; set; }
        public short lgnd_ncolumns { get; set; }
        public Nullable<short> lgnd_show_date { get; set; }
        public Nullable<short> lgnd_show_desc { get; set; }
        public Nullable<short> lgnd_show_time { get; set; }
        public Nullable<short> lgnd_sort { get; set; }
        public string lgnd_totalon { get; set; }
        public Nullable<short> lgnd_totals { get; set; }
        public double lgnd_txtheight { get; set; }
        public double lgnd_x { get; set; }
        public double lgnd_y { get; set; }
        public string qtxt_assign_templ { get; set; }
        public short qtxt_fit { get; set; }
        public double qtxt_ht { get; set; }
        public string qtxt_owner_templ { get; set; }
        public string rule_suffix { get; set; }
        public string rule_type { get; set; }
        public string table_assigned { get; set; }
        public string table_owner { get; set; }
        public string title { get; set; }
        public string transfer_status { get; set; }
        public string url_name { get; set; }
        public string rule_id { get; set; }
        public virtual ICollection<afm_atyp> afm_atyp { get; set; }
        public virtual afm_flds afm_flds { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
        public virtual afm_tbls afm_tbls1 { get; set; }
    }
}
