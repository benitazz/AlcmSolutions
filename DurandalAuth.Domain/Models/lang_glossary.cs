using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class lang_glossary
    {
        public string string_trans { get; set; }
        public Nullable<short> string_type { get; set; }
        public string transfer_status { get; set; }
        public string language { get; set; }
        public string string_english { get; set; }
        public virtual lang_lang lang_lang { get; set; }
    }
}
