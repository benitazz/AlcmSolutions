using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class facility_type
    {
        public facility_type()
        {
            this.sus = new List<su>();
        }

        public string facility_type_id { get; set; }
        public virtual ICollection<su> sus { get; set; }
    }
}
