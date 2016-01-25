using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_connector
    {
        public afm_connector()
        {
            this.afm_conn_flds = new List<afm_conn_flds>();
            this.afm_conn_log = new List<afm_conn_log>();
            this.bill_connector = new List<bill_connector>();
            this.bill_connector1 = new List<bill_connector>();
        }

        public short delimeter { get; set; }
        public string description { get; set; }
        public string destination_tbl { get; set; }
        public int exec_flag { get; set; }
        public string footer_connector { get; set; }
        public string ftp_folder { get; set; }
        public string ftp_password { get; set; }
        public Nullable<int> ftp_port { get; set; }
        public Nullable<int> ftp_secure { get; set; }
        public string ftp_string { get; set; }
        public string ftp_user { get; set; }
        public string header_connector { get; set; }
        public int import { get; set; }
        public string notify_email_address { get; set; }
        public Nullable<int> notify_user { get; set; }
        public string post_process { get; set; }
        public string pre_process { get; set; }
        public int skip_first_row { get; set; }
        public string source_tbl { get; set; }
        public Nullable<int> text_qualifier { get; set; }
        public int type { get; set; }
        public string assigned_connector { get; set; }
        public string clause { get; set; }
        public string conn_params { get; set; }
        public string conn_password { get; set; }
        public string conn_string { get; set; }
        public string conn_user { get; set; }
        public string connector_id { get; set; }
        public virtual ICollection<afm_conn_flds> afm_conn_flds { get; set; }
        public virtual ICollection<afm_conn_log> afm_conn_log { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
        public virtual ICollection<bill_connector> bill_connector { get; set; }
        public virtual ICollection<bill_connector> bill_connector1 { get; set; }
    }
}
