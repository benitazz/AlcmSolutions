using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_fuels
    {
        public gb_fp_fuels()
        {
            this.gb_fp_airc_data = new List<gb_fp_airc_data>();
            this.gb_fp_carbon_data = new List<gb_fp_carbon_data>();
            this.gb_fp_emiss_data = new List<gb_fp_emiss_data>();
            this.gb_fp_fuel_dens_data = new List<gb_fp_fuel_dens_data>();
            this.gb_fp_heat_data = new List<gb_fp_heat_data>();
            this.gb_fp_oxid_data = new List<gb_fp_oxid_data>();
            this.gb_fp_s1_fuel_comb = new List<gb_fp_s1_fuel_comb>();
            this.gb_fp_s1_fuel_comb1 = new List<gb_fp_s1_fuel_comb>();
        }

        public string fuel_es { get; set; }
        public string fuel_base_code { get; set; }
        public string fuel_mode { get; set; }
        public string fuel_name { get; set; }
        public virtual ICollection<gb_fp_airc_data> gb_fp_airc_data { get; set; }
        public virtual ICollection<gb_fp_carbon_data> gb_fp_carbon_data { get; set; }
        public virtual ICollection<gb_fp_emiss_data> gb_fp_emiss_data { get; set; }
        public virtual gb_fp_energystar_fuels gb_fp_energystar_fuels { get; set; }
        public virtual ICollection<gb_fp_fuel_dens_data> gb_fp_fuel_dens_data { get; set; }
        public virtual gb_fp_fuel_types gb_fp_fuel_types { get; set; }
        public virtual ICollection<gb_fp_heat_data> gb_fp_heat_data { get; set; }
        public virtual ICollection<gb_fp_oxid_data> gb_fp_oxid_data { get; set; }
        public virtual ICollection<gb_fp_s1_fuel_comb> gb_fp_s1_fuel_comb { get; set; }
        public virtual ICollection<gb_fp_s1_fuel_comb> gb_fp_s1_fuel_comb1 { get; set; }
    }
}
