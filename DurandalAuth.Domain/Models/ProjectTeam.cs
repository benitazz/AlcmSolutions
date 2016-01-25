namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The project team.
    /// </summary>
    public class ProjectTeam
    {
        /// <summary>
        /// Gets or sets the address 1.
        /// </summary>
        public string address1 { get; set; }

        /// <summary>
        /// Gets or sets the address 2.
        /// </summary>
        public string address2 { get; set; }

        /// <summary>
        /// Gets or sets the bl_id.
        /// </summary>
        public string bl_id { get; set; }

        /// <summary>
        /// Gets or sets the city_id.
        /// </summary>
        public string city_id { get; set; }

        /// <summary>
        /// Gets or sets the company.
        /// </summary>
        public string company { get; set; }

        /// <summary>
        /// Gets or sets the county_id.
        /// </summary>
        public string county_id { get; set; }

        /// <summary>
        /// Gets or sets the ctry_id.
        /// </summary>
        public string ctry_id { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Gets or sets the fax.
        /// </summary>
        public string fax { get; set; }

        /// <summary>
        /// Gets or sets the honorific.
        /// </summary>
        public string honorific { get; set; }

        /// <summary>
        /// Gets or sets the image_file.
        /// </summary>
        public string image_file { get; set; }

        /// <summary>
        /// Gets or sets the member_type.
        /// </summary>
        public string member_type { get; set; }

        /// <summary>
        /// Gets or sets the name_first.
        /// </summary>
        public string name_first { get; set; }

        /// <summary>
        /// Gets or sets the name_last.
        /// </summary>
        public string name_last { get; set; }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        public string notes { get; set; }

        /// <summary>
        /// Gets or sets the option 1.
        /// </summary>
        public string option1 { get; set; }

        /// <summary>
        /// Gets or sets the option 2.
        /// </summary>
        public string option2 { get; set; }

        /// <summary>
        /// Gets or sets the pager.
        /// </summary>
        public string pager { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// Gets or sets the regn_id.
        /// </summary>
        public string regn_id { get; set; }

        /// <summary>
        /// Gets or sets the source_table.
        /// </summary>
        public string source_table { get; set; }

        /// <summary>
        /// Gets or sets the state_id.
        /// </summary>
        public string state_id { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        public string zip { get; set; }

        /// <summary>
        /// Gets or sets the project_id.
        /// </summary>
        public string project_id { get; set; }

        /// <summary>
        /// Gets or sets the member_id.
        /// </summary>
        public string member_id { get; set; }

        /// <summary>
        /// Gets or sets the afm_tbls.
        /// </summary>
        public virtual afm_tbls afm_tbls { get; set; }

        /// <summary>
        /// Gets or sets the bl.
        /// </summary>
        public virtual bl bl { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        public virtual City city { get; set; }

        /// <summary>
        /// Gets or sets the company 1.
        /// </summary>
        public virtual Company company1 { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        public virtual County county { get; set; }

        /// <summary>
        /// Gets or sets the ctry.
        /// </summary>
        public virtual ctry ctry { get; set; }

        /// <summary>
        /// Gets or sets the project.
        /// </summary>
        public virtual project project { get; set; }

        /// <summary>
        /// Gets or sets the regn.
        /// </summary>
        public virtual regn regn { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public virtual state state { get; set; }
    }
}