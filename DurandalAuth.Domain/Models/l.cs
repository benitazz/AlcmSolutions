using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class l
    {
        public l()
        {
            this.activity_log = new List<activity_log>();
            this.budget_item = new List<budget_item>();
            this.ccost_sum = new List<ccost_sum>();
            this.contacts = new List<Contact>();
            this.cost_index_trans = new List<cost_index_trans>();
            this.cost_tran_recur = new List<cost_tran_recur>();
            this.cost_tran_sched = new List<cost_tran_sched>();
            this.docs_assigned = new List<docs_assigned>();
            this.gps = new List<gp>();
            this.invoices = new List<invoice>();
            this.ls_amendment = new List<ls_amendment>();
            this.ls_cam_rec_report = new List<ls_cam_rec_report>();
            this.ls_chrgbck_agree = new List<ls_chrgbck_agree>();
            this.ls_comm = new List<ls_comm>();
            this.ls_resp = new List<ls_resp>();
            this.ops = new List<op>();
            this.pas = new List<pa>();
            this.parkings = new List<parking>();
            this.rms = new List<Rm>();
            this.sus = new List<su>();
            this.contacts1 = new List<Contact>();
        }

        public string ac_id { get; set; }
        public decimal amount_base_rent { get; set; }
        public decimal amount_operating { get; set; }
        public decimal amount_other { get; set; }
        public decimal amount_pct_rent { get; set; }
        public decimal amount_security { get; set; }
        public decimal amount_taxes { get; set; }
        public decimal amount_tot_rent_exp { get; set; }
        public decimal amount_tot_rent_inc { get; set; }
        public Nullable<decimal> area_common { get; set; }
        public Nullable<decimal> area_negotiated { get; set; }
        public Nullable<decimal> area_rentable { get; set; }
        public Nullable<decimal> area_usable { get; set; }
        public short automatic_renewal { get; set; }
        public string bl_id { get; set; }
        public string comments { get; set; }
        public short cost_index { get; set; }
        public Nullable<System.DateTime> date_cost_anal_end { get; set; }
        public Nullable<System.DateTime> date_cost_anal_start { get; set; }
        public Nullable<System.DateTime> date_costs_last_calcd { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<System.DateTime> date_move { get; set; }
        public Nullable<System.DateTime> date_start { get; set; }
        public string description { get; set; }
        public string doc { get; set; }
        public string floors { get; set; }
        public string hpattern { get; set; }
        public string hpattern_acad { get; set; }
        public string image_doc1 { get; set; }
        public string image_doc2 { get; set; }
        public string image_doc3 { get; set; }
        public string landlord_tenant { get; set; }
        public string ld_contact { get; set; }
        public string ld_name { get; set; }
        public string lease_sublease { get; set; }
        public string lease_type { get; set; }
        public string ls_parent_id { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public short owned { get; set; }
        public string pr_id { get; set; }
        public int qty_occupancy { get; set; }
        public int qty_suite_occupancy { get; set; }
        public short signed { get; set; }
        public string space_use { get; set; }
        public string template_name { get; set; }
        public string tn_contact { get; set; }
        public string tn_name { get; set; }
        public short use_as_template { get; set; }
        public short vat_exclude { get; set; }
        public string ls_id { get; set; }
        public virtual ac ac { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual bl bl { get; set; }
        public virtual ICollection<budget_item> budget_item { get; set; }
        public virtual ICollection<ccost_sum> ccost_sum { get; set; }
        public virtual ICollection<Contact> contacts { get; set; }
        public virtual ICollection<cost_index_trans> cost_index_trans { get; set; }
        public virtual ICollection<cost_tran_recur> cost_tran_recur { get; set; }
        public virtual ICollection<cost_tran_sched> cost_tran_sched { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
        public virtual ICollection<gp> gps { get; set; }
        public virtual ICollection<invoice> invoices { get; set; }
        public virtual ICollection<ls_amendment> ls_amendment { get; set; }
        public virtual ls_cam_profile ls_cam_profile { get; set; }
        public virtual ICollection<ls_cam_rec_report> ls_cam_rec_report { get; set; }
        public virtual ICollection<ls_chrgbck_agree> ls_chrgbck_agree { get; set; }
        public virtual ICollection<ls_comm> ls_comm { get; set; }
        public virtual ls_index_profile ls_index_profile { get; set; }
        public virtual Property property { get; set; }
        public virtual ICollection<ls_resp> ls_resp { get; set; }
        public virtual ICollection<op> ops { get; set; }
        public virtual ICollection<pa> pas { get; set; }
        public virtual ICollection<parking> parkings { get; set; }
        public virtual ICollection<Rm> rms { get; set; }
        public virtual ICollection<su> sus { get; set; }
        public virtual ICollection<Contact> contacts1 { get; set; }
    }
}
