using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class afm_timezones
    {
        public afm_timezones()
        {
            this.cities = new List<City>();
        }

        public string timezone_id_01 { get; set; }
        public string timezone_id_02 { get; set; }
        public string timezone_id_03 { get; set; }
        public string timezone_id_ch { get; set; }
        public string timezone_id_de { get; set; }
        public string timezone_id_es { get; set; }
        public string timezone_id_fr { get; set; }
        public string timezone_id_it { get; set; }
        public string timezone_id_jp { get; set; }
        public string timezone_id_ko { get; set; }
        public string timezone_id_nl { get; set; }
        public string timezone_id_no { get; set; }
        public string timezone_id_zh { get; set; }
        public string transfer_status { get; set; }
        public string timezone_id { get; set; }
        public virtual ICollection<City> cities { get; set; }
    }
}
