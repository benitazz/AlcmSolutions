using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class lang_enum
    {
        public Nullable<System.DateTime> date_last_updated { get; set; }
        public string enum_trans { get; set; }
        public string reference_info { get; set; }
        public string transfer_status { get; set; }
        public string language { get; set; }
        public string enum_english { get; set; }
        public virtual lang_lang lang_lang { get; set; }
    }
}
