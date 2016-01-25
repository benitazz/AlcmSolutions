#region

using System;
using System.Collections.Generic;

#endregion

namespace DurandalAuth.Domain.Models
{
    /// <summary>
    /// The category.
    /// </summary>
    public partial class Category : AuditInfoComplete
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        public Category()
        {
            this.Articles = new List<Article>();
        }

        /// <summary>
        /// Gets or sets the category id.
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the url code reference.
        /// </summary>
        public string UrlCodeReference { get; set; }

        /// <summary>
        /// Gets or sets the articles.
        /// </summary>
        public virtual ICollection<Article> Articles { get; set; }
    }
}