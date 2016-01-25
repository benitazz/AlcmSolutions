#region

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The city name lookup.
    /// </summary>
    public class CityNameLookup : AuditInfoComplete
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
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the province id.
        /// </summary>
        [DataMember]
        public int ProvinceId { get; set; }

        /// <summary>
        /// Gets or sets the province lookup.
        /// </summary>
        [ForeignKey("ProvinceId")]
        [DataMember]
        public ProvinceLookup ProvinceLookup { get; set; }
    }
}