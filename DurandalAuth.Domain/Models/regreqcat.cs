using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class regreqcat
    {
        public regreqcat()
        {
            this.regrequirements = new List<regrequirement>();
        }

        public string description { get; set; }
        public string summary { get; set; }
        public string regreq_cat { get; set; }
        public virtual ICollection<regrequirement> regrequirements { get; set; }
    }
}
