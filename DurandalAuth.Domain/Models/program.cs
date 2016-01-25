using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class program
    {
        public program()
        {
            this.fundings = new List<funding>();
            this.prog_budget_items = new List<prog_budget_items>();
            this.projects = new List<project>();
        }

        public Nullable<System.DateTime> date_init { get; set; }
        public string description { get; set; }
        public string entered_by { get; set; }
        public string objectives { get; set; }
        public string program_num { get; set; }
        public string program_type { get; set; }
        public string scope { get; set; }
        public string site_id { get; set; }
        public short status { get; set; }
        public string summary { get; set; }
        public string program_id { get; set; }
        public virtual Em em { get; set; }
        public virtual ICollection<funding> fundings { get; set; }
        public virtual ICollection<prog_budget_items> prog_budget_items { get; set; }
        public virtual programtype programtype { get; set; }
        public virtual site site { get; set; }
        public virtual ICollection<project> projects { get; set; }
    }
}
