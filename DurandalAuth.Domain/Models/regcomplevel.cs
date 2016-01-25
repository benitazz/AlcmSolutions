using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class regcomplevel
    {
        public regcomplevel()
        {
            this.reglocs = new List<regloc>();
            this.reglocs1 = new List<regloc>();
            this.regprograms = new List<regprogram>();
            this.regprograms1 = new List<regprogram>();
            this.regrequirements = new List<regrequirement>();
            this.regrequirements1 = new List<regrequirement>();
        }

        public string description { get; set; }
        public short level_number { get; set; }
        public string summary { get; set; }
        public string comp_level { get; set; }
        public virtual ICollection<regloc> reglocs { get; set; }
        public virtual ICollection<regloc> reglocs1 { get; set; }
        public virtual ICollection<regprogram> regprograms { get; set; }
        public virtual ICollection<regprogram> regprograms1 { get; set; }
        public virtual ICollection<regrequirement> regrequirements { get; set; }
        public virtual ICollection<regrequirement> regrequirements1 { get; set; }
    }
}
