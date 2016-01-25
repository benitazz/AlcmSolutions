using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class question
    {
        public string action_response { get; set; }
        public string activity_type { get; set; }
        public string enum_list { get; set; }
        public string enum_list_01 { get; set; }
        public string enum_list_02 { get; set; }
        public string enum_list_03 { get; set; }
        public string enum_list_ch { get; set; }
        public string enum_list_de { get; set; }
        public string enum_list_es { get; set; }
        public string enum_list_fr { get; set; }
        public string enum_list_it { get; set; }
        public string enum_list_jp { get; set; }
        public string enum_list_ko { get; set; }
        public string enum_list_nl { get; set; }
        public string enum_list_no { get; set; }
        public string enum_list_zh { get; set; }
        public string format_type { get; set; }
        public short freeform_width { get; set; }
        public short is_active { get; set; }
        public short is_required { get; set; }
        public string lookup_field { get; set; }
        public string lookup_table { get; set; }
        public string quest_text { get; set; }
        public string quest_text_01 { get; set; }
        public string quest_text_02 { get; set; }
        public string quest_text_03 { get; set; }
        public string quest_text_ch { get; set; }
        public string quest_text_de { get; set; }
        public string quest_text_es { get; set; }
        public string quest_text_fr { get; set; }
        public string quest_text_it { get; set; }
        public string quest_text_jp { get; set; }
        public string quest_text_ko { get; set; }
        public string quest_text_nl { get; set; }
        public string quest_text_no { get; set; }
        public string quest_text_zh { get; set; }
        public short sort_order { get; set; }
        public string questionnaire_id { get; set; }
        public string quest_name { get; set; }
        public virtual activitytype activitytype { get; set; }
        public virtual afm_flds afm_flds { get; set; }
        public virtual afm_tbls afm_tbls { get; set; }
        public virtual questionnaire questionnaire { get; set; }
    }
}
