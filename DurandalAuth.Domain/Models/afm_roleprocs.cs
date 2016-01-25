using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_roleprocs
    {
        public string transfer_status { get; set; }
        public string role_name { get; set; }
        public string activity_id { get; set; }
        public string process_id { get; set; }
        public virtual afm_activities afm_activities { get; set; }
        public virtual afm_processes afm_processes { get; set; }
        public virtual afm_roles afm_roles { get; set; }
    }
}
