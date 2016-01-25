using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class ls_cam_rec_report
    {
        public Nullable<int> cost_tran_id { get; set; }
        public Nullable<int> cost_tran_sched_id { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> invoice_date_received { get; set; }
        public string ll_cam_report_doc { get; set; }
        public string ll_invoice_doc { get; set; }
        public string ll_invoice_no { get; set; }
        public string ls_id { get; set; }
        public short ls_rent_year { get; set; }
        public string support_doc1_id { get; set; }
        public string support_doc2_id { get; set; }
        public string support_doc3_id { get; set; }
        public string support_doc4_id { get; set; }
        public int ls_cam_rec_report_id { get; set; }
        public virtual cost_tran cost_tran { get; set; }
        public virtual cost_tran_sched cost_tran_sched { get; set; }
        public virtual l l { get; set; }
    }
}
