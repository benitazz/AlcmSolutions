#region

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The entity type lookup.
    /// </summary>
    public partial class EntityTypeLookup : AuditInfoComplete
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityTypeLookup"/> class.
        /// </summary>
        public EntityTypeLookup()
        {
            this.Profiles = new List<Profile>();
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the profiles.
        /// </summary>
        [DataMember]
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}