using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class Article
    {
        public Article()
        {
            this.Tags = new List<Tag>();
        }

        public System.Guid ArticleId { get; set; }
        public string Title { get; set; }
        public string UrlCodeReference { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Markdown { get; set; }
        public string Html { get; set; }
        public bool IsPublished { get; set; }
        public System.Guid CategoryId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int RowVersion { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
