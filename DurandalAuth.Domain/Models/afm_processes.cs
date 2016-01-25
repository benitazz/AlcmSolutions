using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_processes
    {
        public afm_processes()
        {
            this.afm_psubtasks = new List<afm_psubtasks>();
            this.afm_ptasks = new List<afm_ptasks>();
            this.afm_roleprocs = new List<afm_roleprocs>();
            this.afm_userprocs = new List<afm_userprocs>();
        }

        public string process_type { get; set; }
        public string summary { get; set; }
        public string summary_01 { get; set; }
        public string summary_02 { get; set; }
        public string summary_03 { get; set; }
        public string summary_ch { get; set; }
        public string summary_de { get; set; }
        public string summary_es { get; set; }
        public string summary_fr { get; set; }
        public string summary_it { get; set; }
        public string summary_jp { get; set; }
        public string summary_ko { get; set; }
        public string summary_nl { get; set; }
        public string summary_no { get; set; }
        public string summary_zh { get; set; }
        public string title { get; set; }
        public string title_01 { get; set; }
        public string title_02 { get; set; }
        public string title_03 { get; set; }
        public string title_ch { get; set; }
        public string title_de { get; set; }
        public string title_es { get; set; }
        public string title_fr { get; set; }
        public string title_it { get; set; }
        public string title_jp { get; set; }
        public string title_ko { get; set; }
        public string title_nl { get; set; }
        public string title_no { get; set; }
        public string title_zh { get; set; }
        public string transfer_status { get; set; }
        public string comments { get; set; }
        public string dashboard_layout { get; set; }
        public string dashboard_view { get; set; }
        public Nullable<short> display_order { get; set; }
        public string help_link { get; set; }
        public string help_system { get; set; }
        public string icon_large { get; set; }
        public string icon_small { get; set; }
        public Nullable<int> internal_use1 { get; set; }
        public Nullable<short> is_active { get; set; }
        public string license_level { get; set; }
        public string activity_id { get; set; }
        public string process_id { get; set; }
        public virtual afm_activities afm_activities { get; set; }
        public virtual ICollection<afm_psubtasks> afm_psubtasks { get; set; }
        public virtual ICollection<afm_ptasks> afm_ptasks { get; set; }
        public virtual ICollection<afm_roleprocs> afm_roleprocs { get; set; }
        public virtual ICollection<afm_userprocs> afm_userprocs { get; set; }
    }
}
