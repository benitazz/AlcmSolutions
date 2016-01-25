using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class notifycat
    {
        public notifycat()
        {
            this.notify_templates = new List<notify_templates>();
        }

        public string description { get; set; }
        public string activity_id { get; set; }
        public string notify_cat { get; set; }
        public virtual afm_activities afm_activities { get; set; }
        public virtual ICollection<notify_templates> notify_templates { get; set; }
    }
}
