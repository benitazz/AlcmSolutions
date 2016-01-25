using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class energy_time_period
    {
        public energy_time_period()
        {
            this.bills = new List<bill>();
            this.bill_archive = new List<bill_archive>();
            this.bls = new List<bl>();
            this.energy_bl_svc_period = new List<energy_bl_svc_period>();
            this.energy_chart_point = new List<energy_chart_point>();
            this.weather_model = new List<weather_model>();
        }

        public string name { get; set; }
        public Nullable<int> period_index { get; set; }
        public string time_period { get; set; }
        public virtual ICollection<bill> bills { get; set; }
        public virtual ICollection<bill_archive> bill_archive { get; set; }
        public virtual ICollection<bl> bls { get; set; }
        public virtual ICollection<energy_bl_svc_period> energy_bl_svc_period { get; set; }
        public virtual ICollection<energy_chart_point> energy_chart_point { get; set; }
        public virtual ICollection<weather_model> weather_model { get; set; }
    }
}
