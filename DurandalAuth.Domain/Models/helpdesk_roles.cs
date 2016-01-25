using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class helpdesk_roles
    {
        public string @class { get; set; }
        public string method { get; set; }
        public string role { get; set; }
        public string step_type { get; set; }
    }
}
