using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class property_type
    {
        public property_type()
        {
            this.eqs = new List<eq>();
            this.pas = new List<pa>();
            this.tas = new List<ta>();
        }

        public string deprec_method { get; set; }
        public int deprec_period { get; set; }
        public string property_type1 { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual ICollection<pa> pas { get; set; }
        public virtual ICollection<ta> tas { get; set; }
    }
}
