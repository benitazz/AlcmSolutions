using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class grid
    {
        public grid()
        {
            this.fps = new List<fp>();
            this.jks = new List<jk>();
        }

        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string bl_id { get; set; }
        public string fl_id { get; set; }
        public string grid_id { get; set; }
        public virtual bl bl { get; set; }
        public virtual Fl fl { get; set; }
        public virtual ICollection<fp> fps { get; set; }
        public virtual ICollection<jk> jks { get; set; }
    }
}
