using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cost_class
    {
        public cost_class()
        {
            this.cost_cat = new List<cost_cat>();
        }

        public string cost_super_class { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string cost_class_id { get; set; }
        public virtual ICollection<cost_cat> cost_cat { get; set; }
    }
}
