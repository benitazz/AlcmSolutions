using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class work_roles_location
    {
        public string bl_id { get; set; }
        public string em_id { get; set; }
        public string pr_id { get; set; }
        public string site_id { get; set; }
        public string work_role_name { get; set; }
        public int work_role_location_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Em em { get; set; }
        public virtual Property property { get; set; }
        public virtual site site { get; set; }
        public virtual work_roles work_roles { get; set; }
    }
}
