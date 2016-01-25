using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_restriction_cat
    {
        public ehs_restriction_cat()
        {
            this.ehs_restrictions = new List<ehs_restrictions>();
        }

        public string description { get; set; }
        public string restriction_category_id { get; set; }
        public virtual ICollection<ehs_restrictions> ehs_restrictions { get; set; }
    }
}
