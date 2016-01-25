#region

using System;
using System.Collections.Generic;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The regn.
    /// </summary>
    public partial class regn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="regn"/> class.
        /// </summary>
        public regn()
        {
            this.AfmHolidayDates = new List<afm_holiday_dates>();
            this.Bls = new List<bl>();
            this.Cities = new List<City>();
            this.Companies = new List<Company>();
            this.ComplianceLocations = new List<compliance_locations>();
            this.Contacts = new List<Contact>();
            this.Counties = new List<County>();
            this.Projteams = new List<ProjectTeam>();
            this.Properties = new List<Property>();
            this.Sites = new List<site>();
            this.States = new List<state>();
        }

        /// <summary>
        /// Gets or sets the geo_objectid.
        /// </summary>
        public int? geo_objectid { get; set; }

        /// <summary>
        /// Gets or sets the hpattern.
        /// </summary>
        public string Hpattern { get; set; }

        /// <summary>
        /// Gets or sets the hpattern_acad.
        /// </summary>
        public string HpatternAcad { get; set; }

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
        /// Gets or sets the ctry_id.
        /// </summary>
        public string ctry_id { get; set; }

        /// <summary>
        /// Gets or sets the regn_id.
        /// </summary>
        public string regn_id { get; set; }

        /// <summary>
        /// Gets or sets the afm_holiday_dates.
        /// </summary>
        public virtual ICollection<afm_holiday_dates> AfmHolidayDates { get; set; }

        /// <summary>
        /// Gets or sets the bls.
        /// </summary>
        public virtual ICollection<bl> Bls { get; set; }

        /// <summary>
        /// Gets or sets the cities.
        /// </summary>
        public virtual ICollection<City> Cities { get; set; }

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
        /// Gets or sets the counties.
        /// </summary>
        public virtual ICollection<County> Counties { get; set; }

        /// <summary>
        /// Gets or sets the ctry.
        /// </summary>
        public virtual ctry Ctry { get; set; }

        /// <summary>
        /// Gets or sets the projteams.
        /// </summary>
        public virtual ICollection<ProjectTeam> Projteams { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        public virtual ICollection<Property> Properties { get; set; }

        /// <summary>
        /// Gets or sets the sites.
        /// </summary>
        public virtual ICollection<site> Sites { get; set; }

        /// <summary>
        /// Gets or sets the states.
        /// </summary>
        public virtual ICollection<state> States { get; set; }
    }
}