using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_hotlist
    {
        public string category_01 { get; set; }
        public string category_02 { get; set; }
        public string category_03 { get; set; }
        public string category_ch { get; set; }
        public string category_de { get; set; }
        public string category_es { get; set; }
        public string category_fr { get; set; }
        public string category_it { get; set; }
        public string category_jp { get; set; }
        public string category_ko { get; set; }
        public string category_nl { get; set; }
        public string category_no { get; set; }
        public string category_zh { get; set; }
        public string comments { get; set; }
        public short display_order { get; set; }
        public string fixedformat_file { get; set; }
        public string help_file { get; set; }
        public string help_topic { get; set; }
        public string inet_file { get; set; }
        public string language { get; set; }
        public string proc_file { get; set; }
        public string proc_name { get; set; }
        public string security_group { get; set; }
        public string super_cat_01 { get; set; }
        public string super_cat_02 { get; set; }
        public string super_cat_03 { get; set; }
        public string super_cat_ch { get; set; }
        public string super_cat_de { get; set; }
        public string super_cat_es { get; set; }
        public string super_cat_fr { get; set; }
        public string super_cat_it { get; set; }
        public string super_cat_jp { get; set; }
        public string super_cat_ko { get; set; }
        public string super_cat_nl { get; set; }
        public string super_cat_no { get; set; }
        public string super_cat_zh { get; set; }
        public short task_cat { get; set; }
        public string transfer_status { get; set; }
        public string view_name { get; set; }
        public string view_title_01 { get; set; }
        public string view_title_02 { get; set; }
        public string view_title_03 { get; set; }
        public string view_title_ch { get; set; }
        public string view_title_de { get; set; }
        public string view_title_es { get; set; }
        public string view_title_fr { get; set; }
        public string view_title_it { get; set; }
        public string view_title_jp { get; set; }
        public string view_title_ko { get; set; }
        public string view_title_nl { get; set; }
        public string view_title_no { get; set; }
        public string view_title_zh { get; set; }
        public string super_cat { get; set; }
        public string category { get; set; }
        public string view_title { get; set; }
        public virtual afm_groups afm_groups { get; set; }
    }
}
