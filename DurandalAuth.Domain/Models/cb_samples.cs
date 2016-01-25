using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class cb_samples
    {
        public cb_samples()
        {
            this.cb_sample_result = new List<cb_sample_result>();
        }

        public int activity_log_id { get; set; }
        public string analysis_requested { get; set; }
        public string analyst_name { get; set; }
        public string comments { get; set; }
        public Nullable<System.DateTime> date_analysis { get; set; }
        public System.DateTime date_collected { get; set; }
        public Nullable<System.DateTime> date_received { get; set; }
        public string dwgname { get; set; }
        public string ehandle { get; set; }
        public string lab_id { get; set; }
        public string lab_log_num { get; set; }
        public string requested_by { get; set; }
        public short sample_archive { get; set; }
        public string sample_code { get; set; }
        public string sample_desc { get; set; }
        public string sample_doc { get; set; }
        public string sample_loc { get; set; }
        public string sample_loc_code { get; set; }
        public string sample_prefix_num { get; set; }
        public string sample_type { get; set; }
        public int sample_id { get; set; }
        public virtual activity_log activity_log { get; set; }
        public virtual ICollection<cb_sample_result> cb_sample_result { get; set; }
        public virtual vn vn { get; set; }
    }
}
