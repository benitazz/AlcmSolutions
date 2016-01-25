using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class em_compinvtrial
    {
        public string difference { get; set; }
        public string dwgnames { get; set; }
        public string em_id { get; set; }
        public string inv_bl_id { get; set; }
        public string inv_fl_id { get; set; }
        public string inv_rm_id { get; set; }
        public string layers { get; set; }
        public Nullable<int> mo_id { get; set; }
        public string trial_bl_id { get; set; }
        public string trial_fl_id { get; set; }
        public string trial_project_id { get; set; }
        public string trial_rm_id { get; set; }
        public int auto_number { get; set; }
        public virtual bl bl { get; set; }
        public virtual bl bl1 { get; set; }
        public virtual Em em { get; set; }
        public virtual Fl fl { get; set; }
        public virtual Rm rm { get; set; }
        public virtual mo mo { get; set; }
        public virtual Fl fl1 { get; set; }
        public virtual Rm rm1 { get; set; }
    }
}
