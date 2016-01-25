using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class telext
    {
        public telext()
        {
            this.combexts = new List<combext>();
        }

        public Nullable<System.DateTime> date_inserted { get; set; }
        public string description { get; set; }
        public string extension { get; set; }
        public string phone { get; set; }
        public string telext_id { get; set; }
        public virtual ICollection<combext> combexts { get; set; }
    }
}
