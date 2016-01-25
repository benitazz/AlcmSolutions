using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class bill_unit
    {
        public bill_unit()
        {
            this.bas_data_point = new List<bas_data_point>();
            this.bill_line = new List<bill_line>();
            this.gb_fp_airc_data = new List<gb_fp_airc_data>();
            this.gb_fp_carbon_data = new List<gb_fp_carbon_data>();
            this.gb_fp_comm_airc_data = new List<gb_fp_comm_airc_data>();
            this.gb_fp_comm_airc_data1 = new List<gb_fp_comm_airc_data>();
            this.gb_fp_egrid_subregions = new List<gb_fp_egrid_subregions>();
            this.gb_fp_egrid_subregions1 = new List<gb_fp_egrid_subregions>();
            this.gb_fp_emiss_data = new List<gb_fp_emiss_data>();
            this.gb_fp_fuel_dens_data = new List<gb_fp_fuel_dens_data>();
            this.gb_fp_heat_data = new List<gb_fp_heat_data>();
            this.gb_fp_mobile_data = new List<gb_fp_mobile_data>();
            this.gb_fp_mobile_data1 = new List<gb_fp_mobile_data>();
            this.gb_fp_refrig_data = new List<gb_fp_refrig_data>();
            this.gb_fp_s1_fuel_comb = new List<gb_fp_s1_fuel_comb>();
            this.gb_fp_s1_fuel_comb1 = new List<gb_fp_s1_fuel_comb>();
            this.gb_fp_s1_s3_mobile = new List<gb_fp_s1_s3_mobile>();
            this.gb_fp_s2_purch_e = new List<gb_fp_s2_purch_e>();
            this.gb_fp_s3_em_air = new List<gb_fp_s3_em_air>();
            this.gb_fp_s3_mat = new List<gb_fp_s3_mat>();
            this.gb_fp_s3_serv = new List<gb_fp_s3_serv>();
            this.gb_fp_s3_waste_liq = new List<gb_fp_s3_waste_liq>();
            this.gb_fp_s3_waste_sol = new List<gb_fp_s3_waste_sol>();
            this.gb_fp_waste_liq_data = new List<gb_fp_waste_liq_data>();
            this.gb_fp_waste_sol_data = new List<gb_fp_waste_sol_data>();
            this.hazard_container_type = new List<hazard_container_type>();
            this.msds_data = new List<msds_data>();
            this.msds_data1 = new List<msds_data>();
            this.msds_data2 = new List<msds_data>();
            this.msds_data3 = new List<msds_data>();
            this.msds_location = new List<msds_location>();
            this.msds_location1 = new List<msds_location>();
            this.msds_location2 = new List<msds_location>();
            this.waste_out = new List<waste_out>();
        }

        public decimal conversion_factor { get; set; }
        public string description { get; set; }
        public short is_dflt { get; set; }
        public string rollup_type { get; set; }
        public string bill_type_id { get; set; }
        public string bill_unit_id { get; set; }
        public virtual ICollection<bas_data_point> bas_data_point { get; set; }
        public virtual ICollection<bill_line> bill_line { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual ICollection<gb_fp_airc_data> gb_fp_airc_data { get; set; }
        public virtual ICollection<gb_fp_carbon_data> gb_fp_carbon_data { get; set; }
        public virtual ICollection<gb_fp_comm_airc_data> gb_fp_comm_airc_data { get; set; }
        public virtual ICollection<gb_fp_comm_airc_data> gb_fp_comm_airc_data1 { get; set; }
        public virtual ICollection<gb_fp_egrid_subregions> gb_fp_egrid_subregions { get; set; }
        public virtual ICollection<gb_fp_egrid_subregions> gb_fp_egrid_subregions1 { get; set; }
        public virtual ICollection<gb_fp_emiss_data> gb_fp_emiss_data { get; set; }
        public virtual ICollection<gb_fp_fuel_dens_data> gb_fp_fuel_dens_data { get; set; }
        public virtual ICollection<gb_fp_heat_data> gb_fp_heat_data { get; set; }
        public virtual ICollection<gb_fp_mobile_data> gb_fp_mobile_data { get; set; }
        public virtual ICollection<gb_fp_mobile_data> gb_fp_mobile_data1 { get; set; }
        public virtual ICollection<gb_fp_refrig_data> gb_fp_refrig_data { get; set; }
        public virtual ICollection<gb_fp_s1_fuel_comb> gb_fp_s1_fuel_comb { get; set; }
        public virtual ICollection<gb_fp_s1_fuel_comb> gb_fp_s1_fuel_comb1 { get; set; }
        public virtual ICollection<gb_fp_s1_s3_mobile> gb_fp_s1_s3_mobile { get; set; }
        public virtual ICollection<gb_fp_s2_purch_e> gb_fp_s2_purch_e { get; set; }
        public virtual ICollection<gb_fp_s3_em_air> gb_fp_s3_em_air { get; set; }
        public virtual ICollection<gb_fp_s3_mat> gb_fp_s3_mat { get; set; }
        public virtual ICollection<gb_fp_s3_serv> gb_fp_s3_serv { get; set; }
        public virtual ICollection<gb_fp_s3_waste_liq> gb_fp_s3_waste_liq { get; set; }
        public virtual ICollection<gb_fp_s3_waste_sol> gb_fp_s3_waste_sol { get; set; }
        public virtual ICollection<gb_fp_waste_liq_data> gb_fp_waste_liq_data { get; set; }
        public virtual ICollection<gb_fp_waste_sol_data> gb_fp_waste_sol_data { get; set; }
        public virtual ICollection<hazard_container_type> hazard_container_type { get; set; }
        public virtual ICollection<msds_data> msds_data { get; set; }
        public virtual ICollection<msds_data> msds_data1 { get; set; }
        public virtual ICollection<msds_data> msds_data2 { get; set; }
        public virtual ICollection<msds_data> msds_data3 { get; set; }
        public virtual ICollection<msds_location> msds_location { get; set; }
        public virtual ICollection<msds_location> msds_location1 { get; set; }
        public virtual ICollection<msds_location> msds_location2 { get; set; }
        public virtual ICollection<waste_out> waste_out { get; set; }
    }
}
