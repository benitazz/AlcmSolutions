#region

using System;
using System.Collections.Generic;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The contact 1.
    /// </summary>
    public partial class Contact1 : AuditInfoComplete
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact1"/> class.
        /// </summary>
        public Contact1()
        {
            this.Profiles = new List<Profile>();
        }

        /// <summary>
        /// Gets or sets the contact id.
        /// </summary>
        public int ContactId { get; set; }

        /// <summary>
        /// Gets or sets the cell phone.
        /// </summary>
        public string CellPhone { get; set; }

        /// <summary>
        /// Gets or sets the home phone.
        /// </summary>
        public string HomePhone { get; set; }

        /// <summary>
        /// Gets or sets the work phone.
        /// </summary>
        public string WorkPhone { get; set; }

        /// <summary>
        /// Gets or sets the fax number.
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets the profiles.
        /// </summary>
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}