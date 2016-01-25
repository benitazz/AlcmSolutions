using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class rmstd
    {
        public rmstd()
        {
            this.rms = new List<Rm>();
            this.rm_trial = new List<rm_trial>();
            this.rmstd_fn = new List<rmstd_fn>();
            this.sb_items = new List<sb_items>();
            this.surveyrm_sync = new List<surveyrm_sync>();
            this.emstds = new List<emstd>();
        }

        public decimal area { get; set; }
        public decimal area_avg { get; set; }
        public decimal cost_of_em { get; set; }
        public decimal cost_of_furn { get; set; }
        public decimal cost_of_move { get; set; }
        public decimal cost_of_space { get; set; }
        public int count_em { get; set; }
        public string description { get; set; }
        public string doc_block { get; set; }
        public string doc_graphic { get; set; }
        public string hpattern { get; set; }
        public string hpattern_acad { get; set; }
        public string image_file { get; set; }
        public string image_of_block { get; set; }
        public decimal length { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public decimal std_area { get; set; }
        public int std_em { get; set; }
        public short support { get; set; }
        public string symbol { get; set; }
        public string tc_contained_tbls { get; set; }
        public int tot_count { get; set; }
        public decimal width { get; set; }
        public string rm_std { get; set; }
        public virtual ICollection<Rm> rms { get; set; }
        public virtual ICollection<rm_trial> rm_trial { get; set; }
        public virtual ICollection<rmstd_fn> rmstd_fn { get; set; }
        public virtual ICollection<sb_items> sb_items { get; set; }
        public virtual ICollection<surveyrm_sync> surveyrm_sync { get; set; }
        public virtual ICollection<emstd> emstds { get; set; }
    }
}
