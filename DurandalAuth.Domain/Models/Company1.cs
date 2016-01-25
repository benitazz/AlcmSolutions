#region

using System;
using System.Collections.Generic;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The company 1.
    /// </summary>
    public partial class Company1 : AuditInfoComplete
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company1"/> class.
        /// </summary>
        public Company1()
        {
            this.Profiles = new List<Profile>();
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the company name.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the registered name.
        /// </summary>
        public string RegisteredName { get; set; }

        /// <summary>
        /// Gets or sets the registration number.
        /// </summary>
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Gets or sets the profiles.
        /// </summary>
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}