using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class budget
    {
        public budget()
        {
            this.budget_item = new List<budget_item>();
            this.prog_budget_items = new List<prog_budget_items>();
        }

        public string description { get; set; }
        public string budget_id { get; set; }
        public virtual ICollection<budget_item> budget_item { get; set; }
        public virtual ICollection<prog_budget_items> prog_budget_items { get; set; }
    }
}
