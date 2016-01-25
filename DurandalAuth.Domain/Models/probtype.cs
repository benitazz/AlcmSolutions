using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class probtype
    {
        public probtype()
        {
            this.activity_log = new List<activity_log>();
            this.activity_log1 = new List<activity_log>();
            this.activity_log_sync = new List<activity_log_sync>();
            this.activitytypes = new List<activitytype>();
            this.cb_accredit_person = new List<cb_accredit_person>();
            this.cb_accredit_source = new List<cb_accredit_source>();
            this.cb_accredit_type = new List<cb_accredit_type>();
            this.cb_hazard_rank = new List<cb_hazard_rank>();
            this.cb_hazard_rating = new List<cb_hazard_rating>();
            this.cb_hazard_status = new List<cb_hazard_status>();
            this.cb_hcm = new List<cb_hcm>();
            this.cb_hcm_class = new List<cb_hcm_class>();
            this.cb_hcm_cond = new List<cb_hcm_cond>();
            this.cb_hcm_loc_typ = new List<cb_hcm_loc_typ>();
            this.cb_sample_comp = new List<cb_sample_comp>();
            this.cb_units = new List<cb_units>();
            this.helpdesk_sla_request = new List<helpdesk_sla_request>();
            this.projects = new List<project>();
            this.vns = new List<vn>();
            this.wrs = new List<wr>();
        }

        public string cas_num { get; set; }
        public string comments { get; set; }
        public string description { get; set; }
        public string hierarchy_ids { get; set; }
        public string prob_class { get; set; }
        public string prob_type { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<activity_log> activity_log1 { get; set; }
        public virtual ICollection<activity_log_sync> activity_log_sync { get; set; }
        public virtual ICollection<activitytype> activitytypes { get; set; }
        public virtual ICollection<cb_accredit_person> cb_accredit_person { get; set; }
        public virtual ICollection<cb_accredit_source> cb_accredit_source { get; set; }
        public virtual ICollection<cb_accredit_type> cb_accredit_type { get; set; }
        public virtual ICollection<cb_hazard_rank> cb_hazard_rank { get; set; }
        public virtual ICollection<cb_hazard_rating> cb_hazard_rating { get; set; }
        public virtual ICollection<cb_hazard_status> cb_hazard_status { get; set; }
        public virtual ICollection<cb_hcm> cb_hcm { get; set; }
        public virtual ICollection<cb_hcm_class> cb_hcm_class { get; set; }
        public virtual ICollection<cb_hcm_cond> cb_hcm_cond { get; set; }
        public virtual ICollection<cb_hcm_loc_typ> cb_hcm_loc_typ { get; set; }
        public virtual ICollection<cb_sample_comp> cb_sample_comp { get; set; }
        public virtual ICollection<cb_units> cb_units { get; set; }
        public virtual ICollection<helpdesk_sla_request> helpdesk_sla_request { get; set; }
        public virtual ICollection<project> projects { get; set; }
        public virtual ICollection<vn> vns { get; set; }
        public virtual ICollection<wr> wrs { get; set; }
    }
}
