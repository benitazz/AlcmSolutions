using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class eq_compinvsur
    {
        public string inv_bl_id { get; set; }
        public string inv_dp_id { get; set; }
        public string inv_dv_id { get; set; }
        public string inv_em_id { get; set; }
        public string inv_fl_id { get; set; }
        public string inv_rm_id { get; set; }
        public string inv_status { get; set; }
        public string sur_bl_id { get; set; }
        public string sur_dp_id { get; set; }
        public string sur_dv_id { get; set; }
        public string sur_em_id { get; set; }
        public string sur_fl_id { get; set; }
        public string sur_rm_id { get; set; }
        public string sur_status { get; set; }
        public string survey_id { get; set; }
        public string difference { get; set; }
        public string eq_id { get; set; }
        public virtual survey survey { get; set; }
    }
}
