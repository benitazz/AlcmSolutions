using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_actprods
    {
        public string activity_cat_id { get; set; }
        public string comments { get; set; }
        public string transfer_status { get; set; }
        public string product_id { get; set; }
        public string activity_id { get; set; }
        public virtual afm_activities afm_activities { get; set; }
        public virtual afm_activity_cats afm_activity_cats { get; set; }
        public virtual afm_products afm_products { get; set; }
    }
}
