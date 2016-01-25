#region

using System.Collections.Generic;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The city.
    /// </summary>
    public sealed class City
    {
        /// <summary>
        /// Initializes ra new instance of the <see cref="City"/> class.
        /// </summary>
        public City()
        {
            this.Bls = new List<bl>();
            this.Companies = new List<Company>();
            this.ComplianceLocations = new List<compliance_locations>();
            this.Contacts = new List<Contact>();
            this.GbFpEgridZip = new List<gb_fp_egrid_zip>();
            this.Projteams = new List<ProjectTeam>();
            this.Properties = new List<Property>();
            this.Sites = new List<site>();
            this.VnAc = new List<vn_ac>();
            this.VnAc1 = new List<vn_ac>();
            this.VnAc2 = new List<vn_ac>();
            this.Vns = new List<vn>();
            this.WasteFacilities = new List<waste_facilities>();
        }

        /// <summary>
        /// Gets or sets the ctry identifier.
        /// </summary>
        /// <value>
        /// The ctry identifier.
        /// </value>
        public string ctry_id { get; set; }

        /// <summary>
        /// </summary>
        public string DetailDwg { get; set; }

        /// <summary>
        /// </summary>
        public string Dwgname { get; set; }

        /// <summary>
        /// Gets or sets the ehandle.
        /// </summary>
        public string Ehandle { get; set; }

        /// <summary>
        /// </summary>
        public int? geo_objectid { get; set; }

        /// <summary>
        /// </summary>
        public decimal? Lat { get; set; }

        /// <summary>
        /// </summary>
        public decimal? Lon { get; set; }

        /// <summary>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        public string regn_id { get; set; }

        /// <summary>
        /// </summary>
        public string timezone_id { get; set; }

        /// <summary>
        /// </summary>
        public string state_id { get; set; }

        /// <summary>
        /// </summary>
        public string city_id { get; set; }

        /// <summary>
        /// </summary>
        public afm_timezones AfmTimezones { get; set; }

        /// <summary>
        /// </summary>
        public ICollection<bl> Bls { get; set; }

        /// <summary>
        /// </summary>
        public ctry Ctry { get; set; }

        /// <summary>
        /// </summary>
        public regn Regn { get; set; }

        /// <summary>
        /// </summary>
        public state State { get; set; }

        /// <summary>
        /// </summary>
        public ICollection<Company> Companies { get; set; }

        /// <summary>
        /// </summary>
        public ICollection<compliance_locations> ComplianceLocations { get; set; }

        /// <summary>
        /// </summary>
        public ICollection<Contact> Contacts { get; set; }

        /// <summary>
        /// </summary>
        public ICollection<gb_fp_egrid_zip> GbFpEgridZip { get; set; }

        /// <summary>
        /// </summary>
        public ICollection<ProjectTeam> Projteams { get; set; }

        /// <summary>
        /// </summary>
        public ICollection<Property> Properties { get; set; }

        /// <summary>
        /// </summary>
        public ICollection<site> Sites { get; set; }

        /// <summary>
        /// </summary>
        public ICollection<vn_ac> VnAc { get; set; }

        /// <summary>
        /// </summary>
        public ICollection<vn_ac> VnAc1 { get; set; }

        /// <summary>
        /// </summary>
        public ICollection<vn_ac> VnAc2 { get; set; }

        /// <summary>
        /// </summary>
        public ICollection<vn> Vns { get; set; }

        /// <summary>
        /// </summary>
        public ICollection<waste_facilities> WasteFacilities { get; set; }
    }
}