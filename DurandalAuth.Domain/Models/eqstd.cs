using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class eqstd
    {
        public eqstd()
        {
            this.compliance_locations = new List<compliance_locations>();
            this.ehs_ppe_types = new List<ehs_ppe_types>();
            this.ehs_training = new List<ehs_training>();
            this.eqs = new List<eq>();
            this.eq_eqstdcnts = new List<eq_eqstdcnts>();
            this.eq_trial = new List<eq_trial>();
            this.eqprphs = new List<eqprph>();
            this.gb_fp_refrig_data = new List<gb_fp_refrig_data>();
            this.helpdesk_sla_request = new List<helpdesk_sla_request>();
            this.mo_eq = new List<mo_eq>();
            this.pmps = new List<pmp>();
            this.portcfgs = new List<portcfg>();
            this.questionnaire_map = new List<questionnaire_map>();
        }

        public string hpattern_acad { get; set; }
        public string image_file { get; set; }
        public string image_of_block { get; set; }
        public short is_multiplexing { get; set; }
        public string mfr { get; set; }
        public string modelno { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public decimal price { get; set; }
        public short qty_life_expct { get; set; }
        public decimal spec_amperage { get; set; }
        public decimal spec_btu { get; set; }
        public decimal spec_capacity { get; set; }
        public decimal spec_depth { get; set; }
        public decimal spec_height { get; set; }
        public int spec_phase { get; set; }
        public decimal spec_power { get; set; }
        public decimal spec_voltage { get; set; }
        public decimal spec_width { get; set; }
        public string symbol { get; set; }
        public string tc_area_level { get; set; }
        public string tc_contained_tbls { get; set; }
        public string tc_eq_type { get; set; }
        public string tc_level { get; set; }
        public Nullable<short> tc_npositions { get; set; }
        public string tc_service { get; set; }
        public decimal area { get; set; }
        public string category { get; set; }
        public decimal cost_moving { get; set; }
        public string csi_id { get; set; }
        public string description { get; set; }
        public string doc_block { get; set; }
        public string doc_graphic { get; set; }
        public string eq_std { get; set; }
        public virtual afm_tclevel afm_tclevel { get; set; }
        public virtual ICollection<compliance_locations> compliance_locations { get; set; }
        public virtual csi csi { get; set; }
        public virtual ICollection<ehs_ppe_types> ehs_ppe_types { get; set; }
        public virtual ICollection<ehs_training> ehs_training { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual ICollection<eq_eqstdcnts> eq_eqstdcnts { get; set; }
        public virtual ICollection<eq_trial> eq_trial { get; set; }
        public virtual ICollection<eqprph> eqprphs { get; set; }
        public virtual ICollection<gb_fp_refrig_data> gb_fp_refrig_data { get; set; }
        public virtual ICollection<helpdesk_sla_request> helpdesk_sla_request { get; set; }
        public virtual ICollection<mo_eq> mo_eq { get; set; }
        public virtual ICollection<pmp> pmps { get; set; }
        public virtual ICollection<portcfg> portcfgs { get; set; }
        public virtual ICollection<questionnaire_map> questionnaire_map { get; set; }
    }
}
