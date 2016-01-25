using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class vn
    {
        public vn()
        {
            this.activity_log = new List<activity_log>();
            this.bills = new List<bill>();
            this.bill_line = new List<bill_line>();
            this.castds = new List<castd>();
            this.cb_accredit_person = new List<cb_accredit_person>();
            this.cb_samples = new List<cb_samples>();
            this.ehs_training = new List<ehs_training>();
            this.energy_bl_svc_period = new List<energy_bl_svc_period>();
            this.eqs = new List<eq>();
            this.helpdesk_sla_response = new List<helpdesk_sla_response>();
            this.helpdesk_sla_steps = new List<helpdesk_sla_steps>();
            this.helpdesk_step_log = new List<helpdesk_step_log>();
            this.invoices = new List<invoice>();
            this.pbstds = new List<pbstd>();
            this.pnstds = new List<pnstd>();
            this.poes = new List<po>();
            this.pvs = new List<pv>();
            this.reglocs = new List<regloc>();
            this.regprograms = new List<regprogram>();
            this.regrequirements = new List<regrequirement>();
            this.resource_std = new List<resource_std>();
            this.rm_arrange_type = new List<rm_arrange_type>();
            this.vn_ac = new List<vn_ac>();
            this.waste_facilities = new List<waste_facilities>();
            this.waste_manifests = new List<waste_manifests>();
            this.waste_manifests1 = new List<waste_manifests>();
            this.waste_out = new List<waste_out>();
            this.work_pkg_bids = new List<work_pkg_bids>();
            this.work_pkgs = new List<work_pkgs>();
            this.wrs = new List<wr>();
        }

        public string address1 { get; set; }
        public string address2 { get; set; }
        public string alt_contact { get; set; }
        public string alt_fax { get; set; }
        public string alt_phone { get; set; }
        public string alt_title { get; set; }
        public decimal amt_bonded { get; set; }
        public string certifications { get; set; }
        public string city { get; set; }
        public string code_1099 { get; set; }
        public string company { get; set; }
        public string contact { get; set; }
        public string country { get; set; }
        public Nullable<System.DateTime> date_exp { get; set; }
        public Nullable<System.DateTime> date_last_updated { get; set; }
        public decimal delivery_perf { get; set; }
        public string description { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public string fed_tax_id { get; set; }
        public string insurance_cert1 { get; set; }
        public string insurance_cert2 { get; set; }
        public short is_active { get; set; }
        public string mwbe_code { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string phone { get; set; }
        public string postal_code { get; set; }
        public string pref_rating { get; set; }
        public string prob_type { get; set; }
        public string services { get; set; }
        public string state { get; set; }
        public string title { get; set; }
        public string vendor_type { get; set; }
        public string web_url { get; set; }
        public short wr_from_reserve { get; set; }
        public string vn_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<bill> bills { get; set; }
        public virtual ICollection<bill_line> bill_line { get; set; }
        public virtual ICollection<castd> castds { get; set; }
        public virtual ICollection<cb_accredit_person> cb_accredit_person { get; set; }
        public virtual ICollection<cb_samples> cb_samples { get; set; }
        public virtual City city1 { get; set; }
        public virtual ctry ctry { get; set; }
        public virtual ICollection<ehs_training> ehs_training { get; set; }
        public virtual ICollection<energy_bl_svc_period> energy_bl_svc_period { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual ICollection<helpdesk_sla_response> helpdesk_sla_response { get; set; }
        public virtual ICollection<helpdesk_sla_steps> helpdesk_sla_steps { get; set; }
        public virtual ICollection<helpdesk_step_log> helpdesk_step_log { get; set; }
        public virtual ICollection<invoice> invoices { get; set; }
        public virtual ICollection<pbstd> pbstds { get; set; }
        public virtual ICollection<pnstd> pnstds { get; set; }
        public virtual ICollection<po> poes { get; set; }
        public virtual probtype probtype { get; set; }
        public virtual ICollection<pv> pvs { get; set; }
        public virtual ICollection<regloc> reglocs { get; set; }
        public virtual ICollection<regprogram> regprograms { get; set; }
        public virtual ICollection<regrequirement> regrequirements { get; set; }
        public virtual ICollection<resource_std> resource_std { get; set; }
        public virtual ICollection<rm_arrange_type> rm_arrange_type { get; set; }
        public virtual state state1 { get; set; }
        public virtual ICollection<vn_ac> vn_ac { get; set; }
        public virtual ICollection<waste_facilities> waste_facilities { get; set; }
        public virtual ICollection<waste_manifests> waste_manifests { get; set; }
        public virtual ICollection<waste_manifests> waste_manifests1 { get; set; }
        public virtual ICollection<waste_out> waste_out { get; set; }
        public virtual ICollection<work_pkg_bids> work_pkg_bids { get; set; }
        public virtual ICollection<work_pkgs> work_pkgs { get; set; }
        public virtual ICollection<wr> wrs { get; set; }
    }
}
