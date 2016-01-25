using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_versions
    {
        public gb_fp_versions()
        {
            this.gb_fp_airc_data = new List<gb_fp_airc_data>();
            this.gb_fp_carbon_data = new List<gb_fp_carbon_data>();
            this.gb_fp_comm_airc_data = new List<gb_fp_comm_airc_data>();
            this.gb_fp_egrid_subregions = new List<gb_fp_egrid_subregions>();
            this.gb_fp_egrid_zip = new List<gb_fp_egrid_zip>();
            this.gb_fp_emiss_data = new List<gb_fp_emiss_data>();
            this.gb_fp_fuel_dens_data = new List<gb_fp_fuel_dens_data>();
            this.gb_fp_gwp_data = new List<gb_fp_gwp_data>();
            this.gb_fp_heat_data = new List<gb_fp_heat_data>();
            this.gb_fp_mobile_data = new List<gb_fp_mobile_data>();
            this.gb_fp_oxid_data = new List<gb_fp_oxid_data>();
            this.gb_fp_refrig_data = new List<gb_fp_refrig_data>();
            this.gb_fp_setup = new List<gb_fp_setup>();
            this.gb_fp_setup1 = new List<gb_fp_setup>();
            this.gb_fp_setup2 = new List<gb_fp_setup>();
            this.gb_fp_setup3 = new List<gb_fp_setup>();
            this.gb_fp_setup4 = new List<gb_fp_setup>();
            this.gb_fp_setup5 = new List<gb_fp_setup>();
            this.gb_fp_setup6 = new List<gb_fp_setup>();
            this.gb_fp_setup7 = new List<gb_fp_setup>();
            this.gb_fp_setup8 = new List<gb_fp_setup>();
            this.gb_fp_setup9 = new List<gb_fp_setup>();
            this.gb_fp_setup10 = new List<gb_fp_setup>();
            this.gb_fp_setup11 = new List<gb_fp_setup>();
            this.gb_fp_setup12 = new List<gb_fp_setup>();
            this.gb_fp_waste_liq_data = new List<gb_fp_waste_liq_data>();
            this.gb_fp_waste_sol_data = new List<gb_fp_waste_sol_data>();
        }

        public string description { get; set; }
        public string version_type { get; set; }
        public string version_name { get; set; }
        public virtual ICollection<gb_fp_airc_data> gb_fp_airc_data { get; set; }
        public virtual ICollection<gb_fp_carbon_data> gb_fp_carbon_data { get; set; }
        public virtual ICollection<gb_fp_comm_airc_data> gb_fp_comm_airc_data { get; set; }
        public virtual ICollection<gb_fp_egrid_subregions> gb_fp_egrid_subregions { get; set; }
        public virtual ICollection<gb_fp_egrid_zip> gb_fp_egrid_zip { get; set; }
        public virtual ICollection<gb_fp_emiss_data> gb_fp_emiss_data { get; set; }
        public virtual ICollection<gb_fp_fuel_dens_data> gb_fp_fuel_dens_data { get; set; }
        public virtual ICollection<gb_fp_gwp_data> gb_fp_gwp_data { get; set; }
        public virtual ICollection<gb_fp_heat_data> gb_fp_heat_data { get; set; }
        public virtual ICollection<gb_fp_mobile_data> gb_fp_mobile_data { get; set; }
        public virtual ICollection<gb_fp_oxid_data> gb_fp_oxid_data { get; set; }
        public virtual ICollection<gb_fp_refrig_data> gb_fp_refrig_data { get; set; }
        public virtual ICollection<gb_fp_setup> gb_fp_setup { get; set; }
        public virtual ICollection<gb_fp_setup> gb_fp_setup1 { get; set; }
        public virtual ICollection<gb_fp_setup> gb_fp_setup2 { get; set; }
        public virtual ICollection<gb_fp_setup> gb_fp_setup3 { get; set; }
        public virtual ICollection<gb_fp_setup> gb_fp_setup4 { get; set; }
        public virtual ICollection<gb_fp_setup> gb_fp_setup5 { get; set; }
        public virtual ICollection<gb_fp_setup> gb_fp_setup6 { get; set; }
        public virtual ICollection<gb_fp_setup> gb_fp_setup7 { get; set; }
        public virtual ICollection<gb_fp_setup> gb_fp_setup8 { get; set; }
        public virtual ICollection<gb_fp_setup> gb_fp_setup9 { get; set; }
        public virtual ICollection<gb_fp_setup> gb_fp_setup10 { get; set; }
        public virtual ICollection<gb_fp_setup> gb_fp_setup11 { get; set; }
        public virtual ICollection<gb_fp_setup> gb_fp_setup12 { get; set; }
        public virtual ICollection<gb_fp_waste_liq_data> gb_fp_waste_liq_data { get; set; }
        public virtual ICollection<gb_fp_waste_sol_data> gb_fp_waste_sol_data { get; set; }
    }
}
