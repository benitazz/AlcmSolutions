using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ls_clause_type
    {
        public ls_clause_type()
        {
            this.ls_resp = new List<ls_resp>();
        }

        public string clause_type_id { get; set; }
        public virtual ICollection<ls_resp> ls_resp { get; set; }
    }
}
