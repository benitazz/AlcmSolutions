using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class site
    {
        public site()
        {
            this.activity_log = new List<activity_log>();
            this.bas_measurement_scope = new List<bas_measurement_scope>();
            this.bills = new List<bill>();
            this.bls = new List<bl>();
            this.cas = new List<ca>();
            this.compliance_locations = new List<compliance_locations>();
            this.docs_assigned = new List<docs_assigned>();
            this.ehs_incidents = new List<ehs_incidents>();
            this.ehs_incidents_sync = new List<ehs_incidents_sync>();
            this.eqs = new List<eq>();
            this.helpdesk_sla_request = new List<helpdesk_sla_request>();
            this.msds_location = new List<msds_location>();
            this.pmgens = new List<pmgen>();
            this.pms = new List<Pm>();
            this.programs = new List<program>();
            this.projects = new List<project>();
            this.properties = new List<Property>();
            this.resources = new List<resource>();
            this.rf_activity = new List<rf_activity>();
            this.rf_reader = new List<rf_reader>();
            this.vn_ac = new List<vn_ac>();
            this.waste_areas = new List<waste_areas>();
            this.waste_generators = new List<waste_generators>();
            this.work_roles_location = new List<work_roles_location>();
            this.wrs = new List<wr>();
            this.wies = new List<wy>();
        }

        public Nullable<decimal> acres { get; set; }
        public decimal area_em_dp { get; set; }
        public decimal area_ext_wall { get; set; }
        public decimal area_gp { get; set; }
        public decimal area_gp_comn { get; set; }
        public decimal area_gp_dp { get; set; }
        public decimal area_gross_ext { get; set; }
        public decimal area_gross_int { get; set; }
        public decimal area_nocup { get; set; }
        public decimal area_nocup_comn { get; set; }
        public decimal area_nocup_dp { get; set; }
        public decimal area_ocup { get; set; }
        public decimal area_ocup_comn { get; set; }
        public decimal area_ocup_dp { get; set; }
        public decimal area_rentable { get; set; }
        public decimal area_rm { get; set; }
        public decimal area_rm_comn { get; set; }
        public decimal area_rm_dp { get; set; }
        public decimal area_serv { get; set; }
        public decimal area_st_comn_gp { get; set; }
        public decimal area_st_comn_nocup { get; set; }
        public decimal area_st_comn_ocup { get; set; }
        public decimal area_st_comn_rm { get; set; }
        public decimal area_st_comn_serv { get; set; }
        public decimal area_su { get; set; }
        public decimal area_usable { get; set; }
        public decimal area_vert_pen { get; set; }
        public string city_id { get; set; }
        public decimal count_em { get; set; }
        public string ctry_id { get; set; }
        public string detail_dwg { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public Nullable<decimal> lat { get; set; }
        public Nullable<decimal> lon { get; set; }
        public string name { get; set; }
        public short no_bldgs { get; set; }
        public decimal ratio_ru { get; set; }
        public decimal ratio_ur { get; set; }
        public string regn_id { get; set; }
        public string site_photo { get; set; }
        public string state_id { get; set; }
        public string site_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual ICollection<bas_measurement_scope> bas_measurement_scope { get; set; }
        public virtual ICollection<bill> bills { get; set; }
        public virtual ICollection<bl> bls { get; set; }
        public virtual ICollection<ca> cas { get; set; }
        public virtual City city { get; set; }
        public virtual ICollection<compliance_locations> compliance_locations { get; set; }
        public virtual ctry ctry { get; set; }
        public virtual ICollection<docs_assigned> docs_assigned { get; set; }
        public virtual ICollection<ehs_incidents> ehs_incidents { get; set; }
        public virtual ICollection<ehs_incidents_sync> ehs_incidents_sync { get; set; }
        public virtual ICollection<eq> eqs { get; set; }
        public virtual ICollection<helpdesk_sla_request> helpdesk_sla_request { get; set; }
        public virtual ICollection<msds_location> msds_location { get; set; }
        public virtual ICollection<pmgen> pmgens { get; set; }
        public virtual ICollection<Pm> pms { get; set; }
        public virtual ICollection<program> programs { get; set; }
        public virtual ICollection<project> projects { get; set; }
        public virtual ICollection<Property> properties { get; set; }
        public virtual regn regn { get; set; }
        public virtual ICollection<resource> resources { get; set; }
        public virtual ICollection<rf_activity> rf_activity { get; set; }
        public virtual ICollection<rf_reader> rf_reader { get; set; }
        public virtual state state { get; set; }
        public virtual ICollection<vn_ac> vn_ac { get; set; }
        public virtual ICollection<waste_areas> waste_areas { get; set; }
        public virtual ICollection<waste_generators> waste_generators { get; set; }
        public virtual ICollection<work_roles_location> work_roles_location { get; set; }
        public virtual ICollection<wr> wrs { get; set; }
        public virtual ICollection<wy> wies { get; set; }
    }
}
