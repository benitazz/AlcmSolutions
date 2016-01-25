using System;
using System.Collections.Generic;

namespace DurandalAuth.Domain.Models
{
    public partial class gb_fp_s1_fuel_comb
    {
        public string bl_id { get; set; }
        public short calc_year { get; set; }
        public string ch4_n2o_units { get; set; }
        public string ch4_n2o_units_type { get; set; }
        public Nullable<decimal> emiss_factor_ch4_entry { get; set; }
        public Nullable<decimal> emiss_factor_ch4_val { get; set; }
        public Nullable<decimal> emiss_factor_n2o_entry { get; set; }
        public Nullable<decimal> emiss_factor_n2o_val { get; set; }
        public string fuel_base_code { get; set; }
        public decimal fuel_consumed { get; set; }
        public decimal fuel_consumed_entry { get; set; }
        public string fuel_mode { get; set; }
        public string fuel_name { get; set; }
        public string fuel_units { get; set; }
        public string fuel_units_type { get; set; }
        public decimal kg_co2 { get; set; }
        public Nullable<decimal> oxid_factor_val { get; set; }
        public string scenario_id { get; set; }
        public string sector_name { get; set; }
        public string source_name { get; set; }
        public string tech_base_code { get; set; }
        public string tech_mode { get; set; }
        public string technology { get; set; }
        public int source_id { get; set; }
        public virtual bill_type bill_type { get; set; }
        public virtual bill_type bill_type1 { get; set; }
        public virtual bill_unit bill_unit { get; set; }
        public virtual bill_unit bill_unit1 { get; set; }
        public virtual gb_fp_fuel_types gb_fp_fuel_types { get; set; }
        public virtual gb_fp_fuel_types gb_fp_fuel_types1 { get; set; }
        public virtual gb_fp_fuels gb_fp_fuels { get; set; }
        public virtual gb_fp_fuels gb_fp_fuels1 { get; set; }
        public virtual gb_fp_setup gb_fp_setup { get; set; }
    }
}
