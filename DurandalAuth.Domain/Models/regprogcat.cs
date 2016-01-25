using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class regprogcat
    {
        public regprogcat()
        {
            this.regprograms = new List<regprogram>();
            this.regprogtypes = new List<regprogtype>();
        }

        public string description { get; set; }
        public string summary { get; set; }
        public string regprog_cat { get; set; }
        public virtual ICollection<regprogram> regprograms { get; set; }
        public virtual ICollection<regprogtype> regprogtypes { get; set; }
    }
}
