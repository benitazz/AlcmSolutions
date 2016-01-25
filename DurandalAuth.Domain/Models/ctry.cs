using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ctry
    {
        public ctry()
        {
            this.afm_holiday_dates = new List<afm_holiday_dates>();
            this.bls = new List<bl>();
            this.cities = new List<City>();
            this.companies = new List<Company>();
            this.compliance_locations = new List<compliance_locations>();
            this.contacts = new List<Contact>();
            this.cost_tran = new List<cost_tran>();
            this.cost_tran_recur = new List<cost_tran_recur>();
            this.cost_tran_sched = new List<cost_tran_sched>();
            this.counties = new List<County>();
            this.projteams = new List<ProjectTeam>();
            this.properties = new List<Property>();
            this.regns = new List<regn>();
            this.sites = new List<site>();
            this.states = new List<state>();
            this.vat_percent = new List<vat_percent>();
            this.vn_ac = new List<vn_ac>();
            this.vn_ac1 = new List<vn_ac>();
            this.vn_ac2 = new List<vn_ac>();
            this.vns = new List<vn>();
            this.waste_facilities = new List<waste_facilities>();
        }

        public string detail_dwg { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public Nullable<int> geo_objectid { get; set; }
        public string geo_region_id { get; set; }
        public Nullable<decimal> lat { get; set; }
        public Nullable<decimal> lon { get; set; }
        public string name { get; set; }
        public string ctry_id { get; set; }
        public virtual ICollection<afm_holiday_dates> afm_holiday_dates { get; set; }
        public virtual ICollection<bl> bls { get; set; }
        public virtual ICollection<City> cities { get; set; }
        public virtual ICollection<Company> companies { get; set; }
        public virtual ICollection<compliance_locations> compliance_locations { get; set; }
        public virtual ICollection<Contact> contacts { get; set; }
        public virtual ICollection<cost_tran> cost_tran { get; set; }
        public virtual ICollection<cost_tran_recur> cost_tran_recur { get; set; }
        public virtual ICollection<cost_tran_sched> cost_tran_sched { get; set; }
        public virtual ICollection<County> counties { get; set; }
        public virtual geo_region geo_region { get; set; }
        public virtual ICollection<ProjectTeam> projteams { get; set; }
        public virtual ICollection<Property> properties { get; set; }
        public virtual ICollection<regn> regns { get; set; }
        public virtual ICollection<site> sites { get; set; }
        public virtual ICollection<state> states { get; set; }
        public virtual ICollection<vat_percent> vat_percent { get; set; }
        public virtual ICollection<vn_ac> vn_ac { get; set; }
        public virtual ICollection<vn_ac> vn_ac1 { get; set; }
        public virtual ICollection<vn_ac> vn_ac2 { get; set; }
        public virtual ICollection<vn> vns { get; set; }
        public virtual ICollection<waste_facilities> waste_facilities { get; set; }
    }
}
