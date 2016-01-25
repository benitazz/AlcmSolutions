#region

using System.Collections.Generic;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The county.
    /// </summary>
    public class County
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="County"/> class.
        /// </summary>
        public County()
        {
            this.Companies = new List<Company>();
            this.ComplianceLocations = new List<compliance_locations>();
            this.Contacts = new List<Contact>();
            this.ProjectTeams = new List<ProjectTeam>();
            this.Properties = new List<Property>();
        }

        /// <summary>
        /// Gets or sets the ctry_id.
        /// </summary>
        public string ctry_id { get; set; }

        /// <summary>
        /// Gets or sets the dwgname.
        /// </summary>
        public string Dwgname { get; set; }

        /// <summary>
        /// Gets or sets the ehandle.
        /// </summary>
        public string Ehandle { get; set; }

        /// <summary>
        /// Gets or sets the geo_objectid.
        /// </summary>
        public int? geo_objectid { get; set; }

        /// <summary>
        /// Gets or sets the lat.
        /// </summary>
        public decimal? Lat { get; set; }

        /// <summary>
        /// Gets or sets the lon.
        /// </summary>
        public decimal? Lon { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the regn_id.
        /// </summary>
        public string regn_id { get; set; }

        /// <summary>
        /// Gets or sets the state_id.
        /// </summary>
        public string state_id { get; set; }

        /// <summary>
        /// Gets or sets the county_id.
        /// </summary>
        public string county_id { get; set; }

        /// <summary>
        /// Gets or sets the companies.
        /// </summary>
        public virtual ICollection<Company> Companies { get; set; }

        /// <summary>
        /// Gets or sets the compliance_locations.
        /// </summary>
        public virtual ICollection<compliance_locations> ComplianceLocations { get; set; }

        /// <summary>
        /// Gets or sets the contacts.
        /// </summary>
        public virtual ICollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Gets or sets the ctry.
        /// </summary>
        public virtual ctry Ctry { get; set; }

        /// <summary>
        /// Gets or sets the regn.
        /// </summary>
        public virtual regn Regn { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public virtual state State { get; set; }

        /// <summary>
        /// Gets or sets the project teams.
        /// </summary>
        public virtual ICollection<ProjectTeam> ProjectTeams { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        public virtual ICollection<Property> Properties { get; set; }
    }
}