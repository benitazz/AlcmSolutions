using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class softinv
    {
        public string comments { get; set; }
        public Nullable<System.DateTime> date_installed { get; set; }
        public Nullable<System.DateTime> date_purchased { get; set; }
        public string eq_id { get; set; }
        public string licence_id { get; set; }
        public short num_licences { get; set; }
        public string soft_id { get; set; }
        public string soft_std { get; set; }
        public string authorization_id { get; set; }
        public int auto_number { get; set; }
        public virtual eq eq { get; set; }
        public virtual softstd softstd { get; set; }
    }
}
