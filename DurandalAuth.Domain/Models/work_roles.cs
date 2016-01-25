using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class work_roles
    {
        public work_roles()
        {
            this.work_roles_location = new List<work_roles_location>();
        }

        public string description { get; set; }
        public string title { get; set; }
        public string title_01 { get; set; }
        public string title_02 { get; set; }
        public string title_03 { get; set; }
        public string title_ch { get; set; }
        public string title_de { get; set; }
        public string title_es { get; set; }
        public string title_fr { get; set; }
        public string title_it { get; set; }
        public string title_jp { get; set; }
        public string title_ko { get; set; }
        public string title_nl { get; set; }
        public string title_no { get; set; }
        public string title_zh { get; set; }
        public string work_role_name { get; set; }
        public virtual ICollection<work_roles_location> work_roles_location { get; set; }
    }
}
