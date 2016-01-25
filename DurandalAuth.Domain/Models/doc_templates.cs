using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class doc_templates
    {
        public string classification { get; set; }
        public string description { get; set; }
        public string doc_type { get; set; }
        public string template { get; set; }
        public string template_id { get; set; }
    }
}
