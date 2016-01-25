using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class state
    {
        public state()
        {
            this.bls = new List<bl>();
            this.cb_accredit_source = new List<cb_accredit_source>();
            this.cities = new List<City>();
            this.companies = new List<Company>();
            this.compliance_locations = new List<compliance_locations>();
            this.contacts = new List<Contact>();
            this.counties = new List<County>();
            this.gb_fp_egrid_zip = new List<gb_fp_egrid_zip>();
            this.projteams = new List<ProjectTeam>();
            this.properties = new List<Property>();
            this.sites = new List<site>();
            this.vn_ac = new List<vn_ac>();
            this.vn_ac1 = new List<vn_ac>();
            this.vn_ac2 = new List<vn_ac>();
            this.vns = new List<vn>();
            this.waste_facilities = new List<waste_facilities>();
        }

        public string ctry_id { get; set; }
        public string detail_dwg { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string name { get; set; }
        public string regn_id { get; set; }
        public string state_id { get; set; }
        public virtual ICollection<bl> bls { get; set; }
        public virtual ICollection<cb_accredit_source> cb_accredit_source { get; set; }
        public virtual ICollection<City> cities { get; set; }
        public virtual ICollection<Company> companies { get; set; }
        public virtual ICollection<compliance_locations> compliance_locations { get; set; }
        public virtual ICollection<Contact> contacts { get; set; }
        public virtual ICollection<County> counties { get; set; }
        public virtual ctry ctry { get; set; }
        public virtual ICollection<gb_fp_egrid_zip> gb_fp_egrid_zip { get; set; }
        public virtual ICollection<ProjectTeam> projteams { get; set; }
        public virtual ICollection<Property> properties { get; set; }
        public virtual regn regn { get; set; }
        public virtual ICollection<site> sites { get; set; }
        public virtual ICollection<vn_ac> vn_ac { get; set; }
        public virtual ICollection<vn_ac> vn_ac1 { get; set; }
        public virtual ICollection<vn_ac> vn_ac2 { get; set; }
        public virtual ICollection<vn> vns { get; set; }
        public virtual ICollection<waste_facilities> waste_facilities { get; set; }
    }
}
