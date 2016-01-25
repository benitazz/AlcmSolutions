#region

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The profile.
    /// </summary>
    public class Profile : AuditInfoComplete
    {
        /// <summary>
        /// Gets or sets the profile id.
        /// </summary>
        [Key]
        [DataMember]
        public int ProfileId { get; set; }

        /// <summary>
        /// Gets or sets the address id.
        /// </summary>
        [DataMember]
        public int? AddressId { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        [DataMember]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the contanct id.
        /// </summary>
        [DataMember]
        public int? ContanctId { get; set; }

        /// <summary>
        /// Gets or sets the entity type id.
        /// </summary>
        [DataMember]
        public int? EntityTypeId { get; set; }

        /// <summary>
        /// Gets or sets the individual id.
        /// </summary>
        [DataMember]
        public int? IndividualId { get; set; }

        /// <summary>
        /// Gets or sets the company id.
        /// </summary>
        [DataMember]
        public int? CompanyId { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        [DataMember]
        public virtual Address Address { get; set; }

        /// <summary>
        /// Gets or sets the asp net user.
        /// </summary>
        public virtual AspNetUser AspNetUser { get; set; }

        /// <summary>
        /// Gets or sets the company.
        /// </summary>
        [DataMember]
        public virtual Company1 Company { get; set; }

        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        [DataMember]
        public virtual Contact1 Contact { get; set; }

        /// <summary>
        /// Gets or sets the entity type lookup.
        /// </summary>
        [DataMember]
        public virtual EntityTypeLookup EntityTypeLookup { get; set; }

        /// <summary>
        /// Gets or sets the individual.
        /// </summary>
        [DataMember]
        public virtual Individual Individual { get; set; }
    }
}