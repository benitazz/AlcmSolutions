namespace DurandalAuth.Domain.Models
{
    #region

    using System;
    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// The company.
    /// </summary>
    public partial class Company
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        public Company()
        {
            this.Acs = new List<ac>();
            this.Contacts = new List<Contact>();
            this.MsdsData = new List<msds_data>();
            this.MsdsData1 = new List<msds_data>();
            this.MsdsData2 = new List<msds_data>();
            this.Projteams = new List<ProjectTeam>();
            this.Regulations = new List<regulation>();
            this.Regviolations = new List<regviolation>();
        }

        /// <summary>
        /// Gets or sets the county_id.
        /// </summary>
        public string county_id { get; set; }

        /// <summary>
        /// Gets or sets the ctry_id.
        /// </summary>
        public string ctry_id { get; set; }

        /// <summary>
        /// Gets or sets the date_last_updated.
        /// </summary>
        public DateTime? DateLastUpdated { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the fax.
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// Gets or sets the option 1.
        /// </summary>
        public string Option1 { get; set; }

        /// <summary>
        /// Gets or sets the option 2.
        /// </summary>
        public string Option2 { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the regn_id.
        /// </summary>
        public string regn_id { get; set; }

        /// <summary>
        /// Gets or sets the state_id.
        /// </summary>
        public string state_id { get; set; }

        /// <summary>
        /// Gets or sets the web_url.
        /// </summary>
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// Gets or sets the address 1.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the address 2.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the alt_fax.
        /// </summary>
        public string AltFax { get; set; }

        /// <summary>
        /// Gets or sets the alt_phone.
        /// </summary>
        public string AltPhone { get; set; }

        /// <summary>
        /// Gets or sets the city_id.
        /// </summary>
        public string city_id { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets the company 1.
        /// </summary>
        public string Company1 { get; set; }

        /// <summary>
        /// Gets or sets the acs.
        /// </summary>
        public virtual ICollection<ac> Acs { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        public virtual City City { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        public virtual County County { get; set; }

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
        /// Gets or sets the contacts.
        /// </summary>
        public virtual ICollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Gets or sets the msds_data.
        /// </summary>
        public virtual ICollection<msds_data> MsdsData { get; set; }

        /// <summary>
        /// Gets or sets the msds_data 1.
        /// </summary>
        public virtual ICollection<msds_data> MsdsData1 { get; set; }

        /// <summary>
        /// Gets or sets the msds_data 2.
        /// </summary>
        public virtual ICollection<msds_data> MsdsData2 { get; set; }

        /// <summary>
        /// Gets or sets the projteams.
        /// </summary>
        public virtual ICollection<ProjectTeam> Projteams { get; set; }

        /// <summary>
        /// Gets or sets the regulations.
        /// </summary>
        public virtual ICollection<regulation> Regulations { get; set; }

        /// <summary>
        /// Gets or sets the regviolations.
        /// </summary>
        public virtual ICollection<regviolation> Regviolations { get; set; }
    }
}