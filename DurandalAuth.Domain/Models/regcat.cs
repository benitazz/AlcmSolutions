using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class regcat
    {
        public regcat()
        {
            this.regtypes = new List<regtype>();
            this.regulations = new List<regulation>();
        }

        public string description { get; set; }
        public string summary { get; set; }
        public string reg_cat { get; set; }
        public virtual ICollection<regtype> regtypes { get; set; }
        public virtual ICollection<regulation> regulations { get; set; }
    }
}
