using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class doctype
    {
        public doctype()
        {
            this.docs_assigned = new List<docs_assigned>();
        }

        public string description { get; set; }
        public string summary { get; set; }
        public string doc_cat { get; set; }
        public string doc_type { get; set; }
        public virtual doccat doccat { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
    }
}
