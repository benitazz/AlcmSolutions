using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_energystar_fuels
    {
        public gb_fp_energystar_fuels()
        {
            this.gb_fp_fuels = new List<gb_fp_fuels>();
        }

        public string description { get; set; }
        public string fuel_es { get; set; }
        public virtual ICollection<gb_fp_fuels> gb_fp_fuels { get; set; }
    }
}
