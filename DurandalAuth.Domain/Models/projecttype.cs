using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class projecttype
    {
        public projecttype()
        {
            this.commsubs = new List<commsub>();
            this.projects = new List<project>();
            this.questionnaire_map = new List<questionnaire_map>();
        }

        public string description { get; set; }
        public string description_01 { get; set; }
        public string description_02 { get; set; }
        public string description_03 { get; set; }
        public string description_ch { get; set; }
        public string description_de { get; set; }
        public string description_es { get; set; }
        public string description_fr { get; set; }
        public string description_it { get; set; }
        public string description_jp { get; set; }
        public string description_ko { get; set; }
        public string description_nl { get; set; }
        public string description_no { get; set; }
        public string description_zh { get; set; }
        public string project_type_01 { get; set; }
        public string project_type_02 { get; set; }
        public string project_type_03 { get; set; }
        public string project_type_ch { get; set; }
        public string project_type_de { get; set; }
        public string project_type_es { get; set; }
        public string project_type_fr { get; set; }
        public string project_type_it { get; set; }
        public string project_type_jp { get; set; }
        public string project_type_ko { get; set; }
        public string project_type_nl { get; set; }
        public string project_type_no { get; set; }
        public string project_type_zh { get; set; }
        public string project_type { get; set; }
        public virtual ICollection<commsub> commsubs { get; set; }
        public virtual ICollection<project> projects { get; set; }
        public virtual ICollection<questionnaire_map> questionnaire_map { get; set; }
    }
}
