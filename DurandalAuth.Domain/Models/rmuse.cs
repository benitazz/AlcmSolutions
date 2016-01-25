using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rmuse
    {
        public rmuse()
        {
            this.rms = new List<Rm>();
        }

        public string description { get; set; }
        public string rm_use { get; set; }
        public virtual ICollection<Rm> rms { get; set; }
    }
}
