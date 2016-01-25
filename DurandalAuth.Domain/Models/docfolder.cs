using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class docfolder
    {
        public docfolder()
        {
            this.docs_assigned = new List<docs_assigned>();
        }

        public string description { get; set; }
        public string hierarchy_ids { get; set; }
        public string summary { get; set; }
        public string doc_folder { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
    }
}
