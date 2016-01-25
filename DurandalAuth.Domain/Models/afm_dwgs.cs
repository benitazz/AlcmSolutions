using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_dwgs
    {
        public afm_dwgs()
        {
            this.afm_dwgvers = new List<afm_dwgvers>();
            this.afm_redlines = new List<afm_redlines>();
        }

        public Nullable<short> geo_level { get; set; }
        public Nullable<decimal> geo_rotate { get; set; }
        public Nullable<decimal> geo_scale { get; set; }
        public string geo_srs { get; set; }
        public Nullable<decimal> geo_x { get; set; }
        public Nullable<decimal> geo_y { get; set; }
        public string locked_by { get; set; }
        public string model_level { get; set; }
        public string model_name { get; set; }
        public string relative_path { get; set; }
        public decimal report_height { get; set; }
        public decimal report_height_tabloid { get; set; }
        public short report_scale { get; set; }
        public short report_title_position { get; set; }
        public decimal report_width { get; set; }
        public decimal report_width_tabloid { get; set; }
        public string space_hier_field_values { get; set; }
        public string title { get; set; }
        public string transfer_status { get; set; }
        public short units { get; set; }
        public short base_metric_units { get; set; }
        public string dwg_file { get; set; }
        public string dwg_name { get; set; }
        public virtual ICollection<afm_dwgvers> afm_dwgvers { get; set; }
        public virtual ICollection<afm_redlines> afm_redlines { get; set; }
    }
}
