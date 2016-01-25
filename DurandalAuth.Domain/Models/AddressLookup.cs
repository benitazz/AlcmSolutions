#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The address lookup.
    /// </summary>
    public class AddressLookup : AuditInfoComplete
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [Key]
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        [DataMember]
        public virtual ICollection<Address> Addresses { get; set; }
    }
}