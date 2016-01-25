using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class work_categories_em
    {
        public Nullable<System.DateTime> date_end { get; set; }
        public string em_id { get; set; }
        public string work_category_id { get; set; }
        public System.DateTime date_start { get; set; }
        public virtual Em em { get; set; }
        public virtual work_categories work_categories { get; set; }
    }
}
