using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ehs_training_cat
    {
        public ehs_training_cat()
        {
            this.ehs_training = new List<ehs_training>();
        }

        public string description { get; set; }
        public string training_category_id { get; set; }
        public virtual ICollection<ehs_training> ehs_training { get; set; }
    }
}
