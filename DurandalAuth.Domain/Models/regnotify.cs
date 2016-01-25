using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class regnotify
    {
        public short is_active { get; set; }
        public string reg_program { get; set; }
        public string reg_requirement { get; set; }
        public string regulation { get; set; }
        public string template_id { get; set; }
        public int regnotify_id { get; set; }
        public virtual notify_templates notify_templates { get; set; }
        public virtual regprogram regprogram { get; set; }
        public virtual regrequirement regrequirement { get; set; }
        public virtual regulation regulation1 { get; set; }
    }
}
