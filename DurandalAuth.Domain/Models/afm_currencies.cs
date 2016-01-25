using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_currencies
    {
        public afm_currencies()
        {
            this.afm_conversions = new List<afm_conversions>();
            this.afm_conversions1 = new List<afm_conversions>();
            this.cost_tran = new List<cost_tran>();
            this.cost_tran1 = new List<cost_tran>();
            this.cost_tran_recur = new List<cost_tran_recur>();
            this.cost_tran_recur1 = new List<cost_tran_recur>();
            this.cost_tran_sched = new List<cost_tran_sched>();
            this.cost_tran_sched1 = new List<cost_tran_sched>();
            this.invoices = new List<invoice>();
            this.invoice_payment = new List<invoice_payment>();
        }

        public string currency_symbol { get; set; }
        public string description { get; set; }
        public string description_01 { get; set; }
        public string description_02 { get; set; }
        public string description_03 { get; set; }
        public string description_ch { get; set; }
        public string description_de { get; set; }
        public string description_es { get; set; }
        public string description_fr { get; set; }
        public string description_it { get; set; }
        public string description_jp { get; set; }
        public string description_ko { get; set; }
        public string description_nl { get; set; }
        public string description_no { get; set; }
        public string description_zh { get; set; }
        public string comments { get; set; }
        public string currency_id { get; set; }
        public virtual ICollection<afm_conversions> afm_conversions { get; set; }
        public virtual ICollection<afm_conversions> afm_conversions1 { get; set; }
        public virtual ICollection<cost_tran> cost_tran { get; set; }
        public virtual ICollection<cost_tran> cost_tran1 { get; set; }
        public virtual ICollection<cost_tran_recur> cost_tran_recur { get; set; }
        public virtual ICollection<cost_tran_recur> cost_tran_recur1 { get; set; }
        public virtual ICollection<cost_tran_sched> cost_tran_sched { get; set; }
        public virtual ICollection<cost_tran_sched> cost_tran_sched1 { get; set; }
        public virtual ICollection<invoice> invoices { get; set; }
        public virtual ICollection<invoice_payment> invoice_payment { get; set; }
    }
}
