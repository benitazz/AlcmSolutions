using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class programtype
    {
        public programtype()
        {
            this.programs = new List<program>();
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
        public string program_type_01 { get; set; }
        public string program_type_02 { get; set; }
        public string program_type_03 { get; set; }
        public string program_type_ch { get; set; }
        public string program_type_de { get; set; }
        public string program_type_es { get; set; }
        public string program_type_fr { get; set; }
        public string program_type_it { get; set; }
        public string program_type_jp { get; set; }
        public string program_type_ko { get; set; }
        public string program_type_nl { get; set; }
        public string program_type_no { get; set; }
        public string program_type_zh { get; set; }
        public string program_type { get; set; }
        public virtual ICollection<program> programs { get; set; }
    }
}
