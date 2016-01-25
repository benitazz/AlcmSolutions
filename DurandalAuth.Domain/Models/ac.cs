using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ac
    {
        public ac()
        {
            this.acbus = new List<acbu>();
            this.activity_log = new List<activity_log>();
            this.bls = new List<bl>();
            this.budget_item = new List<budget_item>();
            this.cost_tran_recur = new List<cost_tran_recur>();
            this.cost_tran_sched = new List<cost_tran_sched>();
            this.invoices = new List<invoice>();
            this.ls = new List<l>();
            this.moes = new List<mo>();
            this.orgs = new List<org>();
            this.pmps = new List<pmp>();
            this.projects = new List<project>();
            this.properties = new List<Property>();
            this.reserves = new List<reserve>();
            this.resources = new List<resource>();
            this.rm_arrange = new List<rm_arrange>();
            this.rm_reserve = new List<rm_reserve>();
            this.rmpcts = new List<rmpct>();
            this.woes = new List<wo>();
            this.wrs = new List<wr>();
        }

        public string comments { get; set; }
        public string company { get; set; }
        public string description { get; set; }
        public string hierarchy_ids { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string ac_id { get; set; }
        public virtual Company company1 { get; set; }
        public virtual ICollection<acbu> acbus { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<bl> bls { get; set; }
        public virtual ICollection<budget_item> budget_item { get; set; }
        public virtual ICollection<cost_tran_recur> cost_tran_recur { get; set; }
        public virtual ICollection<cost_tran_sched> cost_tran_sched { get; set; }
        public virtual ICollection<invoice> invoices { get; set; }
        public virtual ICollection<l> ls { get; set; }
        public virtual ICollection<mo> moes { get; set; }
        public virtual ICollection<org> orgs { get; set; }
        public virtual ICollection<pmp> pmps { get; set; }
        public virtual ICollection<project> projects { get; set; }
        public virtual ICollection<Property> properties { get; set; }
        public virtual ICollection<reserve> reserves { get; set; }
        public virtual ICollection<resource> resources { get; set; }
        public virtual ICollection<rm_arrange> rm_arrange { get; set; }
        public virtual ICollection<rm_reserve> rm_reserve { get; set; }
        public virtual ICollection<rmpct> rmpcts { get; set; }
        public virtual ICollection<wo> woes { get; set; }
        public virtual ICollection<wr> wrs { get; set; }
    }
}
