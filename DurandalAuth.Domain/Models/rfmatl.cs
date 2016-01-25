using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rfmatl
    {
        public rfmatl()
        {
            this.rfs = new List<Rf>();
            this.rfs1 = new List<Rf>();
            this.rfs2 = new List<Rf>();
            this.rfs3 = new List<Rf>();
            this.rfs4 = new List<Rf>();
            this.rfs5 = new List<Rf>();
        }

        public string description { get; set; }
        public string rf_matl { get; set; }
        public virtual ICollection<Rf> rfs { get; set; }
        public virtual ICollection<Rf> rfs1 { get; set; }
        public virtual ICollection<Rf> rfs2 { get; set; }
        public virtual ICollection<Rf> rfs3 { get; set; }
        public virtual ICollection<Rf> rfs4 { get; set; }
        public virtual ICollection<Rf> rfs5 { get; set; }
    }
}
