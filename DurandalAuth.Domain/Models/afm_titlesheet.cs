using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_titlesheet
    {
        public double margin_bottom { get; set; }
        public double margin_left { get; set; }
        public double margin_right { get; set; }
        public double margin_top { get; set; }
        public double sheet_height { get; set; }
        public double sheet_width { get; set; }
        public short sort_order { get; set; }
        public string title_block { get; set; }
        public string transfer_status { get; set; }
        public string units_type { get; set; }
        public string description { get; set; }
        public string format_name { get; set; }
    }
}
