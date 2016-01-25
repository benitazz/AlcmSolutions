using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class su
    {
        public decimal area_comn { get; set; }
        public decimal area_manual { get; set; }
        public decimal area_rentable { get; set; }
        public decimal area_usable { get; set; }
        public string description { get; set; }
        public string doc_image { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string facility_type_id { get; set; }
        public string image_file { get; set; }
        public string ls_id { get; set; }
        public string name { get; set; }
        public int occupancy { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string su_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual facility_type facility_type { get; set; }
        public virtual Fl fl { get; set; }
        public virtual l l { get; set; }
    }
}
