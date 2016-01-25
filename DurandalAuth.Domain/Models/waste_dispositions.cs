using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class waste_dispositions
    {
        public waste_dispositions()
        {
            this.waste_out = new List<waste_out>();
        }

        public string description { get; set; }
        public string disposition_type { get; set; }
        public string waste_disposition { get; set; }
        public virtual ICollection<waste_out> waste_out { get; set; }
    }
}
