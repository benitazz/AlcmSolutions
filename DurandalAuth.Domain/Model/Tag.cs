#region

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

#endregion

namespace DurandalAuth.Domain.Model
{
    /// <summary>
    /// Tags for the Articles
    /// </summary>
    [DataContract(IsReference = true)]
    public class Tag
    {
        [Key]
        [DataMember]
        public Guid TagId { get; set; }

        /// <summary>
        /// Tag Name
        /// </summary>
        [Required]
        [StringLength(100)]
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Related Article
        /// </summary>        
        [DataMember]
        public Guid ArticleId { get; set; }

        /// <summary>
        /// Related Article
        /// </summary>
        [ForeignKey("ArticleId")]
        [DataMember]
        public Article Article { get; set; }
    }
}