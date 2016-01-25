#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The address.
    /// </summary>
    public class Address : AuditInfoComplete
    {
        /// <summary>
        /// Gets or sets the address id.
        /// </summary>
        [Key]
        [DataMember]
        public int AddressId { get; set; }

        /// <summary>
        /// Gets or sets the address type id.
        /// </summary>
        [DataMember]
        public int AddressTypeId { get; set; }

        /// <summary>
        /// Gets or sets the address line 1.
        /// </summary>
        [DataMember]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the address line 2.
        /// </summary>
        [DataMember]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the suburb.
        /// </summary>
        [DataMember]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or sets the province id.
        /// </summary>
        [DataMember]
        public int ProvinceId { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        [DataMember]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the address lookup.
        /// </summary>
        [DataMember]
        public virtual AddressLookup AddressLookup { get; set; }

        /// <summary>
        /// Gets or sets the province lookup.
        /// </summary>
        [DataMember]
        public virtual ProvinceLookup ProvinceLookup { get; set; }

        /// <summary>
        /// Gets or sets the profiles.
        /// </summary>
        [DataMember]
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}