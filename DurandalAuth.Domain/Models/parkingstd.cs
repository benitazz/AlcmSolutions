using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class parkingstd
    {
        public parkingstd()
        {
            this.parkings = new List<parking>();
        }

        public decimal cost { get; set; }
        public string description { get; set; }
        public decimal length { get; set; }
        public decimal width { get; set; }
        public string parking_std { get; set; }
        public virtual ICollection<parking> parkings { get; set; }
    }
}
