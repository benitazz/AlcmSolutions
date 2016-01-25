using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_data_event_log
    {
        public string change_type { get; set; }
        public System.DateTime date_occurred { get; set; }
        public string event_type { get; set; }
        public string field_list { get; set; }
        public string sql_statement { get; set; }
        public string table_name { get; set; }
        public System.DateTime time_occurred { get; set; }
        public string user_name { get; set; }
        public string values_new { get; set; }
        public string values_old { get; set; }
        public int auto_number { get; set; }
    }
}
