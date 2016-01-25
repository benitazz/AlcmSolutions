using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class Tag
    {
        public System.Guid TagId { get; set; }
        public string Name { get; set; }
        public System.Guid ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
