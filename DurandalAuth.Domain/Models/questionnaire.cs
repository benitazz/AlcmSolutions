using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class questionnaire
    {
        public questionnaire()
        {
            this.activity_log = new List<activity_log>();
            this.questionnaire_map = new List<questionnaire_map>();
            this.questions = new List<question>();
        }

        public string table_name { get; set; }
        public string title { get; set; }
        public string title_01 { get; set; }
        public string title_02 { get; set; }
        public string title_03 { get; set; }
        public string title_ch { get; set; }
        public string title_de { get; set; }
        public string title_es { get; set; }
        public string title_fr { get; set; }
        public string title_it { get; set; }
        public string title_jp { get; set; }
        public string title_ko { get; set; }
        public string title_nl { get; set; }
        public string title_no { get; set; }
        public string title_zh { get; set; }
        public string description { get; set; }
        public string field_name { get; set; }
        public string questionnaire_id { get; set; }
        public virtual ICollection<activity_log> activity_log { get; set; }
        public virtual afm_flds afm_flds { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
        public virtual ICollection<questionnaire_map> questionnaire_map { get; set; }
        public virtual ICollection<question> questions { get; set; }
    }
}
