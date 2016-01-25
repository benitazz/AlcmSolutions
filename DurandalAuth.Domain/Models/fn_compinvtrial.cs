using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class fn_compinvtrial
    {
        public int count_inv { get; set; }
        public int count_stor { get; set; }
        public int count_to_move_from_inv { get; set; }
        public int count_to_move_from_stor { get; set; }
        public int count_to_move_to_stor { get; set; }
        public int count_to_order { get; set; }
        public int count_trial { get; set; }
        public string dwgnames { get; set; }
        public string fn_std { get; set; }
        public string layers { get; set; }
        public string trial_project_id { get; set; }
        public int auto_number { get; set; }
        public virtual fnstd fnstd { get; set; }
    }
}
