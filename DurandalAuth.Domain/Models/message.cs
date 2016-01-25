using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class message
    {
        public message()
        {
            this.notify_templates = new List<notify_templates>();
            this.notify_templates1 = new List<notify_templates>();
        }

        public string message_text { get; set; }
        public string message_text_01 { get; set; }
        public string message_text_02 { get; set; }
        public string message_text_03 { get; set; }
        public string message_text_ch { get; set; }
        public string message_text_de { get; set; }
        public string message_text_es { get; set; }
        public string message_text_fr { get; set; }
        public string message_text_it { get; set; }
        public string message_text_jp { get; set; }
        public string message_text_ko { get; set; }
        public string message_text_nl { get; set; }
        public string message_text_no { get; set; }
        public string message_text_zh { get; set; }
        public short customized { get; set; }
        public string description { get; set; }
        public short is_rich_msg_format { get; set; }
        public string transfer_status { get; set; }
        public string activity_id { get; set; }
        public string referenced_by { get; set; }
        public string message_id { get; set; }
        public virtual afm_activities afm_activities { get; set; }
        public virtual ICollection<notify_templates> notify_templates { get; set; }
        public virtual ICollection<notify_templates> notify_templates1 { get; set; }
    }
}
