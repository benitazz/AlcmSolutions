using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class doccat
    {
        public doccat()
        {
            this.docs_assigned = new List<docs_assigned>();
            this.doctypes = new List<doctype>();
        }

        public string description { get; set; }
        public string summary { get; set; }
        public string doc_cat { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
        public virtual ICollection<doctype> doctypes { get; set; }
    }
}
