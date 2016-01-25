#region

using System;
using System.Collections.Generic;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The individual.
    /// </summary>
    public partial class Individual : AuditInfoComplete
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Individual"/> class.
        /// </summary>
        public Individual()
        {
            this.Profiles = new List<Profile>();
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the gender lookup id.
        /// </summary>
        public int? GenderLookupId { get; set; }

        /// <summary>
        /// Gets or sets the gender lookup.
        /// </summary>
        public virtual GenderLookup GenderLookup { get; set; }

        /// <summary>
        /// Gets or sets the profiles.
        /// </summary>
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}