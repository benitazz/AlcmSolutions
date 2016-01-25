#region

using System.Collections.Generic;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The insurer.
    /// </summary>
    public partial class insurer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="insurer"/> class.
        /// </summary>
        public insurer()
        {
            this.policies = new List<policy>();
        }

        /// <summary>
        /// Gets or sets the address 1.
        /// </summary>
        public string address1 { get; set; }

        /// <summary>
        /// Gets or sets the address 2.
        /// </summary>
        public string address2 { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        public string contact { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Gets or sets the fax.
        /// </summary>
        public string fax { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// Gets or sets the phone_ext.
        /// </summary>
        public string phone_ext { get; set; }

        /// <summary>
        /// Gets or sets the postalcode.
        /// </summary>
        public string postalcode { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        public string region { get; set; }

        /// <summary>
        /// Gets or sets the insurer_id.
        /// </summary>
        public string insurer_id { get; set; }

        /// <summary>
        /// Gets or sets the policies.
        /// </summary>
        public virtual ICollection<policy> policies { get; set; }
    }
}