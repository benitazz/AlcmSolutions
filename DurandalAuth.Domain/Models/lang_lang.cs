using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class lang_lang
    {
        public lang_lang()
        {
            this.lang_enum = new List<lang_enum>();
            this.lang_files = new List<lang_files>();
            this.lang_glossary = new List<lang_glossary>();
            this.lang_strings = new List<lang_strings>();
        }

        public short is_default_language { get; set; }
        public string lang_to_fld_mapping { get; set; }
        public string locale { get; set; }
        public string language { get; set; }
        public virtual ICollection<lang_enum> lang_enum { get; set; }
        public virtual ICollection<lang_files> lang_files { get; set; }
        public virtual ICollection<lang_glossary> lang_glossary { get; set; }
        public virtual ICollection<lang_strings> lang_strings { get; set; }
    }
}
