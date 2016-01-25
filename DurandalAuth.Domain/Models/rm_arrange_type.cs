using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rm_arrange_type
    {
        public rm_arrange_type()
        {
            this.rm_arrange = new List<rm_arrange>();
        }

        public string arrange_name { get; set; }
        public string tr_id { get; set; }
        public string vn_id { get; set; }
        public string rm_arrange_type_id { get; set; }
        public virtual ICollection<rm_arrange> rm_arrange { get; set; }
        public virtual tr tr { get; set; }
        public virtual vn vn { get; set; }
    }
}
