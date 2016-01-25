using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class dv
    {
        public dv()
        {
            this.activity_log = new List<activity_log>();
            this.budget_item = new List<budget_item>();
            this.cost_tran_recur = new List<cost_tran_recur>();
            this.cost_tran_sched = new List<cost_tran_sched>();
            this.dps = new List<dp>();
            this.dpbus = new List<dpbu>();
            this.ems = new List<Em>();
            this.em_sync = new List<em_sync>();
            this.eqs = new List<eq>();
            this.eq_eqstdcnts = new List<eq_eqstdcnts>();
            this.eq_reserve = new List<eq_reserve>();
            this.fns = new List<fn>();
            this.fn_fnstdcnts = new List<fn_fnstdcnts>();
            this.fs = new List<f>();
            this.gps = new List<gp>();
            this.helpdesk_sla_request = new List<helpdesk_sla_request>();
            this.mo_churn = new List<mo_churn>();
            this.moes = new List<mo>();
            this.pms = new List<Pm>();
            this.projects = new List<project>();
            this.recovery_team = new List<recovery_team>();
            this.reserves = new List<reserve>();
            this.rms = new List<Rm>();
            this.rm_reserve = new List<rm_reserve>();
            this.rmpcts = new List<rmpct>();
            this.rmpctmob_sync = new List<rmpctmob_sync>();
            this.sb_items = new List<sb_items>();
            this.sbaffins = new List<sbaffin>();
            this.sbaffins1 = new List<sbaffin>();
            this.surveyrm_sync = new List<surveyrm_sync>();
            this.ta_audit = new List<ta_audit>();
            this.tas = new List<ta>();
            this.ta_fnstdcnts = new List<ta_fnstdcnts>();
            this.visitors = new List<visitor>();
            this.woes = new List<wo>();
            this.wrs = new List<wr>();
        }

        public decimal area_avg_em { get; set; }
        public decimal area_chargable { get; set; }
        public decimal area_comn { get; set; }
        public decimal area_comn_gp { get; set; }
        public decimal area_comn_nocup { get; set; }
        public decimal area_comn_ocup { get; set; }
        public decimal area_comn_rm { get; set; }
        public decimal area_comn_serv { get; set; }
        public decimal area_gp { get; set; }
        public decimal area_nocup { get; set; }
        public decimal area_ocup { get; set; }
        public decimal area_rm { get; set; }
        public decimal area_second_circ { get; set; }
        public string bu_id { get; set; }
        public decimal cost { get; set; }
        public int count_em { get; set; }
        public string head { get; set; }
        public string hpattern_acad { get; set; }
        public string name { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string dv_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual bu bu { get; set; }
        public virtual ICollection<budget_item> budget_item { get; set; }
        public virtual ICollection<cost_tran_recur> cost_tran_recur { get; set; }
        public virtual ICollection<cost_tran_sched> cost_tran_sched { get; set; }
        public virtual ICollection<dp> dps { get; set; }
        public virtual ICollection<dpbu> dpbus { get; set; }
        public virtual ICollection<Em> ems { get; set; }
        public virtual ICollection<em_sync> em_sync { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual ICollection<eq_eqstdcnts> eq_eqstdcnts { get; set; }
        public virtual ICollection<eq_reserve> eq_reserve { get; set; }
        public virtual ICollection<fn> fns { get; set; }
        public virtual ICollection<fn_fnstdcnts> fn_fnstdcnts { get; set; }
        public virtual ICollection<f> fs { get; set; }
        public virtual ICollection<gp> gps { get; set; }
        public virtual ICollection<helpdesk_sla_request> helpdesk_sla_request { get; set; }
        public virtual ICollection<mo_churn> mo_churn { get; set; }
        public virtual ICollection<mo> moes { get; set; }
        public virtual ICollection<Pm> pms { get; set; }
        public virtual ICollection<project> projects { get; set; }
        public virtual ICollection<recovery_team> recovery_team { get; set; }
        public virtual ICollection<reserve> reserves { get; set; }
        public virtual ICollection<Rm> rms { get; set; }
        public virtual ICollection<rm_reserve> rm_reserve { get; set; }
        public virtual ICollection<rmpct> rmpcts { get; set; }
        public virtual ICollection<rmpctmob_sync> rmpctmob_sync { get; set; }
        public virtual ICollection<sb_items> sb_items { get; set; }
        public virtual ICollection<sbaffin> sbaffins { get; set; }
        public virtual ICollection<sbaffin> sbaffins1 { get; set; }
        public virtual ICollection<surveyrm_sync> surveyrm_sync { get; set; }
        public virtual ICollection<ta_audit> ta_audit { get; set; }
        public virtual ICollection<ta> tas { get; set; }
        public virtual ICollection<ta_fnstdcnts> ta_fnstdcnts { get; set; }
        public virtual ICollection<visitor> visitors { get; set; }
        public virtual ICollection<wo> woes { get; set; }
        public virtual ICollection<wr> wrs { get; set; }
    }
}
