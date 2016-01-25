using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_groupsforroles
    {
        public string transfer_status { get; set; }
        public string role_name { get; set; }
        public string group_name { get; set; }
        public virtual afm_groups afm_groups { get; set; }
        public virtual afm_roles afm_roles { get; set; }
    }
}
